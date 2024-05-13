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
    public partial class Report : Form
    {
        private MSDatabaseService microsoftDb;
        private MongoDBService mongoDb;
        public Report()
        {
            InitializeComponent();
            microsoftDb = new();
            mongoDb = new();
            var spzList = microsoftDb.GetSpz();
            cb_spz.Items.AddRange(spzList.ToArray());
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_createReport_Click(object sender, EventArgs e)
        {
            DateTime from = dt_od.Value;
            DateTime to = dt_do.Value;
            string spz = cb_spz.Text;
            string report = $"Report vozidla s SPZ: {spz} {Environment.NewLine}" +
                $"od: {from.ToShortDateString()} {Environment.NewLine}" +
                $"do: {to.ToShortDateString()}{Environment.NewLine}{Environment.NewLine}";

            int distance = mongoDb.GetReportKm(spz, from, to);
            var vozidlo = microsoftDb.GetVozidlo(spz);
            var firma = microsoftDb.GetFirma(vozidlo?.ico);

            report += $"Celková vzálenost: {distance} Km{Environment.NewLine}"
                        + $"Sazba: {vozidlo?.kmSazba.ToString("#,0")} Kč/Km{Environment.NewLine}"
                        + $"Celková cena: {(vozidlo?.kmSazba * distance)?.ToString("#,0")} Kč{Environment.NewLine}{Environment.NewLine}";

            report += $"Info o vozidle:{Environment.NewLine}" +
                $"Vlastník: {firma.nazev} ({firma.ico}){Environment.NewLine}" +
                $"Hmotnost: {vozidlo.hmotnost.ToString("#")}{Environment.NewLine}" +
                $"Emisní třída: {vozidlo.emisniTrida}{Environment.NewLine}" +
                $"Typ vozidla: {vozidlo.typVozidla}{Environment.NewLine}";

            tb_report.Text = report;
        }

        private void bt_close_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
