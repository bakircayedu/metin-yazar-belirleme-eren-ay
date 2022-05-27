using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace MetinYazari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHashDeneme.Text = "0";
        }
        Cumle Dosya = new Cumle(); 
        bool SeciliDosya = false;
        HeapKelimeTree kelimeTree;
        HashMap hashMap = new HashMap();

        public OpenFileDialog TxtDosyaSec()
        {
            
            OpenFileDialog file = new OpenFileDialog();
            // file.InitialDirectory = "C:\\"; //default path
            file.Filter = "Txt Dosyalari |*.txt";

            if (file.ShowDialog() == DialogResult.OK)
            {
                SeciliDosya = true;
                return file;
                
            }
            return null;
        }

        public string TxtFileOku(string filePath)
        {
            OpenFileDialog file= new OpenFileDialog();
            file.FileName = filePath;
            string Metin="";
            if (SeciliDosya)
            {
                var fileStream = file.OpenFile();
                using (StreamReader reader = new StreamReader(fileStream))
                {
                    Metin = reader.ReadToEnd();
                }
                return Metin;
            }
            MessageBox.Show("Dosya Sec");
            return "";
        }

        public string TxtFilePath(OpenFileDialog file) //  Dosya Sec
        {
            string txtPath = "";
            if (file != null)
            {
                txtPath = file.FileName;
            }
            return txtPath;
        }



        
        
        private void btnMetinYukle_Click(object sender, EventArgs e)
        {
            
            txtMetinPath.Text = TxtFilePath(TxtDosyaSec());//Secilen Dosya Yolu
        }

        private void btnStackOku_Click(object sender, EventArgs e)
        {
            string DosyaIcerik = TxtFileOku(txtMetinPath.Text);
            if (DosyaIcerik != "") 
            {
                Cumle cumleStack = new Cumle();
                cumleStack.CumleEkle(DosyaIcerik);
                int CumleSayisi = cumleStack.ToplamCumleSay();
                string CumleKelimeSayisi = cumleStack.CumleKelimeSayilari();
                int OrtalamaKelimeSayisi = cumleStack.ToplamOrtalamaKelimeSayilari();
                txtCumleSayi.Text = CumleSayisi.ToString();
                txtCumleKelimeSayi.Text =CumleKelimeSayisi;
                txtOrtKelimeSayi.Text=OrtalamaKelimeSayisi.ToString();
                Dosya = cumleStack;
            }
        }

        private void btnAgacAktar_Click(object sender, EventArgs e)
        {
            int ToplamKelimeSayisi = Dosya.kelimelerListesi.ToplamKelimeSay();
            HeapKelimeTree heapKelimeTree = new HeapKelimeTree(ToplamKelimeSayisi);
            Node kelimeTop = Dosya.kelimelerListesi.Top;
            
            heapKelimeTree.heapKelimeTreeCreateWithLink(kelimeTop);
            
            kelimeTree = heapKelimeTree;
           
        }

        private void btnSikKullanilanKelimeler_Click(object sender, EventArgs e)
        {
            
            kelimeTree.heapSort();
            Kelime kelime;
            string KelimeAd;
            int KullanimSayisi;
            lboxSikKullanilanKelimeler.Items.Add("Kelime Adi \t\t Kullanim sayisi");
            for (int i = 0; i < kelimeTree.currentNode; i++)
            {
                kelime = (Kelime)kelimeTree.HeapDizi[i].Data;
                KelimeAd = kelime.KelimeAd;
                KullanimSayisi = kelimeTree.HeapDizi[i].SiralamaOlcutu;
                lboxSikKullanilanKelimeler.Items.Add(KelimeAd + "\t\t\t" + KullanimSayisi.ToString());
            }
            
            

        }

        private void btnHashTabloOlustur_Click(object sender, EventArgs e)
        {
            HashMap hashMapyap = new HashMap();
            hashMapyap.HashTableCreate(Dosya.kelimelerListesi.Top);
            
            hashMap=hashMapyap;

        }

        private void btnHashDene_Click(object sender, EventArgs e)
        {

            int Anahtar = Int32.Parse(txtHashDeneme.Text);
            string yaz = hashMap.hashTabloYaz(Anahtar);
            yaz = hashMap.hashTabloYaz(Anahtar);

            MessageBox.Show(yaz);
        }
    }
}
