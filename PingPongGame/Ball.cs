using System;
using System.Drawing;

namespace PingPongGame
{
    class Ball 
    {
        public Point coordinates;
        public int direction;
        public int speed;

        public Ball(Point startcoords)
        {
            this.coordinates = startcoords;
            direction = 45;
            speed = 0;
        }

        public void move()
        {
            this.coordinates = nextCoord();
        }

        public Point nextCoord()
        {
            switch (this.direction)
            {
                case 0:
                    return new Point(this.coordinates.X, this.coordinates.Y - 1 - speed);
                case 45:
                    return new Point(this.coordinates.X + 1 + speed, this.coordinates.Y - 1 - speed);
                case 90:
                    return new Point(this.coordinates.X + 1 + speed, this.coordinates.Y );
                case 135:
                    return new Point(this.coordinates.X + 1 + speed, this.coordinates.Y + 1 + speed);
                case 180:
                    return new Point(this.coordinates.X , this.coordinates.Y +1 + speed);
                case 225:
                    return new Point(this.coordinates.X - 1 - speed, this.coordinates.Y + 1 + speed);
                case 270:
                    return new Point(this.coordinates.X - 1 - speed, this.coordinates.Y);
                case 315:
                    return new Point(this.coordinates.X - 1 - speed, this.coordinates.Y -1 - speed);
                default:
                    return new Point(100, 100);
            }
            
        }
    }
}
