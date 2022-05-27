using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazari
{
    //metin cumlelere bolunerek stack list ile tutuldu 
    public class Cumle : BagList
    {
        //Metindeki Kelimeler yigit ile tutulmaktadir Heaptree ye bu listeden aktarim saglanacak
        public KelimeListe kelimelerListesi { get;private set; }
        private void CumleNodePush(string cumle)
        {
            Node node = new Node();
            node.Data = cumle;
            Push(node);
        }

        public string CumlePop()
        {
            Node node = Pop();
            if (node != null)
            {
                return (string)node.Data;
            }
            return null;
        }
        private string[] CumleAyir(string kaynakTxt)
        {
            return kaynakTxt.Split('\n');
        }
        public void CumleEkle(string cumleler)
        {
            string[] Cumleler = CumleAyir(cumleler);
            foreach (var cumle in Cumleler)
            {
                CumleNodePush(cumle);
            }
        }
        public string CumleBak() //En son cumleyi dondurur
        {
            Node node = View();
            if (node != null)
            {
                return (string)node.Data;
            }
            return null;
        }

        public int ToplamCumleSay()
        {
            int Toplam = 0;
            Node node = View();
            if (node==null)
            {
                return Toplam;
            }
            else
            {
                Toplam += 1;
                while (node.Next!=null)
                {
                    node = node.Next;
                    Toplam +=1;
                }
            }
            return Toplam;
        }


        public string[] KelimeleriAyir(string Cumle) 
        {
            return Cumle.Split(" "); 
        }

        public string[] CumleKelimeleriBul(Node Cumle)
        {
            string[] Kelimeler = KelimeleriAyir((string)Cumle.Data);
            return Kelimeler;
        }
        
        public int CumleKelimeSayisi(string[] kelimeler)
        {
            int ToplamKelimeSayi=0;
            foreach (var kelime in kelimeler)
            {
                ToplamKelimeSayi++;
            }
            return ToplamKelimeSayi;
        }

        public int ToplamOrtalamaKelimeSayilari()
        {
            int ToplamKelime=0;
            Node node = View();
            while (node!=null)
            {
                ToplamKelime+=CumleKelimeSayisi(CumleKelimeleriBul(node));
                node = node.Next;
            }
            ToplamKelime = ToplamKelime / ToplamCumleSay();
            KelimeListeEkle();
            return ToplamKelime;
        }


        public string CumleKelimeSayilari()
        {
            return CumleKelimeSayilari(Top);
        }
        public string CumleKelimeSayilari(Node node)
        {
            
            int KelimeSayilari=0;
            string KelimeSayisi="";
            KelimeSayilari = CumleKelimeSayisi(CumleKelimeleriBul(node));
            KelimeSayisi = KelimeSayilari.ToString();
            if (node.Next!=null)
            {
                return CumleKelimeSayilari(node.Next) + "," + KelimeSayisi ;
            }

            return KelimeSayisi;
        }


        public void KelimeListeEkle()
        {
            Node tmp=Top;
            int cumleYeri=0;
            int metinYeri=0;
            string[] Kelimeler;
            while (tmp!=null)
            {
                metinYeri += 1;//metindeki cumle sirasi
                cumleYeri = 0;//cumledeki kelime sirasi
                Kelimeler = CumleKelimeleriBul(tmp);
                foreach (var item in Kelimeler)
                {
                    cumleYeri += 1;
                    Kelime kelime = new Kelime(item, metinYeri, cumleYeri);
                    kelimelerListesi.KelimeEkle(kelime);
                }
                tmp=tmp.Next;
            }
        }

        

        public Cumle()
        {
            kelimelerListesi=new KelimeListe();
        }

        


        

    }
}
