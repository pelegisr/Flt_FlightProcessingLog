using Infragistics.Win.UltraWinGrid;
using Peleg.Flt_FlightProcessingLog.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            LoadLogLines(100, 0, "");
        }

        private void LoadLogLines(int top, int pnr, string identifier)
        {
            var es = Peleg.NaumTools.Utils.Sql2Entity(SqlConnectionString, "Data.Model");

            using (var ent = new Ent(es))
            {
                var query = ent.FlightProcessingLogs.AsQueryable();

                // Filter by identifier if provided
                if (!string.IsNullOrWhiteSpace(identifier))
                {
                    query = query.Where(l => l.FlightIdentifier == identifier);
                }

                // If PNR is specified, find all related SessionIds
                if (pnr > 0)
                {
                    string pnrStr = pnr.ToString();

                    // First: find sessionIds of log lines where Message contains the pnr
                    var matchingSessionIds = query
                        .Where(l => l.Message.Contains(pnrStr))
                        .Select(l => l.SessionId)
                        .Distinct()
                        .ToList();

                    // If any matches found, filter the query to those SessionIds
                    if (matchingSessionIds.Any())
                    {
                        query = query.Where(l => matchingSessionIds.Contains(l.SessionId));
                    }
                    else
                    {
                        // No matches, return empty list
                        egLogLines.DataSource = new List<FlightProcessingLog>();
                        return;
                    }
                }

                // Apply ordering and take top N
                var topLogLines = query
                    .OrderByDescending(l => l.Id)
                    .Take(top)
                    .ToList();

                egLogLines.DataSource = topLogLines;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            int top = numericUpDown1.Value > 0 ? (int)numericUpDown1.Value : 100;
            int pnr = txtPnr.Text.Length > 0 ? int.Parse(txtPnr.Text) : 0;
            string identifier = txtIdentifier.Text;
            LoadLogLines(top, pnr, identifier);
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
            band.Columns["FlightIdentifier"].Header.Caption = "Identifier";
            band.Columns["Timestamp"].Format = "dd/MM/yyyy HH:mm:ss";
        }

        private void txtPnr_KeyDown(object sender, KeyEventArgs e)
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

        private void chkGroupBySession_CheckedChanged(object sender, EventArgs e)
        {
            var band = egLogLines.DisplayLayout.Bands[0];

            if (chkGroupBySession.Checked)
            {
                // Add grouping by SessionId
                band.SortedColumns.Add("SessionId", false, true);
                // Then sort by Id ascending inside each group
                band.SortedColumns.Add("Id", false, false);

                foreach (UltraGridRow row in egLogLines.Rows)
                {
                    if (row.IsGroupByRow) row.Expanded = true;
                }
            }
            else
            {
                // Remove grouping by SessionId if exists
                var groupByColumn = band.SortedColumns
                    .OfType<UltraGridColumn>() // Corrected type to UltraGridColumn
                    .FirstOrDefault(c => c.IsGroupByColumn && c.Key == "SessionId");

                if (groupByColumn != null)
                {
                    band.SortedColumns.Remove(groupByColumn);
                }
            }
        }
    }
}
