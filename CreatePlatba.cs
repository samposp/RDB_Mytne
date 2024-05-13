using RDB_Mytne.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDB_Mytne.Models;

namespace RDB_Mytne
{
    public partial class CreatePlatba : Form
    {

        private MSDatabaseService Db;

        public CreatePlatba()
        {
            InitializeComponent();
            Db = new();
            VisibilityKarta(false);
            VisibilityPrevod(false);
            var spzList = Db.GetSpz();
            cb_spz.Items.AddRange(spzList.ToArray());
        }

        private void rb_hotovost_CheckedChanged(object sender, EventArgs e)
        {
            VisibilityKarta(false);
            VisibilityPrevod(false);
        }

        private void rb_Karta_CheckedChanged(object sender, EventArgs e)
        {
            VisibilityKarta(true);
            VisibilityPrevod(false);
        }

        private void rb_Prevod_CheckedChanged(object sender, EventArgs e)
        {
            VisibilityKarta(false);
            VisibilityPrevod(true);
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_vlozit_Click(object sender, EventArgs e)
        {
            var platebniKarta = rb_Karta.Checked
                ? new PlatebniKarta(tb_cisloKarty.Text, dt_platnost.Value, tb_vlastnik.Text)
                : null;
            var bankovniUcet = rb_Prevod.Checked
                ? new BankovniUcet(tb_cisloUctu.Text, tb_kodBanky.Text)
                : null;
            var platba = new Platba(
                    cb_spz.Text,
                    DateTime.Now,
                    Decimal.ToDouble(num_castka.Value),
                    rb_Karta.Checked ? tb_cisloKarty.Text : null,
                    rb_Prevod.Checked ? tb_cisloUctu.Text : null
                );
            Db.InsertPlatba(platba, platebniKarta, bankovniUcet);
            Close();
        }

        private void VisibilityKarta(bool visibility)
        {
            tb_cisloKarty.Visible = visibility;
            lb_cislo_karty.Visible = visibility;
            lb_platnost.Visible = visibility;
            dt_platnost.Visible = visibility;
            lb_vlastnik.Visible = visibility;
            tb_vlastnik.Visible = visibility;
        }
        private void VisibilityPrevod(bool visibility)
        {
            lb_cisloUctu.Visible = visibility;
            tb_cisloUctu.Visible = visibility;
            lb_kodBanky.Visible = visibility;
            tb_kodBanky.Visible = visibility;
        }
    }
}
