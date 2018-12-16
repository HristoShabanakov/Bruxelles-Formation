using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SnakeGame
{
    public partial class Form1 : Form
    {
        Random randFood = new Random();
        Graphics paper;
        Snake snake = new Snake();//Calling the snake class
        Food food; //Calling the food class
        
        bool left = false;// creating 4 boolean variables,which will make the snake moving on the screen,when they are true;
        bool right = false;
        bool down = false;
        bool up = false;

        int score = 0; // creating the score
        public Form1()
        {
            InitializeComponent();
            food = new Food(randFood);// at the top you cannot fully call the food class,because of the Random variable
        }

        private void SnakeGame_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;// asign the paper
            snake.drawSnake(paper);// call method of drawn snake
            food.drawFood(paper);// drawing the food
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Down && up == false) //creating a few If statements to make sure in each direction snake is going to move
            {
                down = true;
                up = false;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                right = true;
                left = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                right = false;
                left = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //setting up the timer which will make the snake move
        {
            GameScoreLabel.Text = Convert.ToString(score);
            if (down) { snake.moveDown(); }
            if (up) { snake.moveUp(); }
            if (right) { snake.moveRight(); }
            if (left) { snake.moveLeft(); }

            for (int i = 0; i < snake.SnakeRec.Length; i++) //collision detection to know when the food was hit by the snake
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    food.foodLocation(randFood);// genarating random food
                    snake.growSnake(); //growing the snake
                    score += 10; //every time when the snake does collide with the food 10 points will be added to the score
                }

                collision();
                this.Invalidate();//tells the paint function that needs to draw whats in the form (Rectangle)
            }
        }
       public void collision()
        {
            for (int i = 1;i< snake.SnakeRec.Length; i++)
            {
            if(snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i])) //if the snake bites its tail - Game over
            {
                restart();
            }
            } 
            if(snake.SnakeRec[0].X<0||snake.SnakeRec[0].X>290) //if the snake hits left side the screen - Game over
            {
                restart();
            } 
            if(snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 290) //if the snake hits direction up the screen - Game over
            {
                restart();
            }
        }
    public void restart() //creating a Restart method for the snake to begin a new game
        {
            timer1.Enabled = false;// taking the timer from the collison method 
            GameScoreLabel.Text = "0";
            DialogResult dialogResult = MessageBox.Show("Start a New Game?", "Game Over", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                timer1.Enabled = true;
                down = false;
                up = false;
                right = true;
                left = false;
            }
            else if(dialogResult==DialogResult.No)
            {
                Close();
            }
                score = 0;
            snake = new Snake();
        }
        }
     } 
  

