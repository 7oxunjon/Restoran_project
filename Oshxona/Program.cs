using System;
using System.Collections.Generic;
using System.Linq;
using Oshxona;

namespace Oshxona
{
    class Program
    {
        static void Main(string[] args)
        {
            qadamlar qadam = new();
            sevis servis = new();
            MocData moc = new();
            var taomlar = moc.Taomlar();
            var foydalanuvchilar = moc.foydalanuvchilar();
            int cnt=qadam.kirish();
            if (cnt == 1)
            {
                servis.TaomlarRoyxati(taomlar);
            }
            else if(cnt == 2)
            {

                qadam.HodimKirish(foydalanuvchilar);
                qadam.HodimXizmatlari(taomlar);
                
                
                
            }
           

        }
    }
}
