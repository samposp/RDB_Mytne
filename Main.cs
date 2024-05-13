using System.Diagnostics;
using System.Security;
using System.Windows.Forms;
using MongoDB.Driver;
using RDB_Mytne.Models;
using RDB_Mytne.Services;

namespace RDB_Mytne
{
    public partial class Mytne : Form
    {
        MSDatabaseService msDatabase;
        MongoDBService mongoDB;
        JsonSerializerService jsonService;
        public Mytne()
        {
            InitializeComponent();
            msDatabase = new();
            mongoDB = new();
            jsonService = new();
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            if (loadDataDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = loadDataDialog.FileName;
                    using (StreamReader reader = new(filePath))
                    {
                        var jsonObjects = jsonService.ReadFile(reader);

                        // vloz data do mongo db
                        mongoDB.InsertDocuments(jsonObjects);

                        var vozidla = jsonService.DeserializeVozidla(jsonObjects);
                        var firmy = jsonService.DeserializeFirmy(jsonObjects);

                        // odstran duplicity
                        vozidla = vozidla.GroupBy(x => x.spz).Select(grp => grp.Last()).ToList();
                        firmy = firmy.GroupBy(x => x.ico).Select(grp => grp.Last()).ToList();

                        // vloz do databaze
                        msDatabase.InsertFirmy(firmy);
                        msDatabase.InsertVozidla(vozidla);
                    }
                }
                catch (Exception exception)
                {
                    Console.Error.WriteLine(exception.ToString());
                }
            }
        }
        private void createVozidlo_Click(object sender, EventArgs e)
        {
            var vozidloForm = new CreateVozidlo();
            vozidloForm.ShowDialog();
        }

        private void createPlatba_Click(object sender, EventArgs e)
        {
            var platbaForm = new CreatePlatba();
            platbaForm.ShowDialog();
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreditLeft_Click(object sender, EventArgs e)
        {
            var creditForm = new CreditLeft();
            creditForm.ShowDialog();
        }

        private void createReport_Click(object sender, EventArgs e)
        {
            var reportForm = new Report();
            reportForm.ShowDialog();
        }
    }
}
