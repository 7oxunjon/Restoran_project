using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oshxona
{
    public class qadamlar
    {
        public int kirish()
        {
            
            Console.WriteLine("\t\tAssalomu Alayum Restaranimizga Xush kelibsiz\n");
            Console.WriteLine("Mijoz---------- 1\nXodim---------- 2");
            return  int.Parse(Console.ReadLine());
            
        }
        public bool HodimKirish(List<foydalanuvchi> foydalanuvchi)
        {

            Console.Write("Assalomu Alaykum iltimos ma`lumod kiriting:\nLogin: ");
            string Login = Console.ReadLine();
            Console.Write("parol: ");
            string password = Console.ReadLine();
            return foydalanuvchi.Any(p => p.login == Login && p.password == password);
        }
        public int HodimXizmatlari(List<taom> taoms)
        {
            sevis back = new();
            Console.WriteLine("\nyangi Taom Qushish---------- 1");
            Console.WriteLine("Taom O`zgartirish---------- 2");
            Console.WriteLine("Taomni o`chirish---------- 3");
            int res= int.Parse(Console.ReadLine());
            if(res == 1)
            {
                sevis servis = new();
                Console.WriteLine("yangi Taom qushing\n");
                taoms.Add(servis.taomkiritish());
                servis.TaomlarRoyxati(taoms);
                
            }
           
            if (res == 2)
            {
                sevis servis = new();
                string nom;
                servis.TaomlarRoyxati(taoms);
                Console.WriteLine("\nqaysi taom o`zgartirmoqchisiz");
                nom = Console.ReadLine();
                bool s = taoms.Any(p => p.Nomi == nom);
                if (s)
                {
                    Console.WriteLine("Narxini O`zgartirish---------- 1");
                    Console.WriteLine("Miqdorini o1zgartirish----------2");
                    int i = int.Parse(Console.ReadLine());
                    if (i == 1)
                    {
                        Console.WriteLine("Summa Kiriting = ");
                        int sum = int.Parse(Console.ReadLine());
                        taoms.Where(w=>w.Nomi==nom).Select (p => { p.narxi = sum; return p;}).ToList();
                        servis.TaomlarRoyxati(taoms); 
                    }
                    if (i == 2)
                    {
                        Console.WriteLine("Miqdorini Kiriting = ");
                        int sum = int.Parse(Console.ReadLine());
                        taoms.Where(w => w.Nomi == nom).Select(p => { p.miqdori = sum; return p; }).ToList();
                        servis.TaomlarRoyxati(taoms);
                    }
                }
                else Console.WriteLine("taom topilmadi");
                
            }
            if (res == 3)
            {
                sevis servis = new();
                servis.TaomlarRoyxati(taoms);
                Console.WriteLine("\nQaysi Taom Uchirmoqchisiz? = ");
                servis.TaomUchirish(taoms);
                
                
            }     
            return res;
        }

      
    }
}
