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
using System.Windows.Threading;

namespace Had
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();




        public MainWindow()
        {
            InitializeComponent();
        }

        public void zacaljsemhrat()
        {

            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Tick += new EventHandler(hodinomaster);
            dispatcherTimer.Start();

        }
        int seKundy = 0;
        public void hodinomaster(object sender, EventArgs e )
        {
            seKundy++;
            casovac.Content = seKundy;
        }


        private void start_Click(object sender, RoutedEventArgs e)
        {
            zacaljsemhrat();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void UpdatePictureBoxGraphics(object sender, EventArgs e)
        {

        }

        private void RestarGame()
        {

        }

        private void EateFood()
        {

        }

        private void GameOver()
        {

        }
    }
    
}
