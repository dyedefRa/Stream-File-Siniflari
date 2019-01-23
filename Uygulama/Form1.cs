using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //bin tane personel olusturduk
            List<Personel> personeller = new List<Personel>();

            for (int i = 0; i < 1000; i++)
            {
                Personel temp = new Personel();
                temp.Id = i + 1;
                temp.Ad = FakeData.NameData.GetFirstName();
                temp.Soyad = FakeData.NameData.GetSurname();
                temp.FirmaAdi = FakeData.NetworkData.GetDomain();
                //temp.Cinsiyet = FakeData.BooleanData.GetBoolean();
                temp.Email = temp.Ad + "." + temp.Soyad + "@" + temp.FirmaAdi;
                temp.Ulke = FakeData.PlaceData.GetCountry();
                temp.DogumYili = FakeData.DateTimeData.GetDatetime(new DateTime(1990, 01, 01), new DateTime(2018, 12, 12));
                personeller.Add(temp);
            }

            //Her personel ıcın belırtılen yola dosya olusturcaz
            //ulkelere gore dosya olusacak ve o ulkelı kısının
            //bılgılerı txt dosyasıyla tutulacak..
            for (int i = 0; i < personeller.Count; i++)
            {
                DirectoryInfo ulkeKlasorBilgisi=null;
                //gezılen personele aıt olan ulke adında dosya yok ıse olustur
                if (!Directory.Exists(@"d:\Udemy\"+personeller[i].Ulke))
                {
                    ulkeKlasorBilgisi=Directory.CreateDirectory(@"d:\Udemy\" + personeller[i].Ulke);
                }
                else
                //var ise yınede dırectoryınfoya at dosyayı
                {
                    ulkeKlasorBilgisi=new DirectoryInfo(@"d:\Udemy\" + personeller[i].Ulke);
                }
                //txt dosyası olusturualım 
               FileStream fs= File.Create(ulkeKlasorBilgisi.FullName + "\\Personel" + personeller[i].Id+".txt");


                //ve içine tostring ile override ettıgımız personel classını atacagız.. 
                //fs ile yazacagız..

                // fs.Write(...  Byte dizisi istiyor!!!
                byte[] personelBilgi = new UTF8Encoding(true).GetBytes(personeller[i].ToString());
                fs.Write(personelBilgi, 0, personelBilgi.Length);
                fs.Close();

            }
        }
    }
}
