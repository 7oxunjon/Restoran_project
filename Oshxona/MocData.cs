using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oshxona
{
    public class MocData
    {
        public List<taom> Taomlar()
        {
            return new List<taom>()
            {
                new taom(){Nomi = "Osh", narxi = 22000, miqdori = 12},
                new taom(){Nomi = "Shurva",narxi = 18000, miqdori = 10},
                new taom(){Nomi = "Lagman", narxi = 21000, miqdori = 9},
            };
        }
        public List<foydalanuvchi> foydalanuvchilar()
        {
            return new List<foydalanuvchi>()
            {
                new foydalanuvchi(){login ="salom", password = "oshpaz"},
                new foydalanuvchi(){login = "salom", password = "osh"}
            };
        }
    }
}
