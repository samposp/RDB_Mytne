using MongoDB.Bson;

namespace RDB_Mytne
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //update SQL database with liquibase
            Console.WriteLine("Starting Liquibase");
            string strCmdText = "/C liquibase update";
            System.Diagnostics.Process.Start("CMD.exe", strCmdText);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Mytne());
            
        }
    }
}