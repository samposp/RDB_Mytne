using RDB_Mytne.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDB_Mytne.Services;

namespace RDB_Mytne
{
    public partial class CreateVozidlo : Form
    {
        private MSDatabaseService Db;
        public CreateVozidlo()
        {
            InitializeComponent();
            Db = new();
            var icoList = Db.GetIco();
            cb_ico.Items.AddRange(icoList.ToArray());
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            var vozidlo = new Vozidlo(
                    tb_spz.Text,
                    cb_ico.Text,
                    num_hmotnost.Value,
                    tb_typVozidla.Text,
                    tb_emisniTrida.Text[0],
                    num_kmSazba.Value
                );
            Db.InsertVozidla(new List<Vozidlo>() { vozidlo });
            Close();

        }
    }
}
