using RDB_Mytne.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDB_Mytne
{
    public partial class CreditLeft : Form
    {
        private MSDatabaseService microsoftDb;
        private MongoDBService mongoDb;
        public CreditLeft()
        {
            InitializeComponent();
            microsoftDb = new();
            mongoDb = new();
            var spzList = microsoftDb.GetSpz();
            cb_spz.Items.AddRange(spzList.ToArray());
        }

        private void bt_calculate_Click(object sender, EventArgs e)
        {
            string spz = cb_spz.Text;
            double km = mongoDb.GetKm(spz);
            double kmRate = microsoftDb.GetKmRate(spz);
            double creditFromPayments = microsoftDb.GetCreditFromPayments(spz);

            double credit = creditFromPayments - (kmRate * km);

            tb_creaditLeft.Text = credit.ToString();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
