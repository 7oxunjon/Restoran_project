using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choyxona
{
    public class servis
    {
       public TAOM TaomQushish()
        {
            TAOM taomlar = new();
            Console.WriteLine("Taom Nomini kiriting = ");
            taomlar.Nomi = Console.ReadLine();
            Console.WriteLine("Taom narxini kiriting = ");
            taomlar.narxi = int.Parse(Console.ReadLine());
            Console.WriteLine("Taom Portsiyasini kiriting = ");
            taomlar.protsiyasi = int.Parse(Console.ReadLine());
            return taomlar;
        }
        public void TaomUchirish(List<TAOM> taom)
        {
             servis servis = new();
             string nom = Console.ReadLine();
             var i = taom.Single (p => p.Nomi == nom);
             taom.Remove(i);
             servis.TaomRuyxati(taom);  
        }
        public void Narxuzgartirish(List<TAOM> taom)
        {
            Console.WriteLine("Taom Nomini kiriting");
            string nom = Console.ReadLine();
            Console.WriteLine("Yangi Summa kiriting = ");
            int cnt = int.Parse(Console.ReadLine());
            servis servis = new();
            taom.Where(p => p.Nomi == nom).Select(w => { w.narxi = cnt; return cnt;}).ToList();
            servis.TaomRuyxati(taom);
            
        }

        public void MiqdorUzgartirish(List<TAOM> taom)
        {
            Console.WriteLine("Taom Nomini kiritung = ");
            string nom = Console.ReadLine();
            Console.WriteLine("yangi portsiya kiriting  = ");
            int miq = int.Parse(Console.ReadLine());
            servis servis = new();
            taom.Where(p => p.Nomi == nom).Select(w => { w.protsiyasi = miq; return miq;}).ToList();
            servis.TaomRuyxati(taom);
        }

        public void TaomRuyxati(List<TAOM> taom)
        {
            foreach (var i in taom)
            {
                Console.WriteLine($"{taom.IndexOf(i)+1} Nomi = {i.Nomi}   Narxi = {i.narxi}   Portsiyasi = {i.protsiyasi}");
            }
        }

       
        
    }
}
