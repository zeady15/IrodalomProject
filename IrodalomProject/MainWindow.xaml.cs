using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Linq;
using System.IO;
using IrodalomProject.Models;
using Microsoft.Win32;

namespace IrodalomProject
{
    /// <summary>
    /// Felhasználói felület BAL panel kialakítva
    /// </summary>
    public partial class MainWindow : Window
    {
        private static List<Kerdes> kerdesek = new List<Kerdes>();
        private static int aktKerdesIndex = 0;
        public MainWindow()
        {
            InitializeComponent();
            KerdesBeolvas("txt.txt");
        }

        private void KerdesBeolvas(string filename)
        {
            kerdesek.Clear();
            try
            {
                StreamReader sr = new StreamReader(filename, Encoding.UTF8);
                while (sr.EndOfStream)
                {
                    string kerdesSzovege = sr.ReadLine();
                    string valaszA = sr.ReadLine();
                    string valaszB = sr.ReadLine();
                    string valaszC = sr.ReadLine();
                    string[] utolsoSor = sr.ReadLine().Split(' ');
                    string helyesValasz = utolsoSor[1].Trim();
                    kerdesek.Add(new Kerdes(kerdesSzovege, valaszA, valaszB, valaszC, helyesValasz));
                }
            }
            catch (Exception ex) 
            {
                throw;
            }
        }

        private void betoltes_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)*.txt";
            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    KerdesBeolvas(openFileDialog.FileName);
                    MessageBox.Show("Sikeres betöltés", "Információ", MessageBoxButton.OK, MessageBoxImage.Information);
                    if (kerdesek.Count > 0)
                    {
                        aktKerdesIndex = 0;
                        MutatKerdes(aktKerdesIndex);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hiba");
                }
            }
        }
        private void MutatKerdes()
        {
        }
        private void kilepes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kiertekeles_Click(object sender, RoutedEventArgs e)
        {

        }

        private void elozo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mentes_Click(object sender, RoutedEventArgs e)
        {

        }

        private void kovetkezo_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    

}