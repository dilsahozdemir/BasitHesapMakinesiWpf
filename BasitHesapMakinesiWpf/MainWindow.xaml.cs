using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BasitHesapMakinesiWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double birinciSayi;
        private double ikinciSayi;
        private string islem;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void SayilarButonu_Click(object sender, RoutedEventArgs e)
        {
            Button tiklananButon = sender as Button;
            TextBoxEkran.Text += tiklananButon.Content.ToString(); 
        }
        private void IslemButonu_Click(object sender, RoutedEventArgs e)
        {
            Button tiklananButon = sender as Button;
            birinciSayi = Convert.ToDouble(TextBoxEkran.Text); 
            TextBoxEkran.Clear(); 
            islem = tiklananButon.Content.ToString(); 
        }

        
        private void SonucButonu_Click(object sender, RoutedEventArgs e)
        {
            ikinciSayi = Convert.ToDouble(TextBoxEkran.Text); 
            double sonuc = 0;

            switch (islem)
            {
                case "+":
                    sonuc = birinciSayi + ikinciSayi;
                    break;
                case "-":
                    sonuc = birinciSayi - ikinciSayi;
                    break;
                case "*":
                    sonuc = birinciSayi * ikinciSayi;
                    break;
                case "/":
                    if (ikinciSayi != 0)
                    {
                        sonuc = birinciSayi / ikinciSayi;
                    }
                    else
                    {
                        MessageBox.Show("Hata: Sıfıra bölme yapılamaz.");
                        return;
                    }
                    break;
            }

            TextBoxEkran.Text = sonuc.ToString(); 
        }

        private void TemizleButonu_Click(object sender, RoutedEventArgs e)
        {
            TextBoxEkran.Clear();
            birinciSayi = 0;
            ikinciSayi = 0;
            islem = string.Empty;
        }
    }
}
