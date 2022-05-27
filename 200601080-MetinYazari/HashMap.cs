using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazari
{
    public class HashMap
    { /// <summary>
    /// Hash sifreleme islemi kelimenin harflerinin ascii degerinin toplami ve toplaminin  sifrelemeolcutu modunu alarak yapılmıstır
    /// </summary>
        public HashEntry[] hashEntries;
        private int SifrelemeOlcutu;
        public HashMap()
        {
            SifrelemeOlcutu = 10;
            hashEntries = new HashEntry[SifrelemeOlcutu];
            for (int i = 0; i < SifrelemeOlcutu; i++)
            {
                hashEntries[i] = new HashEntry();
            }
        }

        // kelimedeki her harfin ascii degerini bulur
        public byte[] StringDataToAscii(string str) 
        {
            byte[] bytes = Encoding.ASCII.GetBytes(str);
            return bytes;
        }
        //kelime harflerinin ascii degerlerinin toplamini key olarak aldim
        public int ByteAsciiKeyFinder(byte[] ascii)
        {
            int Toplam = 0;
            foreach (var item in ascii)
            {
                Toplam=Toplam+item;
            }
            return Toplam;
        }
        public int stringAsciiKey(string str)
        {
            return ByteAsciiKeyFinder(StringDataToAscii(str));
        }

        public void HashDataInsert(HashNode hashNode)
        {
            int HashMapKey=0;
            HashMapKey = hashNode.Key % SifrelemeOlcutu;
            for (int i = 0; i < hashEntries.Length; i++)
            {
                if (hashEntries[i].IsEmpty())
                {
                    hashEntries[i].HashEntryKey=HashMapKey;
                    hashEntries[i].HashNodeInsert(hashNode);
                    break;
                }
                if (HashMapKey==hashEntries[i].HashEntryKey)
                {
                    hashEntries[i].HashNodeInsert(hashNode);
                    break;
                }
            }
        }







        public void HashKelimeInsert(Kelime kelime)
        {
            HashNode hashNode = new HashNode();
            hashNode.Data = kelime;
            hashNode.Key = stringAsciiKey(kelime.KelimeAdiOrjinal);
            HashDataInsert(hashNode);
        }


        public void HashTableCreate(Node node)
        {
            Node tmp = node;
            while (tmp != null)
            {
                HashKelimeInsert((Kelime)tmp.Data);
                tmp = tmp.Next;
            }
        }


        public string hashTabloYaz(int anahtar)
        {
            anahtar = anahtar%SifrelemeOlcutu;
            string Mesaj = "Sifrelemesi " + anahtar.ToString() + " olan kelimeler:";
            for (int i = 0; i < SifrelemeOlcutu; i++)
            {
                if (hashEntries[i].HashEntryKey == anahtar)
                {
                    Mesaj = Mesaj + hashEntries[anahtar].HashNodeDondur();
                    return Mesaj;
                }
                
            }
            return Mesaj + " Bulunamadi";
            
        }

        /*public string ByteAsciitoString(byte[] bytes)
        {
            string str = Encoding.ASCII.GetString(bytes);
            return str;
        }*/
    }
}
