using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDB_Mytne.Models
{
    public record Vozidlo(string spz, string ico, decimal hmotnost, string typVozidla, char emisniTrida, decimal kmSazba);
}
