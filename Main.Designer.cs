namespace RDB_Mytne
{
    partial class Mytne
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadDataDialog = new OpenFileDialog();
            loadDataBtn = new Button();
            createVozidlo = new Button();
            createPlatba = new Button();
            createReport = new Button();
            CreditLeft = new Button();
            bt_close = new Button();
            SuspendLayout();
            // 
            // loadDataDialog
            // 
            loadDataDialog.Filter = "JSON files (*.json)|*.json";
            loadDataDialog.Title = "Load JSON data";
            // 
            // loadDataBtn
            // 
            loadDataBtn.Location = new Point(32, 61);
            loadDataBtn.Name = "loadDataBtn";
            loadDataBtn.Size = new Size(110, 57);
            loadDataBtn.TabIndex = 0;
            loadDataBtn.Text = "Vložit data";
            loadDataBtn.UseVisualStyleBackColor = true;
            loadDataBtn.Click += loadDataBtn_Click;
            // 
            // createVozidlo
            // 
            createVozidlo.Location = new Point(180, 61);
            createVozidlo.Name = "createVozidlo";
            createVozidlo.Size = new Size(138, 57);
            createVozidlo.TabIndex = 1;
            createVozidlo.Text = "Vytvořit registraci vozidla";
            createVozidlo.UseVisualStyleBackColor = true;
            createVozidlo.Click += createVozidlo_Click;
            // 
            // createPlatba
            // 
            createPlatba.Location = new Point(349, 61);
            createPlatba.Name = "createPlatba";
            createPlatba.Size = new Size(127, 57);
            createPlatba.TabIndex = 2;
            createPlatba.Text = "Vložit platbu";
            createPlatba.UseVisualStyleBackColor = true;
            createPlatba.Click += createPlatba_Click;
            // 
            // createReport
            // 
            createReport.Location = new Point(32, 158);
            createReport.Name = "createReport";
            createReport.Size = new Size(110, 64);
            createReport.TabIndex = 3;
            createReport.Text = "Vytvořit report";
            createReport.UseVisualStyleBackColor = true;
            createReport.Click += createReport_Click;
            // 
            // CreditLeft
            // 
            CreditLeft.Location = new Point(180, 158);
            CreditLeft.Name = "CreditLeft";
            CreditLeft.Size = new Size(138, 64);
            CreditLeft.TabIndex = 4;
            CreditLeft.Text = "Zbývající kredit";
            CreditLeft.UseVisualStyleBackColor = true;
            CreditLeft.Click += CreditLeft_Click;
            // 
            // bt_close
            // 
            bt_close.Location = new Point(349, 158);
            bt_close.Name = "bt_close";
            bt_close.Size = new Size(127, 64);
            bt_close.TabIndex = 5;
            bt_close.Text = "Zavřít";
            bt_close.UseVisualStyleBackColor = true;
            bt_close.Click += bt_close_Click;
            // 
            // Mytne
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 288);
            Controls.Add(bt_close);
            Controls.Add(CreditLeft);
            Controls.Add(createReport);
            Controls.Add(createPlatba);
            Controls.Add(createVozidlo);
            Controls.Add(loadDataBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Mytne";
            Text = "Mytne";
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog loadDataDialog;
        private Button loadDataBtn;
        private Button createVozidlo;
        private Button createPlatba;
        private Button createReport;
        private Button CreditLeft;
        private Button bt_close;
    }
}
