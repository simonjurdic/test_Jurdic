using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
         List<Circle> Snake = new List<Circle>();
        private Circle food= new Circle();

        int maxWidth;
        int maxHeight;

        int score;
        int highScore;

        Random random = new Random();

        bool goLeft, goRight, goUp, goDown;

        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void StartGame(object sender, EventArgs e)
        {

        }

        private void GametimerEvent(object sender, EventArgs e)
        {

        }

        private void updatePictureBox(object sender, PaintEventArgs e)
        {

        }
        private void RestartGame()
        {

        }
        private void EatFood()
        {

        }
        private void GameOver()
        {

        }
    }
}
