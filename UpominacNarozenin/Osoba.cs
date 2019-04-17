using System;

namespace UpominacNarozenin
{
    public class Osoba
    {
        public string Jmeno { get; set; }
        public DateTime Narozeniny { get; set; }
        public int Vek
        {
            get
            {
                DateTime dnes = DateTime.Today;
                Console.WriteLine(dnes);
                int vek = dnes.Year - Narozeniny.Year;
                Console.WriteLine(vek);
                if (dnes < Narozeniny.AddYears(vek))
                    vek--;
                Console.WriteLine(vek);
                return vek;
            }
        }

        public int ZbyvaDni
        {
            get
            {
                DateTime dnes = DateTime.Today;
                Console.WriteLine(dnes);
                DateTime dalsiNarozeniny = Narozeniny.AddYears(Vek + 1);
                Console.WriteLine(dalsiNarozeniny);
                TimeSpan rozdil = dalsiNarozeniny - DateTime.Today;
                Console.WriteLine(rozdil);

                return Convert.ToInt32(rozdil.TotalDays);
            }
        }

        /// <param name="jmeno">Jméno</param>
        /// <param name="narozeniny">Datum narození</param>
        public Osoba(string jmeno, DateTime narozeniny)
        {
            this.Jmeno = jmeno;
            this.Narozeniny = narozeniny;
        }

        /// <returns>Textová reprezentace osoby</returns>
        public override string ToString()
        {
            return Jmeno;
        }
    }
}
