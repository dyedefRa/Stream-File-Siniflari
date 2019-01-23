using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama
{
  public  class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string FirmaAdi { get; set; }
        public string Email { get; set; }
        public DateTime DogumYili { get; set; }
        public string Cinsiyet { get; set; }
        public string Ulke { get; set; }

        public override string ToString()
        {
            return $"İsim :{this.Ad}  Soyisim :{this.Soyad}  Firma Adı :{this.FirmaAdi}  E-mail :{this.Email}  Doğum Yılı :{this.DogumYili.ToString("dd:MM:yyyy")}  Cinsiyet :{this.Cinsiyet}  Ülke :{this.Ulke} ";
        }
    }
}
