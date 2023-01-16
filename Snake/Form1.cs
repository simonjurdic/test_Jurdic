using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
            if (e.KeyCode == Keys.Left && Settings.directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings.directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void GametimerEvent(object sender, EventArgs e)
        {
            if(goLeft)
            {
                Settings.directions = "left";
            }
            if(goRight)
            {
                Settings.directions = "right";
            }
            if(goDown)
            {
                Settings.directions = "down";
            }
            if(goUp)
            {
                Settings.directions = "up";
            }
            for(int i = Snake.Count-1;i>=0; i--)
            {
                if(i==0)
                {
                    switch(Settings.directions)
                    {
                        case "left":
                            Snake[i].x--;
                            break;
                        case "right":
                            Snake[i].x++;
                            break;
                        case "down":
                            Snake[i].y++;
                            break;
                        case "up":
                            Snake[i].y--;
                            break;
                    }

                    if(Snake[i].x<0)
                    {
                        Snake[i].x = maxWidth;
                    }
                    if (Snake[i].x > maxWidth)
                    {
                        Snake[i].x = 0;
                    }
                    if (Snake[i].y < 0)
                    {
                        Snake[i].y = maxHeight;
                    }
                    if (Snake[i].y > maxHeight)
                    {
                        Snake[i].y = 0;
                    }

                    if (Snake[i].x == food.x && Snake[i].y==food.y)
                    {
                        EatFood();
                        
                    }
                     
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].x == Snake[j].x&&Snake[i].y == Snake[j].y)
                        {
                            GameOver();

                        }
                    }


                    
                }
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }

            pictureBox1.Invalidate();
        }

        private void updatePictureBox(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColor;
            for(int i =0; i < Snake.Count; i++)
            {
                if(i ==0)
                {
                    snakeColor = Brushes.Black;
                }
                else
                {
                    snakeColor = Brushes.DarkGreen;
                }

                canvas.FillEllipse(snakeColor, new Rectangle

                    (Snake[i].x * Settings.Width,
                     Snake[i].y * Settings.Height,
                     Settings.Width, Settings.Height));    
            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle

                   (food.x * Settings.Width,
                    food.y * Settings.Height,
                    Settings.Width, Settings.Height));

        }
        private void RestartGame()
        {
            maxWidth = pictureBox1.Width / Settings.Width - 1;
            maxHeight = pictureBox1.Height / Settings.Height - 1;

            Snake.Clear();

            button1.Enabled = false;
            button1.Enabled = false;
            score = 0;
            label1.Text = "Score: " + score;

            Circle head = new Circle { x = 10, y = 5 };
            Snake.Add(head); // adding the head part of the snake to the list

            for (int i = 0; i < 10; i++)
            {
                Circle body = new Circle();
                Snake.Add(body);
            }
            food = new Circle { x= random.Next(2, maxWidth), y = random.Next(2, maxHeight) };

            timer1.Start();

        }
        private void EatFood()
        {
            score += 1;

            label1.Text = "Score" + score;

            Circle body = new Circle
            {
                x = Snake[Snake.Count - 1].x,
                y = Snake[Snake.Count - 1].y
            };

            Snake.Add(body);

            food = new Circle { x = random.Next(2, maxWidth), y = random.Next(2, maxHeight) };


        }
        private void GameOver()
        {
            timer1.Stop();
            button1.Enabled = true;

            if(score>highScore)
            {
                highScore = score;
                label2.Text = "high Score:"+ Environment.NewLine + highScore;
                label2.ForeColor = Color.Maroon;
                label2.TextAlign=ContentAlignment.MiddleCenter;
            }
        }
    }
}
