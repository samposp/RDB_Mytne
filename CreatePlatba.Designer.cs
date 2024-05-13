namespace RDB_Mytne
{
    partial class CreatePlatba
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
            lb_castka = new Label();
            lb_typ = new Label();
            num_castka = new NumericUpDown();
            rb_hotovost = new RadioButton();
            rb_Karta = new RadioButton();
            rb_Prevod = new RadioButton();
            lb_cislo_karty = new Label();
            lb_platnost = new Label();
            lb_vlastnik = new Label();
            tb_cisloKarty = new TextBox();
            dt_platnost = new DateTimePicker();
            tb_vlastnik = new TextBox();
            lb_cisloUctu = new Label();
            lb_kodBanky = new Label();
            tb_kodBanky = new TextBox();
            tb_cisloUctu = new TextBox();
            bt_vlozit = new Button();
            bt_cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)num_castka).BeginInit();
            SuspendLayout();
            // 
            // cb_spz
            // 
            cb_spz.FormattingEnabled = true;
            cb_spz.Location = new Point(96, 26);
            cb_spz.Name = "cb_spz";
            cb_spz.Size = new Size(141, 28);
            cb_spz.TabIndex = 0;
            // 
            // lb_spz
            // 
            lb_spz.AutoSize = true;
            lb_spz.Location = new Point(22, 29);
            lb_spz.Name = "lb_spz";
            lb_spz.Size = new Size(31, 20);
            lb_spz.TabIndex = 1;
            lb_spz.Text = "spz";
            // 
            // lb_castka
            // 
            lb_castka.AutoSize = true;
            lb_castka.Location = new Point(22, 68);
            lb_castka.Name = "lb_castka";
            lb_castka.Size = new Size(52, 20);
            lb_castka.TabIndex = 2;
            lb_castka.Text = "Částka";
            // 
            // lb_typ
            // 
            lb_typ.AutoSize = true;
            lb_typ.Location = new Point(22, 109);
            lb_typ.Name = "lb_typ";
            lb_typ.Size = new Size(32, 20);
            lb_typ.TabIndex = 3;
            lb_typ.Text = "Typ";
            // 
            // num_castka
            // 
            num_castka.Location = new Point(96, 68);
            num_castka.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            num_castka.Name = "num_castka";
            num_castka.Size = new Size(141, 27);
            num_castka.TabIndex = 4;
            // 
            // rb_hotovost
            // 
            rb_hotovost.AutoSize = true;
            rb_hotovost.Location = new Point(96, 109);
            rb_hotovost.Name = "rb_hotovost";
            rb_hotovost.Size = new Size(91, 24);
            rb_hotovost.TabIndex = 5;
            rb_hotovost.TabStop = true;
            rb_hotovost.Text = "Hotovost";
            rb_hotovost.UseVisualStyleBackColor = true;
            rb_hotovost.CheckedChanged += rb_hotovost_CheckedChanged;
            // 
            // rb_Karta
            // 
            rb_Karta.AutoSize = true;
            rb_Karta.Location = new Point(96, 139);
            rb_Karta.Name = "rb_Karta";
            rb_Karta.Size = new Size(65, 24);
            rb_Karta.TabIndex = 6;
            rb_Karta.TabStop = true;
            rb_Karta.Text = "Karta";
            rb_Karta.UseVisualStyleBackColor = true;
            rb_Karta.CheckedChanged += rb_Karta_CheckedChanged;
            // 
            // rb_Prevod
            // 
            rb_Prevod.AutoSize = true;
            rb_Prevod.Location = new Point(96, 169);
            rb_Prevod.Name = "rb_Prevod";
            rb_Prevod.Size = new Size(76, 24);
            rb_Prevod.TabIndex = 7;
            rb_Prevod.TabStop = true;
            rb_Prevod.Text = "Převod";
            rb_Prevod.UseVisualStyleBackColor = true;
            rb_Prevod.CheckedChanged += rb_Prevod_CheckedChanged;
            // 
            // lb_cislo_karty
            // 
            lb_cislo_karty.AutoSize = true;
            lb_cislo_karty.Location = new Point(300, 34);
            lb_cislo_karty.Name = "lb_cislo_karty";
            lb_cislo_karty.Size = new Size(77, 20);
            lb_cislo_karty.TabIndex = 8;
            lb_cislo_karty.Text = "Číslo karty";
            // 
            // lb_platnost
            // 
            lb_platnost.AutoSize = true;
            lb_platnost.Location = new Point(300, 75);
            lb_platnost.Name = "lb_platnost";
            lb_platnost.Size = new Size(62, 20);
            lb_platnost.TabIndex = 9;
            lb_platnost.Text = "Platnost";
            // 
            // lb_vlastnik
            // 
            lb_vlastnik.AutoSize = true;
            lb_vlastnik.Location = new Point(300, 120);
            lb_vlastnik.Name = "lb_vlastnik";
            lb_vlastnik.Size = new Size(60, 20);
            lb_vlastnik.TabIndex = 10;
            lb_vlastnik.Text = "Vlastník";
            // 
            // tb_cisloKarty
            // 
            tb_cisloKarty.Location = new Point(399, 26);
            tb_cisloKarty.Name = "tb_cisloKarty";
            tb_cisloKarty.Size = new Size(125, 27);
            tb_cisloKarty.TabIndex = 11;
            // 
            // dt_platnost
            // 
            dt_platnost.CustomFormat = "MM/yyyy";
            dt_platnost.Format = DateTimePickerFormat.Custom;
            dt_platnost.ImeMode = ImeMode.On;
            dt_platnost.Location = new Point(399, 75);
            dt_platnost.Name = "dt_platnost";
            dt_platnost.ShowUpDown = true;
            dt_platnost.Size = new Size(125, 27);
            dt_platnost.TabIndex = 12;
            // 
            // tb_vlastnik
            // 
            tb_vlastnik.Location = new Point(399, 120);
            tb_vlastnik.Name = "tb_vlastnik";
            tb_vlastnik.Size = new Size(125, 27);
            tb_vlastnik.TabIndex = 13;
            // 
            // lb_cisloUctu
            // 
            lb_cisloUctu.AutoSize = true;
            lb_cisloUctu.Location = new Point(300, 34);
            lb_cisloUctu.Name = "lb_cisloUctu";
            lb_cisloUctu.Size = new Size(73, 20);
            lb_cisloUctu.TabIndex = 14;
            lb_cisloUctu.Text = "Číslo účtu";
            // 
            // lb_kodBanky
            // 
            lb_kodBanky.AutoSize = true;
            lb_kodBanky.Location = new Point(300, 75);
            lb_kodBanky.Name = "lb_kodBanky";
            lb_kodBanky.Size = new Size(79, 20);
            lb_kodBanky.TabIndex = 15;
            lb_kodBanky.Text = "Kód banky";
            // 
            // tb_kodBanky
            // 
            tb_kodBanky.Location = new Point(399, 77);
            tb_kodBanky.Name = "tb_kodBanky";
            tb_kodBanky.Size = new Size(125, 27);
            tb_kodBanky.TabIndex = 16;
            // 
            // tb_cisloUctu
            // 
            tb_cisloUctu.Location = new Point(399, 32);
            tb_cisloUctu.Name = "tb_cisloUctu";
            tb_cisloUctu.Size = new Size(125, 27);
            tb_cisloUctu.TabIndex = 17;
            // 
            // bt_vlozit
            // 
            bt_vlozit.Location = new Point(430, 167);
            bt_vlozit.Name = "bt_vlozit";
            bt_vlozit.Size = new Size(94, 29);
            bt_vlozit.TabIndex = 18;
            bt_vlozit.Text = "Vložit";
            bt_vlozit.UseVisualStyleBackColor = true;
            bt_vlozit.Click += bt_vlozit_Click;
            // 
            // bt_cancel
            // 
            bt_cancel.Location = new Point(279, 167);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(94, 29);
            bt_cancel.TabIndex = 19;
            bt_cancel.Text = "Zrušit";
            bt_cancel.UseVisualStyleBackColor = true;
            bt_cancel.Click += bt_cancel_Click;
            // 
            // CreatePlatba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 214);
            Controls.Add(bt_cancel);
            Controls.Add(bt_vlozit);
            Controls.Add(tb_cisloUctu);
            Controls.Add(tb_kodBanky);
            Controls.Add(lb_kodBanky);
            Controls.Add(lb_cisloUctu);
            Controls.Add(tb_vlastnik);
            Controls.Add(dt_platnost);
            Controls.Add(tb_cisloKarty);
            Controls.Add(lb_vlastnik);
            Controls.Add(lb_platnost);
            Controls.Add(lb_cislo_karty);
            Controls.Add(rb_Prevod);
            Controls.Add(rb_Karta);
            Controls.Add(rb_hotovost);
            Controls.Add(num_castka);
            Controls.Add(lb_typ);
            Controls.Add(lb_castka);
            Controls.Add(lb_spz);
            Controls.Add(cb_spz);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreatePlatba";
            Text = "Vložit platbu";
            ((System.ComponentModel.ISupportInitialize)num_castka).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_spz;
        private Label lb_spz;
        private Label lb_castka;
        private Label lb_typ;
        private NumericUpDown num_castka;
        private RadioButton rb_hotovost;
        private RadioButton rb_Karta;
        private RadioButton rb_Prevod;
        private Label lb_cislo_karty;
        private Label lb_platnost;
        private Label lb_vlastnik;
        private TextBox tb_cisloKarty;
        private DateTimePicker dt_platnost;
        private TextBox tb_vlastnik;
        private Label lb_cisloUctu;
        private Label lb_kodBanky;
        private TextBox tb_kodBanky;
        private TextBox tb_cisloUctu;
        private Button bt_vlozit;
        private Button bt_cancel;
    }
}