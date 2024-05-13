using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using RDB_Mytne.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDB_Mytne.Services
{
    public class MSDatabaseService
    {
        private SqlConnection connection;
        public MSDatabaseService()
        {
            connection = new SqlConnection(
               "Data Source=SAM-PC;" +
               "Integrated Security = true;"+
               "database=rdb-mytne; " +
               "connection timeout=30");
        }

        public void InsertVozidla(List<Vozidlo> vozidla)
        {
            // vytvor text SQL dotazu
            var commandText =  new StringBuilder("INSERT INTO Vozidlo (spz, firma_ico, hmotnost, typ_vozidla, emisni_trida, km_sazba) VALUES ");
            for(int i = 0; i < vozidla.Count(); i++)
            {
                commandText.Append($"(@spz{i}, @firma_ico{i}, @hmotnost{i}, @typ_vozidla{i}, @emisni_trida{i}, @km_sazba{i}),");
            }
            commandText.Remove(commandText.Length - 1, 1); // odstran carku na konci

            SqlCommand command = new SqlCommand(commandText.ToString(), connection);

            // vloz hodnoty do dotazu - ochrana proti SQL injection
            for (int i = 0; i < vozidla.Count(); i++)
            {
                Vozidlo vozidlo = vozidla[i];
                command.Parameters.AddWithValue($"@spz{i}", vozidlo.spz);
                command.Parameters.AddWithValue($"@firma_ico{i}", vozidlo.ico);
                command.Parameters.AddWithValue($"@hmotnost{i}", vozidlo.hmotnost);
                command.Parameters.AddWithValue($"@typ_vozidla{i}", vozidlo.typVozidla);
                command.Parameters.AddWithValue($"@emisni_trida{i}", vozidlo.emisniTrida);
                command.Parameters.AddWithValue($"@km_sazba{i}", vozidlo.kmSazba);
            }

            // odesli dotaz
            SendCommand(command);
        }

        public void InsertFirmy(List<Firma> firmy)
        {
            // vytvor text SQL dotazu
            var commandText = new StringBuilder("INSERT INTO Firma (nazev, ico, adresa) VALUES ");
            for (int i = 0; i < firmy.Count(); i++)
            {
                commandText.Append($"(@nazev{i}, @ico{i}, @adresa{i}),");
            }
            commandText.Remove(commandText.Length - 1, 1); // odstran carku na konci

            SqlCommand command = new SqlCommand(commandText.ToString(), connection);

            // vloz hodnoty do dotazu - ochrana proti SQL injection
            for (int i = 0; i < firmy.Count(); i++)
            {
                Firma firma = firmy[i];
                command.Parameters.AddWithValue($"@nazev{i}", firma.nazev);
                command.Parameters.AddWithValue($"@ico{i}", firma.ico);
                command.Parameters.AddWithValue($"@adresa{i}", firma.adresa);
            }
            // odesli dotaz
            SendCommand(command);
        }
        
        public List<string> GetIco()
        {
            // Create SQL command
            SqlCommand command = new SqlCommand("SELECT ico From Firma", connection);

            List<string> ico = new();
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ico.Add(reader[0].ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return ico;
        }
        public List<string> GetSpz()
        {
            // Create SQL command
            SqlCommand command = new SqlCommand("SELECT spz From Vozidlo", connection);

            List<string> spz = new();
            try
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        spz.Add(reader[0].ToString());
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
            return spz;
        }
        public double GetKmRate(string spz)
        {
            SqlCommand command = new SqlCommand("SELECT km_sazba From Vozidlo WHERE spz = @spz", connection);
            command.Parameters.AddWithValue("@spz", spz);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                return reader.Read() && reader[0] is not null ? Decimal.ToDouble(reader.GetDecimal(0)) : 0;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                return 0;
            }
            finally
            {
                connection.Close();
            }
            
        }
        public double GetCreditFromPayments(string spz)
        {
            SqlCommand command = new SqlCommand("SELECT SUM(castka) From Platba WHERE spz = @spz", connection);
            command.Parameters.AddWithValue("@spz", spz);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.HasRows ? Decimal.ToDouble(reader.GetDecimal(0)): 0;
                }
                return 0;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                return 0;
            }
            finally
            {
                connection.Close();
            }
        }
        public void InsertPlatba(Platba platba, PlatebniKarta? karta, BankovniUcet? bankovniUcet)
        {
            SqlCommand command;
            if (karta is not null)
            {
                InsertPlatebniKarta(karta);
                string commandText = "INSERT INTO Platba (spz, datum, castka, cislo_karty)" +
                    "VALUES (@spz, @datum, @castka, @cislo_karty)";
                command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@cislo_karty", platba.cisloKarty);
            }
            else if (bankovniUcet is not null)
            {
                InsertBankovniUcet(bankovniUcet);
                string commandText = "INSERT INTO Platba (spz, datum, castka, cislo_uctu)" +
                      "VALUES (@spz, @datum, @castka, @cislo_uctu)";
                command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@cislo_uctu", platba.cisloUctu);
            }
            else
            {
                string commandText = "INSERT INTO Platba (spz, datum, castka)" +
                        "VALUES (@spz, @datum, @castka)";
                command = new SqlCommand(commandText, connection);
            }
            command.Parameters.AddWithValue("@spz", platba.spz);
            command.Parameters.AddWithValue("@datum", platba.datetime.ToString());
            command.Parameters.AddWithValue("@castka", platba.castka);

            SendCommand(command);
        }
        private void InsertPlatebniKarta(PlatebniKarta karta)
        {
            string commandText = "INSERT INTO Platebni_karta (cislo, platnost, vlastnik)" +
                "VALUES (@cislo, @platnost, @vlastnik)";
            SqlCommand command = new SqlCommand(commandText, connection);
            command.Parameters.AddWithValue("@cislo", karta.cislo);
            command.Parameters.AddWithValue("@platnost", karta.platnost.ToString());
            command.Parameters.AddWithValue("@vlastnik", karta.vlastnik);

            SendCommand(command);
        }
        private void InsertBankovniUcet(BankovniUcet ucet)
        {
            string commandText = "INSERT INTO Bankovni_ucet (cislo, kod_banky)" +
                "VALUES (@cislo, @kod_banky)";
            SqlCommand command = new SqlCommand(commandText, connection);
            command.Parameters.AddWithValue("@cislo", ucet.cislo);
            command.Parameters.AddWithValue("@kod_banky", ucet.kodBanky);

            SendCommand(command);
        }
        private void SendCommand(SqlCommand command)
        {
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
        public Vozidlo? GetVozidlo(string spz)
        {
            SqlCommand command = new SqlCommand("SELECT firma_ico, hmotnost, typ_vozidla, emisni_trida, km_sazba From Vozidlo WHERE spz = @spz", connection);
            command.Parameters.AddWithValue("@spz", spz);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Vozidlo(
                            spz,
                            reader.GetString(0),
                            (decimal)reader.GetFloat(1),
                            reader.GetString(2),
                            reader.GetString(3)[0],
                            reader.GetDecimal(4)
                        );
                }
                return null;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
        public Firma? GetFirma(string ico)
        {
            SqlCommand command = new SqlCommand("SELECT nazev, adresa From Firma WHERE ico = @ico", connection);
            command.Parameters.AddWithValue("@ico", ico);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return new Firma(
                            reader.GetString(0),
                            ico,
                            reader.GetString(1)
                        );
                }
                return null;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
