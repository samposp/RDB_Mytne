namespace RDB_Mytne
{
    partial class CreateVozidlo
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
            tb_spz = new TextBox();
            tb_typVozidla = new TextBox();
            tb_emisniTrida = new TextBox();
            lb_spz = new Label();
            lb_ico = new Label();
            lb_hmotnost = new Label();
            lb_typ = new Label();
            num_hmotnost = new NumericUpDown();
            lb_emisni_trida = new Label();
            bt_create = new Button();
            bt_cancel = new Button();
            cb_ico = new ComboBox();
            lb_kmSazba = new Label();
            num_kmSazba = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)num_hmotnost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_kmSazba).BeginInit();
            SuspendLayout();
            // 
            // tb_spz
            // 
            tb_spz.Location = new Point(153, 40);
            tb_spz.Name = "tb_spz";
            tb_spz.Size = new Size(125, 27);
            tb_spz.TabIndex = 0;
            // 
            // tb_typVozidla
            // 
            tb_typVozidla.Location = new Point(153, 181);
            tb_typVozidla.Name = "tb_typVozidla";
            tb_typVozidla.Size = new Size(125, 27);
            tb_typVozidla.TabIndex = 4;
            // 
            // tb_emisniTrida
            // 
            tb_emisniTrida.Location = new Point(153, 233);
            tb_emisniTrida.Name = "tb_emisniTrida";
            tb_emisniTrida.Size = new Size(125, 27);
            tb_emisniTrida.TabIndex = 5;
            // 
            // lb_spz
            // 
            lb_spz.AutoSize = true;
            lb_spz.Location = new Point(57, 40);
            lb_spz.Name = "lb_spz";
            lb_spz.Size = new Size(34, 20);
            lb_spz.TabIndex = 6;
            lb_spz.Text = "SPZ";
            // 
            // lb_ico
            // 
            lb_ico.AutoSize = true;
            lb_ico.Location = new Point(57, 84);
            lb_ico.Name = "lb_ico";
            lb_ico.Size = new Size(33, 20);
            lb_ico.TabIndex = 7;
            lb_ico.Text = "ICO";
            // 
            // lb_hmotnost
            // 
            lb_hmotnost.AutoSize = true;
            lb_hmotnost.Location = new Point(57, 137);
            lb_hmotnost.Name = "lb_hmotnost";
            lb_hmotnost.Size = new Size(75, 20);
            lb_hmotnost.TabIndex = 8;
            lb_hmotnost.Text = "Hmotnost";
            // 
            // lb_typ
            // 
            lb_typ.AutoSize = true;
            lb_typ.Location = new Point(57, 185);
            lb_typ.Name = "lb_typ";
            lb_typ.Size = new Size(84, 20);
            lb_typ.TabIndex = 9;
            lb_typ.Text = "Typ vozidla";
            // 
            // num_hmotnost
            // 
            num_hmotnost.Location = new Point(153, 135);
            num_hmotnost.Name = "num_hmotnost";
            num_hmotnost.Size = new Size(125, 27);
            num_hmotnost.TabIndex = 10;
            // 
            // lb_emisni_trida
            // 
            lb_emisni_trida.AutoSize = true;
            lb_emisni_trida.Location = new Point(57, 233);
            lb_emisni_trida.Name = "lb_emisni_trida";
            lb_emisni_trida.Size = new Size(87, 20);
            lb_emisni_trida.TabIndex = 11;
            lb_emisni_trida.Text = "Emisní třída";
            // 
            // bt_create
            // 
            bt_create.BackColor = SystemColors.Control;
            bt_create.Location = new Point(205, 339);
            bt_create.Name = "bt_create";
            bt_create.Size = new Size(94, 29);
            bt_create.TabIndex = 13;
            bt_create.Text = "Vytvořit";
            bt_create.UseVisualStyleBackColor = false;
            bt_create.Click += bt_create_Click;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(50, 339);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(94, 29);
            bt_cancel.TabIndex = 14;
            bt_cancel.Text = "Zrušit";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // cb_ico
            // 
            cb_ico.FormattingEnabled = true;
            cb_ico.Location = new Point(151, 84);
            cb_ico.Name = "cb_ico";
            cb_ico.Size = new Size(127, 28);
            cb_ico.TabIndex = 15;
            // 
            // lb_kmSazba
            // 
            lb_kmSazba.AutoSize = true;
            lb_kmSazba.Location = new Point(60, 286);
            lb_kmSazba.Name = "lb_kmSazba";
            lb_kmSazba.Size = new Size(73, 20);
            lb_kmSazba.TabIndex = 16;
            lb_kmSazba.Text = "Km sazba";
            // 
            // num_kmSazba
            // 
            num_kmSazba.Location = new Point(153, 286);
            num_kmSazba.Name = "num_kmSazba";
            num_kmSazba.Size = new Size(125, 27);
            num_kmSazba.TabIndex = 17;
            // 
            // CreateVozidlo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 399);
            Controls.Add(num_kmSazba);
            Controls.Add(lb_kmSazba);
            Controls.Add(cb_ico);
            Controls.Add(bt_cancel);
            Controls.Add(bt_create);
            Controls.Add(lb_emisni_trida);
            Controls.Add(num_hmotnost);
            Controls.Add(lb_typ);
            Controls.Add(lb_hmotnost);
            Controls.Add(lb_ico);
            Controls.Add(lb_spz);
            Controls.Add(tb_emisniTrida);
            Controls.Add(tb_typVozidla);
            Controls.Add(tb_spz);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreateVozidlo";
            Text = "Vytvořit registraci vozidla";
            ((System.ComponentModel.ISupportInitialize)num_hmotnost).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_kmSazba).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_spz;
        private TextBox textBox3;
        private TextBox tb_typVozidla;
        private TextBox tb_emisniTrida;
        private Label lb_spz;
        private Label lb_ico;
        private Label lb_hmotnost;
        private Label lb_typ;
        private NumericUpDown num_hmotnost;
        private Label lb_emisni_trida;
        private Button bt_create;
        private Button bt_cancel;
        private ComboBox cb_ico;
        private Label lb_kmSazba;
        private NumericUpDown num_kmSazba;
    }
}