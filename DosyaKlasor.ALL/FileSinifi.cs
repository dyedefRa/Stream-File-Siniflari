using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaKlasor.ALL
{
  public  class FileSinifi
    {
        #region f01-f03
        public void DosyaOlusturma(string yol)
        {
            //D:\SAS\AltKlasorunAdıBuOlsun\Tasinacak\yeni.txt
            FileStream fs = File.Create(yol);
            //fs ye attık . fs açık kalır yani bu olusturulan dosya açık.. içine yazabiliriz..
            //DOSYA BELLEKTE ACIKTI
            
            fs.Close();
        }

        public void StreamWriterDataYazmaMetodu(string yol)
        {
            StreamWriter sw = new StreamWriter(yol);
            sw.WriteLine("MERHABA");
            sw.Close();
        }

        public string StreamReaderDataOkunma(string yol)
        {
            StreamReader sr = new StreamReader(yol);
          return  sr.ReadLine();
        }
        #endregion


        #region f04
        public void FileDosyaTasimaIslemi(string kaynak,string hedef)
        {
            File.Move(kaynak, hedef);
        }
        #endregion


        #region f05 - CopyOlayı

        public void FileCopyOlayi(string kaynak,string hedef)
        {
            File.Copy(kaynak, hedef);
        }

        #endregion

        #region f06 - FileInfo **

        public FileInfoSinifiKullanmak(string yol)
        {
            FileInfo fi = new FileInfo(yol);
            var olusmaTarihi = fi.CreationTime.ToString("dd.MM.yyyy HH:SS");
            string tamYolBilgisi = fi.FullName;
           DirectoryInfo di= fi.Directory;
            FileInfo [] directoryInfoList = di.GetFiles();

           string dosyaUzantisi= fi.Extension;
            long byteUzunluk = fi.Length;
            string dosyaAdi = fi.Name;
            string dosyaninBulunguKlasorAdi=fi.DirectoryName;

        }

        #endregion
    }
}
