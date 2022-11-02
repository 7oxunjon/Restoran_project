using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oshxona
{
   public  class sevis
    {
        public taom taomkiritish()
        {
            taom taom = new taom();
            Console.WriteLine("taom Nomi");
            taom.Nomi = Console.ReadLine();
            Console.WriteLine("Taom narxi");
            taom.narxi = int.Parse(Console.ReadLine());
            Console.WriteLine("Taom miqdori");
            taom.miqdori = int.Parse(Console.ReadLine());
            return taom;
        }
        public void TaomlarRoyxati(List<taom> taomlar)
        {
            foreach (var taom in taomlar)
            {
                TaomniChopetish(taom);
            }
        }
        private void TaomniChopetish(taom taom)
        {
                Console.WriteLine($"taomlar Nomi\t{taom.Nomi}\nTaom narxi\t{taom.narxi}\nTaom miqdori\t{taom.miqdori}\n\n");

        }
        public taom taomUzgartirish(taom taom)
        {
            Console.WriteLine("taomlar ruyxati\n\n");
            TaomniChopetish(taom);
            Console.WriteLine("yangi ruyxatni kiriting\n\n");
            return taomkiritish();

        }
        public void qaytish()
        {
            Console.WriteLine("Bosh Sahifa---------- 1");
            Console.WriteLine("Yangilik kiritish Bo`limi---------- 2");
   
        }
        public void TaomUchirish(List<taom> taom)
        {
            sevis servis = new();
            string nom = Console.ReadLine();
            var i = taom.Single(p => p.Nomi == nom);
            taom.Remove(i);
            servis.TaomlarRoyxati(taom);

        }

    }
}
