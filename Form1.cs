using System.Diagnostics;
using System.Security;
using System.Windows.Forms;
using RDB_Mytne.Services;

namespace RDB_Mytne
{
    public partial class Mytne : Form
    {
        MSDatabaseService msDatabase;
        MongoDBService mongoDB;
        public Mytne()
        {
            InitializeComponent();
            msDatabase = new();
            mongoDB = new();
        }

        private void loadDataBtn_Click(object sender, EventArgs e)
        {
            if (loadDataDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = loadDataDialog.FileName;
                    using (Stream str = loadDataDialog.OpenFile())
                    {

                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.ToString());
                }
            }
        }

        private void sendSql_Click(object sender, EventArgs e)
        {
            string command = sqlQuery.Text;
            string response = msDatabase.sendSQLCommand(command);
            sqlResponse.Text = response;
        }
    }
}
