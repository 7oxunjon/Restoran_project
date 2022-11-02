using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choyxona
{
    public class minyu
    {
      public List<TAOM> Taomlar()
        {
            return new List<TAOM>()
            {
                new TAOM(){Nomi = "osh", narxi = 22000, protsiyasi = 12},
                new TAOM(){Nomi = "shurva", narxi = 21000, protsiyasi = 10},
                new TAOM(){Nomi = "lagmonn", narxi = 24000, protsiyasi = 9},
            };
        }



        public List<foydalanuvchi> foyda()
        {
            return new List<foydalanuvchi>()
            {
                new foydalanuvchi(){login = "salom", parol = "oshpaz"},
                new foydalanuvchi(){login = "salom", parol = "oshxona"}
            };
        }
    }
}
