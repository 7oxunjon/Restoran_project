using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace choyxona
{
    public class qadam
    {
        public int Kirish()
        {
            nishon:
            Console.WriteLine("\t\tAssalomu Alaykum Choyxonamizga Xush kelibsiz!");
            Console.WriteLine("Mijoz----------1");
            Console.WriteLine("Xodim----------2");
            int cnt = int.Parse(Console.ReadLine());
            return cnt;
        }
        public bool XodimTekshirish(List<foydalanuvchi> foyda)
        {
            Console.Write("\t\tAssalomu Alaykum Xodim ma`lumod Tasdiqlang\nLogin: ");
            string Login = Console.ReadLine();
            Console.Write("Parol: ");
            string parol = Console.ReadLine();
            return foyda.Any(p => p.login == Login && p.parol == parol);

        }
        public int XodimXizmati(List<TAOM> taom)
        {
            nishon:
            servis servis = new();
            Console.WriteLine("Yangi Taom Qushish---------- 1");
            Console.WriteLine("Taom O`zgartirish---------- 2");
            Console.WriteLine("Taomni O`chirish---------- 3");
            int cnt = int.Parse(Console.ReadLine());
            if (cnt == 1)
            {

                Console.WriteLine("\t\tYangi Taom Qushish");
                taom.Add(servis.TaomQushish());
                servis.TaomRuyxati(taom);
                Console.WriteLine("bosh sahifa---------- 1");
                Console.WriteLine("dastur yakunlash----------2");
                int res1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (res1 == 1) goto nishon;
                if (res1 == 2) Console.WriteLine("XAYR");

            }
            if (cnt == 2)
            {
               
                Console.WriteLine("Taom Narxini o`zgartirish---------- 1");
                Console.WriteLine("taom portsiyasini O`zgartirish---------- 2");
                int res = int.Parse(Console.ReadLine());
                if (res == 1)
                {
                    servis.TaomRuyxati(taom);
                    servis.Narxuzgartirish(taom);
                    Console.WriteLine("bosh sahifa---------- 1");
                    Console.WriteLine("dastur yakunlash----------2");
                    int res1 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (res1 == 1) goto nishon;
                    if (res1 == 2) Console.WriteLine("XAYR");
                }
                if (res == 2)
                {
                    servis.TaomRuyxati(taom);
                    servis.MiqdorUzgartirish(taom);
                    Console.WriteLine("bosh sahifa---------- 1");
                    Console.WriteLine("dastur yakunlash----------2");
                    int res1 = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    if (res1 == 1) goto nishon;
                    if (res1 == 2) Console.WriteLine("XAYR");
                }
            }
            if (cnt == 3)
            {
                servis.TaomRuyxati(taom);
                Console.WriteLine("qaysi Taom uchirmoqchisiz = ");
                servis.TaomUchirish(taom);
                Console.WriteLine("bosh sahifa---------- 1");
                Console.WriteLine("dastur yakunlash----------2");
                int res1 = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (res1 == 1) goto nishon;
                if (res1 == 2) Console.WriteLine("XAYR");
            }
            return cnt;
            

        }
        public void ZakazBerish(List<TAOM> taom)
        {
            servis servis = new();
            servis.TaomRuyxati(taom);
            Console.WriteLine("Qaysi Taom zakaz bermoqchisiz");
            string nom = Console.ReadLine();
            Console.WriteLine("nechi portsiya zakaz berasiz");
            int son = int.Parse(Console.ReadLine());
            taom.Where(p => p.Nomi == nom).Select(w => w.protsiyasi=w.protsiyasi-son).ToList();
            Console.WriteLine($"siz {nom} taomidan {son} portsiya zakaz qildingiz");
            servis.TaomRuyxati(taom);
            
        }
    }
}
