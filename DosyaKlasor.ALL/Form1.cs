using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyaKlasor.ALL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dersler dosyaMetodlarinaUlas = new Dersler();
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
          
            dosyaMetodlarinaUlas.DosyaOzellikleri("D:\\SAS");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //BURASI ONEMLI..
            //2.PARAMETRE
            dosyaMetodlarinaUlas.DosyaTasimaIslemi(@"D:\SAS\Tasinacak", @"D:\SAS\AltKlasorunAdıBuOlsun\Tasinacak");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            // C D E F GELIYOR
         var deger=   dosyaMetodlarinaUlas.LogicalDriverlariGetir();
        }

        //FILE OLAYI BURADAA q@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        //File Olayina geçtik

        FileSinifi fs;
        private void button4_Click(object sender, EventArgs e)
        {
            fs.DosyaOlusturma(@"D:\SAS\AltKlasorunAdıBuOlsun\Tasinacak\yeni.txt");

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fs.StreamWriterDataYazmaMetodu(@"D:\SAS\AltKlasorunAdıBuOlsun\Tasinacak\yeni.txt");
        }

        private void button6_Click(object sender, EventArgs e)
        {
          var value=  fs.StreamReaderDataOkunma(@"D:\SAS\AltKlasorunAdıBuOlsun\Tasinacak\yeni.txt");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fs.FileDosyaTasimaIslemi(@"D:\SAS\AltKlasorunAdıBuOlsun\Tasinacak\yeni.txt", @"D:\SAS\aha.txt");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fs.FileCopyOlayi(@"D:\SAS\aha.txt", @"D:\SAS\AltKlasorunAdıBuOlsun\slm.txt");
        }
    }
}
