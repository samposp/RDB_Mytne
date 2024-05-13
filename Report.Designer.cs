namespace RDB_Mytne
{
    partial class Report
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
            cb_spz = new ComboBox();
            lb_spz = new Label();
            lb_od = new Label();
            lb_do = new Label();
            dt_od = new DateTimePicker();
            dt_do = new DateTimePicker();
            bt_createReport = new Button();
            tb_report = new TextBox();
            bt_close = new Button();
            SuspendLayout();
            // 
            // cb_spz
            // 
            cb_spz.FormattingEnabled = true;
            cb_spz.Location = new Point(61, 38);
            cb_spz.Name = "cb_spz";
            cb_spz.Size = new Size(151, 28);
            cb_spz.TabIndex = 0;
            // 
            // lb_spz
            // 
            lb_spz.AutoSize = true;
            lb_spz.Location = new Point(21, 46);
            lb_spz.Name = "lb_spz";
            lb_spz.Size = new Size(34, 20);
            lb_spz.TabIndex = 1;
            lb_spz.Text = "SPZ";
            // 
            // lb_od
            // 
            lb_od.AutoSize = true;
            lb_od.Location = new Point(21, 84);
            lb_od.Name = "lb_od";
            lb_od.Size = new Size(29, 20);
            lb_od.TabIndex = 2;
            lb_od.Text = "Od";
            // 
            // lb_do
            // 
            lb_do.AutoSize = true;
            lb_do.Location = new Point(21, 126);
            lb_do.Name = "lb_do";
            lb_do.Size = new Size(29, 20);
            lb_do.TabIndex = 3;
            lb_do.Text = "Do";
            // 
            // dt_od
            // 
            dt_od.Format = DateTimePickerFormat.Short;
            dt_od.Location = new Point(61, 84);
            dt_od.Name = "dt_od";
            dt_od.Size = new Size(102, 27);
            dt_od.TabIndex = 4;
            // 
            // dt_do
            // 
            dt_do.Format = DateTimePickerFormat.Short;
            dt_do.Location = new Point(63, 126);
            dt_do.Name = "dt_do";
            dt_do.Size = new Size(100, 27);
            dt_do.TabIndex = 5;
            // 
            // bt_createReport
            // 
            bt_createReport.Location = new Point(144, 217);
            bt_createReport.Name = "bt_createReport";
            bt_createReport.Size = new Size(94, 29);
            bt_createReport.TabIndex = 6;
            bt_createReport.Text = "Vytvořit report";
            bt_createReport.UseVisualStyleBackColor = true;
            bt_createReport.Click += bt_createReport_Click;
            // 
            // tb_report
            // 
            tb_report.Location = new Point(264, 26);
            tb_report.Multiline = true;
            tb_report.Name = "tb_report";
            tb_report.ReadOnly = true;
            tb_report.ScrollBars = ScrollBars.Vertical;
            tb_report.Size = new Size(468, 318);
            tb_report.TabIndex = 8;
            tb_report.WordWrap = false;
            // 
            // bt_close
            // 
            bt_close.Location = new Point(21, 217);
            bt_close.Name = "bt_close";
            bt_close.Size = new Size(94, 29);
            bt_close.TabIndex = 9;
            bt_close.Text = "Zavřít";
            bt_close.UseVisualStyleBackColor = true;
            bt_close.Click += bt_close_Click_1;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 388);
            Controls.Add(bt_close);
            Controls.Add(tb_report);
            Controls.Add(bt_createReport);
            Controls.Add(dt_do);
            Controls.Add(dt_od);
            Controls.Add(lb_do);
            Controls.Add(lb_od);
            Controls.Add(lb_spz);
            Controls.Add(cb_spz);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Report";
            Text = "Report";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_spz;
        private Label lb_spz;
        private Label lb_od;
        private Label lb_do;
        private DateTimePicker dt_od;
        private DateTimePicker dt_do;
        private Button bt_createReport;
        private TextBox tb_report;
        private Button bt_close;
    }
}