using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintBallGame
{
    class PaintballGun
    {
        public const int MAGAZINE_SIZE = 16;
        private int balls = 0;
        private int ballsLoaded = 0;
        public int BallsLoaded
        {
            get { return ballsLoaded; }
            set { ballsLoaded = value; } //value is readonly that contains the value being set.
        }

        //You can make your automatic property read-only by making its setter private
        // public int BallsLoaded { get; private set; }
        public bool IsEmpty() { return BallsLoaded == 0; }
        //public int GetBalls() { return balls; }
        //public void SetBalls(int numberOfBalls)
        //{
        //    if (numberOfBalls > 0) balls = numberOfBalls;
        //    Reload();
        //}
        public int Balls
        {
            get { return balls; }
            set
            {
                if (value > 0) balls = value;
                Reload();
            }
              
        }
        public void Reload()
        {
            if (balls > MAGAZINE_SIZE) ballsLoaded = MAGAZINE_SIZE;
            else ballsLoaded = balls;
        }
        public bool Shoot()
        {
            if (ballsLoaded == 0) return false;
            ballsLoaded--;
            balls--;
            return true;
        }
    }
}
