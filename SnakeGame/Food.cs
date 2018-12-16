using System;
using System.Drawing;
namespace SnakeGame
{
    public class Food
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodRec;
        public Food (Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;
            brush = new SolidBrush(Color.Red);
            width = 10;
            height = 10;

            foodRec = new Rectangle(x, y, width, height);
        }

        public void foodLocation(Random randFood)
        {
            x = randFood.Next(0, 29) * 10;
            y = randFood.Next(0, 29) * 10;
        }
        public void drawFood(Graphics paper)
        {
            foodRec.X = x;
            foodRec.Y = y;
            paper.FillRectangle(brush, foodRec);
        }
   
    }
}
