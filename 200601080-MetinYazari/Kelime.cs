using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazari
{
    //Kelime nesnesinin ozellikleri
    public class Kelime
    {
        public string KelimeAdiOrjinal { get; private set; }

        private string kelimem; //islenmis kelime

        public string KelimeAd
        {
            get { return kelimem; }
            set {
                KelimeAdiOrjinal = value; 
                kelimem = KelimeOrjinal(value);
            }
        }

        public int KelimeSiklik { get; set; } //kullanilan ayni kelime sayisi
        public int KelimeMetinSirasi { get;private set; }
        public int KelimeCumleSirasi { get;private set; }

        public string KelimeOrjinal(string kelime)//Kelimenin kucuk harfle en sade halini dondur
        {
            string KelimeOrj="";
            kelime=kelime.ToLower();
            for (int i = 0; i < kelime.Length; i++)
            {
                
                if (char.IsPunctuation(kelime[i]))
                {
                    i = kelime.Length;
                }
                else if (kelime[i] == '\r')
                {
                    i = kelime.Length;
                }
                else 
                {
                    KelimeOrj = KelimeOrj + kelime[i];
                }
            }
            return KelimeOrj;

        }
        public Kelime(string kelimeAdi,int kelimeMetinYeri,int kelimeCumleYeri)
        {
            KelimeAd = kelimeAdi;
            KelimeMetinSirasi = kelimeMetinYeri;
            KelimeCumleSirasi = kelimeCumleYeri;
            KelimeSiklik = 1;
        }
        public Kelime()
        {

        }

    }
}
