namespace RDB_Mytne
{
    partial class CreditLeft
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
            lb_spz = new Label();
            cb_spz = new ComboBox();
            bt_calculate = new Button();
            bt_cancel = new Button();
            lb_creditLeft = new Label();
            tb_creaditLeft = new TextBox();
            SuspendLayout();
            // 
            // lb_spz
            // 
            lb_spz.AutoSize = true;
            lb_spz.Location = new Point(48, 34);
            lb_spz.Name = "lb_spz";
            lb_spz.Size = new Size(34, 20);
            lb_spz.TabIndex = 0;
            lb_spz.Text = "SPZ";
            // 
            // cb_spz
            // 
            cb_spz.FormattingEnabled = true;
            cb_spz.Location = new Point(108, 31);
            cb_spz.Name = "cb_spz";
            cb_spz.Size = new Size(151, 28);
            cb_spz.TabIndex = 1;
            // 
            // bt_calculate
            // 
            bt_calculate.Location = new Point(206, 169);
            bt_calculate.Name = "bt_calculate";
            bt_calculate.Size = new Size(94, 29);
            bt_calculate.TabIndex = 2;
            bt_calculate.Text = "Vypočti";
            bt_calculate.UseVisualStyleBackColor = true;
            bt_calculate.Click += bt_calculate_Click;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(38, 169);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(94, 29);
            bt_cancel.TabIndex = 3;
            bt_cancel.Text = "Zavřít";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // lb_creditLeft
            // 
            lb_creditLeft.AutoSize = true;
            lb_creditLeft.Location = new Point(48, 102);
            lb_creditLeft.Name = "lb_creditLeft";
            lb_creditLeft.Size = new Size(110, 20);
            lb_creditLeft.TabIndex = 4;
            lb_creditLeft.Text = "Zbývající kredit";
            // 
            // tb_creaditLeft
            // 
            tb_creaditLeft.Location = new Point(175, 99);
            tb_creaditLeft.Name = "tb_creaditLeft";
            tb_creaditLeft.ReadOnly = true;
            tb_creaditLeft.Size = new Size(125, 27);
            tb_creaditLeft.TabIndex = 5;
            // 
            // CreditLeft
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 239);
            Controls.Add(tb_creaditLeft);
            Controls.Add(lb_creditLeft);
            Controls.Add(bt_cancel);
            Controls.Add(bt_calculate);
            Controls.Add(cb_spz);
            Controls.Add(lb_spz);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreditLeft";
            Text = "Výpočet kreditu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_spz;
        private ComboBox cb_spz;
        private Button bt_calculate;
        private Button bt_cancel;
        private Label lb_creditLeft;
        private TextBox tb_creaditLeft;
    }
}