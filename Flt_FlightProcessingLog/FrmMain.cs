using Infragistics.Win.UltraWinGrid;
using Peleg.Flt_FlightProcessingLog.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flt_FlightProcessingLog
{
    public partial class FrmMain: Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public string SqlConnectionString { get; set; }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            btnSearch_Click(sender, e);
        }

        private void LoadLogLines(DateTime fromDate, DateTime toDate, int Fl_id, string identifier)
        {
            var es = Peleg.NaumTools.Utils.Sql2Entity(SqlConnectionString, "Data.Model");

            using (var ent = new Ent(es))
            {
                var baseQuery = ent.FlightProcessingLogs.AsQueryable();

                // Filter by date range (date only, inclusive)
                baseQuery = baseQuery.Where(l =>
                    DbFunctions.TruncateTime(l.Timestamp) >= fromDate.Date &&
                    DbFunctions.TruncateTime(l.Timestamp) <= toDate.Date);

                var sessionIdQuery = baseQuery;

                List<Guid?> matchingSessionIds = null;

                // If identifier is provided, filter for messages with matching identifier
                if (!string.IsNullOrWhiteSpace(identifier))
                {
                    sessionIdQuery = sessionIdQuery.Where(l => l.FlightIdentifier == identifier);
                }

                // If Fl_id is provided, further filter for messages containing the Fl_id
                if (Fl_id > 0)
                {
                    string Fl_idStr = Fl_id.ToString();
                    sessionIdQuery = sessionIdQuery.Where(l => l.Message.Contains(Fl_idStr));
                }

                // If either identifier or Fl_id was provided, get matching SessionIds
                if (!string.IsNullOrWhiteSpace(identifier) || Fl_id > 0)
                {
                    matchingSessionIds = sessionIdQuery
                        .Select(l => l.SessionId)
                        .Distinct()
                        .ToList();

                    // If none found, return empty
                    if (!matchingSessionIds.Any())
                    {
                        egLogLines.DataSource = new List<FlightProcessingLog>();
                        return;
                    }

                    // Filter main query to matching sessionIds
                    baseQuery = baseQuery.Where(l => matchingSessionIds.Contains(l.SessionId));
                }

                // Final ordering
                var logLines = baseQuery
                    .OrderBy(l => l.Id)
                    .ToList();

                // Compute MinIdForSession for sorting/grouping
                var logsWithMin = logLines
                    .GroupBy(l => l.SessionId)
                    .SelectMany(g =>
                    {
                        int minId = g.Min(x => x.Id);
                        foreach (var log in g)
                        {
                            log.MinIdForSession = minId;
                        }
                        return g;
                    })
                    .ToList();

                egLogLines.DataSource = logLines;
                chkGroupBySession_CheckedChanged(logLines, EventArgs.Empty); // Reapply grouping if needed
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime fromDate = (DateTime)udtFrom.Value;
            DateTime toDate = (DateTime)udtTo.Value;
            int FlId = txtFlId.Text.Length > 0 ? int.Parse(txtFlId.Text) : 0;
            string identifier = txtIdentifier.Text;
            LoadLogLines(fromDate, toDate, FlId, identifier);
        }

        private void egLogLines_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            UltraGridBand band = e.Layout.Bands[0];

            // Optional: Set all other columns to fixed width
            foreach (UltraGridColumn col in band.Columns)
            {
                col.CellActivation = Activation.ActivateOnly;

                col.MinWidth = 20;
                if (col.Key == "Message")
                {
                    continue; // Skip the Message column
                }
                col.Width = 50;
                col.MaxWidth = 100;
                if (col.Key == "SessionId")
                {
                    col.MaxWidth = 230;
                }
                if (col.Key == "Timestamp")
                {
                    col.Width = 75;
                    col.MaxWidth = 230;
                }
            }
            band.Columns["id"].Hidden = true;
            band.Columns["MinIdForSession"].Hidden = true;
            band.Columns["FlightIdentifier"].Header.Caption = "Identifier";
            band.Columns["Timestamp"].Format = "dd/MM/yyyy HH:mm:ss";
        }

        private void txtFlId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent "ding" sound
            }
        }

        private void txtIdentifier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent "ding" sound
            }
        }

        private void udtFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent "ding" sound
            }
        }

        private void udtTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true; // Prevent "ding" sound
            }
        }

        private void chkGroupBySession_CheckedChanged(object sender, EventArgs e)
        {
            var band = egLogLines.DisplayLayout.Bands[0];

            band.SortedColumns.Clear();

            if (chkGroupBySession.Checked)
            {
                // Group by SessionId
                band.SortedColumns.Add("MinIdForSession", false, true);

                // Sort rows inside each group by Id
                band.SortedColumns.Add("Id", false, false);
                
                // Expand groups
                foreach (UltraGridRow row in egLogLines.Rows)
                {
                    if (row.IsGroupByRow) row.Expanded = true;
                }
            }
            else
            {
                // Remove grouping and just sort by Id DESC
                band.SortedColumns.Add("Id", false);
                band.SortedColumns["Id"].SortIndicator = SortIndicator.Descending;
            }
        }

        private void egLogLines_InitializeGroupByRow(object sender, InitializeGroupByRowEventArgs e)
        {
            if (e.Row.Column.Key == "MinIdForSession")
            {
                // Get one log row from the group
                var log = e.Row.Rows.OfType<UltraGridRow>().FirstOrDefault()?.ListObject as FlightProcessingLog;
                if (log != null)
                {
                    e.Row.Description = $"Session: {log.SessionId} {log.Timestamp}";
                }
            }
        }
    }
}
