using System;

namespace choyxona
{
    class Program
    {
        static void Main(string[] args)
        {
            servis servis = new();
            minyu mn = new();
            qadam qadam = new();
            var taom = mn.Taomlar();
            var foydalan = mn.foyda();
            int cnt = qadam.Kirish();
            if (cnt == 1)
            {
                qadam.ZakazBerish(taom);
            }
            if (cnt == 2)
            {
                qadam.XodimTekshirish(foydalan);
                qadam.XodimXizmati(taom); 
            }
        }
    }
}
