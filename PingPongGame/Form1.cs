using System;
using System.Drawing;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class pingpongframe : Form
    {
        
        static int WIDTHGAME=800;
        static int HEIGHTGAME=400;
        static int MAXBALLY = 360;
        static int MINBALLY = 0;
        static int BARMAXY = 270;
        static int PLAYERBARXPOSITION = 726;
        static int AIBARXPOSITION = 85;

        Timer t;
        Ball ball;
        Boolean checkedRight = false;
        Boolean checkedLeft = false;
        static int playerspeed;
        Random rnd = new Random();
        Boolean ballIsMoving = false;
        int playerScore = 0;
        int aiScore = 0;
        Boolean isGameStarted = false;
        int aiSpeed;

        public pingpongframe()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            aiscoreLabel.Text = aiScore.ToString();
            playerscoreLabel.Text = playerScore.ToString();
            ball = new Ball(new Point(WIDTHGAME/2, rnd.Next(MINBALLY,MAXBALLY)));
            ball.speed = 5;
        }

        public void startBall()
        {
            checkedLeft = false;
            checkedRight = false;
            t = new Timer();
            t.Interval = 1;
            ballIsMoving = true;
            t.Tick += new EventHandler(moveBall);
            t.Start();
        }

        public void moveBall(object sender, EventArgs e) {

             if (ball.coordinates.X <= AIBARXPOSITION && !checkedLeft) {
                checkedRight = false;
                checkedLeft = true;
                if (isBallTouchBar(aiBar))
                {
                    bounce();
                }
            } else if (ball.coordinates.X <= 0) {
                stopBall();
                ball.coordinates = new Point(WIDTHGAME / 2, rnd.Next(MINBALLY, MAXBALLY));
                ballPict.Location = ball.coordinates;
                playerScore++;
                playerscoreLabel.Text = playerScore.ToString();
                aiBar.Location = new Point(AIBARXPOSITION, HEIGHTGAME / 2);

            } else if (ball.coordinates.X >= PLAYERBARXPOSITION && !checkedRight) {
                checkedRight = true;
                checkedLeft = false;

                if (isBallTouchBar(playerBar))
                {
                    bounce();
                }
            } else if (ball.coordinates.X > WIDTHGAME)
            {
                stopBall();
                ball.coordinates = new Point(WIDTHGAME / 2, rnd.Next(MINBALLY, MAXBALLY));
                ballPict.Location = ball.coordinates;
                aiScore++;
                aiscoreLabel.Text = aiScore.ToString();
                aiBar.Location = new Point(AIBARXPOSITION, HEIGHTGAME / 2);

            } else if(ball.coordinates.Y <= MINBALLY || ball.coordinates.Y >= MAXBALLY) {
                if (!(ball.coordinates.X > PLAYERBARXPOSITION) && !(ball.coordinates.X < AIBARXPOSITION))
                {
                    bounce();
                } 
            }
            
            ball.move();
            ballPict.Location = ball.coordinates;
            aiBar.Location = new Point( aiBar.Location.X,Math.Min(BARMAXY, aiBar.Location.Y +  aiMoveY()));
            //playerBar.Location = new Point(playerBar.Location.X,Math.Min(BARMAXY, ballPict.Location.Y));
        }

        public int aiMoveY()
        {
            if (ballPict.Location.Y > aiBar.Location.Y)
            {
                return (ballPict.Location.Y - aiBar.Location.Y) - (ballPict.Location.Y - aiBar.Location.Y - aiSpeed);
            } else
            {
                return ((ballPict.Location.Y - aiBar.Location.Y) - (ballPict.Location.Y - aiBar.Location.Y + aiSpeed));
            }
        }

        public void stopBall()
        {
            ballIsMoving = false;
            t.Stop();
        }

        public  Boolean isBallTouchBar(PictureBox bar)
        {
            return (ballPict.Left <= bar.Right && bar.Left <= ballPict.Right &&
            ballPict.Top <= bar.Bottom && bar.Top <= ballPict.Bottom);
        }

        public void bounce()
        {
            ball.direction += 90;
            
            if (ball.direction >= 360)
            {
                ball.direction -= 360;
            }
            if (ball.nextCoord().Y < MINBALLY)
            {
                this.ball.direction -= 180;
            }
            else if (ball.nextCoord().Y > MAXBALLY)
            {
                ball.direction -= 180;
            }

            if (ball.nextCoord().X >= PLAYERBARXPOSITION && checkedRight)
            {
                ball.direction -= 180;
            }

            if (ball.nextCoord().X < AIBARXPOSITION && checkedLeft)
            {
                ball.direction -= 180;
            }

            if (ball.direction < 0)
            {
                ball.direction = 360 + ball.direction;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameStarted) {
                if (ballIsMoving) { 
                    if (e.KeyCode.ToString() == "Up")
                    {
                        if (playerBar.Location.Y > MINBALLY )
                        {
                            playerBar.Location = new Point(playerBar.Location.X, playerBar.Location.Y - playerspeed);
                        }
                    }

                    if (e.KeyCode.ToString() == "Down")
                    {
                        if (playerBar.Location.Y < BARMAXY )
                        {
                            playerBar.Location = new Point(playerBar.Location.X, playerBar.Location.Y + playerspeed);
                        }
                    }

                    if (e.KeyCode.ToString() == "Space")
                    {
                        stopBall();
                    }
                } else
                {
                    if (e.KeyCode.ToString() == "Space")
                    {
                        startBall();
                    }
                }
            }

            if (e.KeyCode.ToString() == "Escape")
            {
                stopBall();
                mainView();
            }
        }


        private void normalButton_Click(object sender, EventArgs e)
        {
            startGame(3, 15);
        }
        public void startGame(int aispeed,int playerspeed)
        {
            aiSpeed = aispeed;
            pingpongframe.playerspeed = playerspeed;
            isGameStarted = true;
            easyButton.Hide();
            normalButton.Hide();
            hardButton.Hide();
            this.Focus();
            startBall();
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            startGame(10, 15);
        }

        public void mainView()
        {
            isGameStarted = false;
            easyButton.Show();
            normalButton.Show();
            hardButton.Show();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            startGame(3, 20);
        }
    }
}