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
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GametimerEvent(object sender, EventArgs e)
        {

        }

        private void updatePictureBox(object sender, PaintEventArgs e)
        {

        }
        private void RestartGame()
        {
            maxWidth = pictureBox1.Width / Settings.Width - 1;
            maxHeight = pictureBox1.Height / Settings.Height - 1;

            Snake.Clear();

            button1.Enabled = false;
            score = 0;
            label1.Text = "Score" + score;

            Circle head = new Circle { x = 10, y = 5 };
        }
        private void EatFood()
        {

        }
        private void GameOver()
        {

        }
    }
}
