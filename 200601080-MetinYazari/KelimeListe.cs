using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazari
{
    public class KelimeListe:BagList
    {

        public void KelimeEkle(Kelime kelime)
        {
            Node node = new Node();
            KelimeSikligi(kelime);
            node.Data = kelime;
            Push(node);
        }
        public Kelime KelimeCikar()
        {
            return (Kelime)Pop().Data;
        }
        private void KelimeSikligi(Kelime kelime)
        {
            Node node = Top;
            Kelime kelimeKontrol;
            while (node!=null)
            {
                kelimeKontrol = (Kelime)node.Data;
                if (kelimeKontrol.KelimeAd==kelime.KelimeAd)
                {
                    kelimeKontrol.KelimeSiklik++;
                    kelime.KelimeSiklik = kelimeKontrol.KelimeSiklik;
                }
                node = node.Next;
            }
        }

       
        public int ToplamKelimeSay()
        {
            Node tmp = Top;
            float toplamKelimeSayisi = 0;
            float Bolme;
            float KelimeSiklikAdet;
            Kelime kelime;
            while (tmp!=null)
            {
                kelime = (Kelime)tmp.Data;
                KelimeSiklikAdet = (float)kelime.KelimeSiklik;  // kelime sıklık int oldugundan 1/ sonucunu da int yapıyor bu yuzden float donusturulmeli
                Bolme = (1 / KelimeSiklikAdet);
                toplamKelimeSayisi = toplamKelimeSayisi + Bolme ; //okul kelimesi 4 kere kullanilmissa listede 4 okul kelimesi vardir
                tmp = tmp.Next;
            }                                                  
            return (int)toplamKelimeSayisi;// toplam farkli kelime sayisi
        }

    }
}
