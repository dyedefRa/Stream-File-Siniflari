using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaKlasor.ALL
{
    public class Dersler
    {
        #region DERS01
        public void DosyaOlustur(string yol)
        {
            Directory.CreateDirectory(yol);

        }


        public void DosyaYoksaOlustur(string yol)
        {
            if (!Directory.Exists(yol))
            {
                Directory.CreateDirectory("D:\\SAS");
            }
        }
        #endregion

        #region DERS02
        //Çalışan programın exe yolunu alır
        public string ProjeninExeYolunuAl()
        {
            return Directory.GetCurrentDirectory();
        }

        //Çalışan programın exe yoluna atama yapar
        public void ProjeyeExeYolAta(string yol)
        {
            Directory.SetCurrentDirectory(yol);
        }
        #endregion

        #region DERS03 - DirectoryInfo
        //Bu metod statik değil.
        public void DosyaOzellikleri(string yol)
        {
            DirectoryInfo dosya = new DirectoryInfo(yol);
            var dosyaOlusturulmaTarihi = dosya.CreationTime.ToString("dd.MM.yyyy HH:mm:ss");

            //Ust dosyasının Adını alalım
            var bulunduguDizininAdi = dosya.Parent.FullName;

            dosya.Refresh();
            var dosyaninTamYolu = dosya.FullName;
            var sonErisimTarihi = dosya.LastAccessTime.ToString("dd.MM.yyyy HH:mm:ss");
            //Alt klasorleri açabiliyoruz/Olusturabiliyoruz..
            dosya.CreateSubdirectory("AltKlasorunAdıBuOlsun2");

            //Veriğimiz yolun dosyalarını alalım
            DirectoryInfo[] dosyalarininListesi = dosya.GetDirectories();

            foreach (var altdosya in dosyalarininListesi)
            {
                //Gezebiliyoz
            }
        }
        #endregion

        #region DERS04 - Taşıma

        public void DosyaTasimaIslemi(string hangiKlasorTasicaksinYol,string nereyeTasinacakYol)
        {
            Directory.Move(hangiKlasorTasicaksinYol, nereyeTasinacakYol);
        }

        #endregion

        #region DERS05

        public void DosyaSilmeIslemleri(string yol)
        {
            Directory.Delete(yol);
        }


        #endregion

        #region DERS06 - LogicalDriver

        public  List<string> LogicalDriverlariGetir()
        {
            return Directory.GetLogicalDrives().ToList();
        }

        #endregion

       

    }
}
