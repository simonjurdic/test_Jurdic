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

namespace JurdicTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Soldier soldier1;
        Soldier soldier2;

        Random random = new Random();



        public MainWindow()
        {


            InitializeComponent();
            soldier1 = new Soldier("Petr");
            soldier2 = new Soldier("Karel");

            txtboxjedna.Text = soldier1.ToString();
            txtboxdva.Text = soldier2.ToString();


        }

        public void Zobraz(Soldier soldier1, TextBox textBox)
        {
            textBox.Text = soldier1.Name + " ";
            textBox.Text += "HP" + soldier1.MaxHp.ToString() + "\n";
            textBox.Text += "Shield" + soldier1.MaxShield.ToString() + "\n";
            textBox.Text += "Level" + soldier1.Level.ToString() + "\n";
        }

        private void Vojak2Utok2_Click(object sender, RoutedEventArgs e)
        {
            soldier2.GetHit(soldier1.Damage);
            Zobraz1.Text = soldier2.ToString();
        }

        private void Vojak1Utok_Click(object sender, RoutedEventArgs e)
        {
            soldier1.GetHit(soldier2.Damage);
            Zobraz2.Text = soldier1.ToString();
        }


        private void Vojak1Heal_Click(object sender, RoutedEventArgs e)
        {
            int randomHeal = random.Next(10, 15);
            soldier1.Heal(randomHeal);
            Zobraz1.Text = soldier1.ToString();
        }

        private void Vojak1Heal_Click2(object sender, RoutedEventArgs e)
        {
            int randomHeal = random.Next(10, 15);
            soldier2.Heal(randomHeal);
            Zobraz2.Text = soldier1.ToString();
        }


        private void LvlUpBtn_Click(object sender, RoutedEventArgs e)
        {
            soldier1.LevelUp();
            Zobraz1.Text = soldier2.ToString();
        }

        private void LvlUpBtn_Click2(object sender, RoutedEventArgs e)
        {
            soldier2.LevelUp();
            Zobraz2.Text = soldier2.ToString();
        }
    }

}
