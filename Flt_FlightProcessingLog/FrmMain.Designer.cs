namespace Flt_FlightProcessingLog
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            this.uPanel1 = new Peleg.UPanelInfo.UPanel();
            this.egLogLines = new Peleg.CustomControls.ExtendedGrid(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkError = new System.Windows.Forms.CheckBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFlt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.udtFlightDate = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.udtFrom = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.udtTo = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.chkGroupBySession = new System.Windows.Forms.CheckBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblIdentifier = new System.Windows.Forms.Label();
            this.txtIdentifier = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.egLogLines)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udtFlightDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtTo)).BeginInit();
            this.SuspendLayout();
            // 
            // uPanel1
            // 
            this.uPanel1.ChangeParentIcon = true;
            this.uPanel1.ChangeSystemLogo = true;
            this.uPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uPanel1.Location = new System.Drawing.Point(0, 0);
            this.uPanel1.MinimumSize = new System.Drawing.Size(642, 52);
            this.uPanel1.Mode = "";
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.Size = new System.Drawing.Size(642, 52);
            this.uPanel1.TabIndex = 0;
            this.uPanel1.TranslateParent = false;
            this.uPanel1.WindowLess = false;
            // 
            // egLogLines
            // 
            appearance1.BackColor = System.Drawing.SystemColors.Window;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.egLogLines.DisplayLayout.Appearance = appearance1;
            this.egLogLines.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            this.egLogLines.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.egLogLines.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance2.BorderColor = System.Drawing.SystemColors.Window;
            this.egLogLines.DisplayLayout.GroupByBox.Appearance = appearance2;
            appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.egLogLines.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
            this.egLogLines.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.egLogLines.DisplayLayout.GroupByBox.Hidden = true;
            appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance4.BackColor2 = System.Drawing.SystemColors.Control;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.egLogLines.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
            this.egLogLines.DisplayLayout.MaxColScrollRegions = 1;
            this.egLogLines.DisplayLayout.MaxRowScrollRegions = 1;
            appearance5.BackColor = System.Drawing.SystemColors.Window;
            appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.egLogLines.DisplayLayout.Override.ActiveCellAppearance = appearance5;
            appearance6.BackColor = System.Drawing.SystemColors.Highlight;
            appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.egLogLines.DisplayLayout.Override.ActiveRowAppearance = appearance6;
            this.egLogLines.DisplayLayout.Override.AllowMultiCellOperations = Infragistics.Win.UltraWinGrid.AllowMultiCellOperation.Copy;
            this.egLogLines.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.egLogLines.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            this.egLogLines.DisplayLayout.Override.CardAreaAppearance = appearance7;
            appearance8.BorderColor = System.Drawing.Color.Silver;
            appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.egLogLines.DisplayLayout.Override.CellAppearance = appearance8;
            this.egLogLines.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
            this.egLogLines.DisplayLayout.Override.CellPadding = 0;
            appearance9.BackColor = System.Drawing.SystemColors.Control;
            appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance9.BorderColor = System.Drawing.SystemColors.Window;
            this.egLogLines.DisplayLayout.Override.GroupByRowAppearance = appearance9;
            appearance10.TextHAlignAsString = "Left";
            this.egLogLines.DisplayLayout.Override.HeaderAppearance = appearance10;
            this.egLogLines.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.Select;
            this.egLogLines.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.BorderColor = System.Drawing.Color.Silver;
            this.egLogLines.DisplayLayout.Override.RowAppearance = appearance11;
            this.egLogLines.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.egLogLines.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.Single;
            this.egLogLines.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.None;
            appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.egLogLines.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
            this.egLogLines.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.egLogLines.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.egLogLines.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.egLogLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.egLogLines.FilterDisableFields = null;
            this.egLogLines.FilterListFields = null;
            this.egLogLines.Location = new System.Drawing.Point(0, 103);
            this.egLogLines.Name = "egLogLines";
            this.egLogLines.PrimeryFilter = null;
            this.egLogLines.SearchMode = Peleg.CustomControls.ExtendedGrid.SearchModeEnum.OnPatternChange;
            this.egLogLines.SearchStyle = Peleg.CustomControls.ExtendedGrid.SearchStyleEnum.AllWord;
            this.egLogLines.Size = new System.Drawing.Size(943, 415);
            this.egLogLines.TabIndex = 1;
            this.egLogLines.Text = "egLogLines";
            this.egLogLines.InitializeLayout += new Infragistics.Win.UltraWinGrid.InitializeLayoutEventHandler(this.egLogLines_InitializeLayout);
            this.egLogLines.InitializeRow += new Infragistics.Win.UltraWinGrid.InitializeRowEventHandler(this.egLogLines_InitializeRow);
            this.egLogLines.InitializeGroupByRow += new Infragistics.Win.UltraWinGrid.InitializeGroupByRowEventHandler(this.egLogLines_InitializeGroupByRow);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkError);
            this.panel1.Controls.Add(this.txtNumber);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFlt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.udtFlightDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.udtFrom);
            this.panel1.Controls.Add(this.udtTo);
            this.panel1.Controls.Add(this.chkGroupBySession);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lblIdentifier);
            this.panel1.Controls.Add(this.txtIdentifier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 51);
            this.panel1.TabIndex = 2;
            // 
            // chkError
            // 
            this.chkError.AutoSize = true;
            this.chkError.Checked = true;
            this.chkError.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkError.Location = new System.Drawing.Point(486, 25);
            this.chkError.Name = "chkError";
            this.chkError.Size = new System.Drawing.Size(118, 17);
            this.chkError.TabIndex = 16;
            this.chkError.Text = "Display failures only";
            this.chkError.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(333, 23);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(40, 20);
            this.txtNumber.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(330, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number";
            // 
            // txtFlt
            // 
            this.txtFlt.Location = new System.Drawing.Point(287, 23);
            this.txtFlt.Name = "txtFlt";
            this.txtFlt.Size = new System.Drawing.Size(40, 20);
            this.txtFlt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Flight";
            // 
            // udtFlightDate
            // 
            this.udtFlightDate.DateTime = new System.DateTime(2025, 10, 23, 0, 0, 0, 0);
            this.udtFlightDate.Location = new System.Drawing.Point(197, 22);
            this.udtFlightDate.Name = "udtFlightDate";
            this.udtFlightDate.Size = new System.Drawing.Size(77, 21);
            this.udtFlightDate.TabIndex = 3;
            this.udtFlightDate.Value = new System.DateTime(2025, 10, 23, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Flight Date";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(92, 26);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(10, 13);
            this.lblTo.TabIndex = 10;
            this.lblTo.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Xml received date:";
            // 
            // udtFrom
            // 
            this.udtFrom.DateTime = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.udtFrom.Location = new System.Drawing.Point(12, 22);
            this.udtFrom.Name = "udtFrom";
            this.udtFrom.Size = new System.Drawing.Size(77, 21);
            this.udtFrom.TabIndex = 1;
            this.udtFrom.Value = null;
            this.udtFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.udtFrom_KeyDown);
            // 
            // udtTo
            // 
            this.udtTo.DateTime = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.udtTo.Location = new System.Drawing.Point(105, 22);
            this.udtTo.Name = "udtTo";
            this.udtTo.Size = new System.Drawing.Size(71, 21);
            this.udtTo.TabIndex = 2;
            this.udtTo.Value = null;
            // 
            // chkGroupBySession
            // 
            this.chkGroupBySession.AutoSize = true;
            this.chkGroupBySession.Checked = true;
            this.chkGroupBySession.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGroupBySession.Location = new System.Drawing.Point(821, 25);
            this.chkGroupBySession.Name = "chkGroupBySession";
            this.chkGroupBySession.Size = new System.Drawing.Size(110, 17);
            this.chkGroupBySession.TabIndex = 8;
            this.chkGroupBySession.Text = "Group By Session";
            this.chkGroupBySession.UseVisualStyleBackColor = true;
            this.chkGroupBySession.CheckedChanged += new System.EventHandler(this.chkGroupBySession_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(610, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 22);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblIdentifier
            // 
            this.lblIdentifier.AutoSize = true;
            this.lblIdentifier.Location = new System.Drawing.Point(389, 6);
            this.lblIdentifier.Name = "lblIdentifier";
            this.lblIdentifier.Size = new System.Drawing.Size(47, 13);
            this.lblIdentifier.TabIndex = 4;
            this.lblIdentifier.Text = "Identifier";
            // 
            // txtIdentifier
            // 
            this.txtIdentifier.Location = new System.Drawing.Point(392, 23);
            this.txtIdentifier.Name = "txtIdentifier";
            this.txtIdentifier.Size = new System.Drawing.Size(88, 20);
            this.txtIdentifier.TabIndex = 6;
            this.txtIdentifier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentifier_KeyDown);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 518);
            this.Controls.Add(this.egLogLines);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uPanel1);
            this.Name = "FrmMain";
            this.Text = "Flight Processing Log";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.egLogLines)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udtFlightDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udtTo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Peleg.UPanelInfo.UPanel uPanel1;
        private Peleg.CustomControls.ExtendedGrid egLogLines;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIdentifier;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblIdentifier;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtTo;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkGroupBySession;
        private System.Windows.Forms.TextBox txtFlt;
        private System.Windows.Forms.Label label3;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udtFlightDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.CheckBox chkError;
    }
}

