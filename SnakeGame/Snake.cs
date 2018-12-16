using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace SnakeGame
{
    class Snake
    {
        private Rectangle[] snakeRec;
        private SolidBrush brush;
        private int x, y, width, height;

        public Rectangle[] SnakeRec
        {
            get { return snakeRec; }
        }
        public Snake() //constructor
        {
            snakeRec = new Rectangle[3];
            brush = new SolidBrush(Color.GreenYellow);
            x = 20;
            y = 0;
            width = 10;
            height = 10;

            for(int i=0; i<snakeRec.Length;i++)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x = 10;
            }
        }
        public void drawSnake(Graphics paper)  //Creating a method which will draw the Snake with perimiter Graphics
        {
            foreach(Rectangle rec in snakeRec)
                {
                paper.FillRectangle(brush, rec);
            }
        }

        public void DrawSnake()
        {
            for (int i=snakeRec.Length-1;i>0; i--)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }

        public void moveDown()
        {
            DrawSnake();
            snakeRec[0].Y += 10;
        }
        public void moveUp()
        {
            DrawSnake();
            snakeRec[0].Y -= 10;
        }
        public void moveRight()
        {
            DrawSnake();
            snakeRec[0].X += 10;
        }
        public void moveLeft()
        {
            DrawSnake();
            snakeRec[0].X -= 10;
        }

        public void growSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            snakeRec = rec.ToArray();
        }

    }
}
