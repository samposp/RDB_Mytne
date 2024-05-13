using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDB_Mytne.Models
{
    public record Platba(string spz, DateTime datetime, double castka, string? cisloKarty, string? cisloUctu);
    public record PlatebniKarta(string cislo, DateTime platnost, string vlastnik);
    public record BankovniUcet(string cislo, string kodBanky);

}
