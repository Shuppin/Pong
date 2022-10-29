namespace Pong
{
    public partial class Pong : Form
    {

        // Locations
        int cpuDirection = 5;
        int ballX = 5;
        int ballY = 5;
        
        // Score
        int playerScore = 0;
        int cpuScore = 0;

        // Size
        int bottomBoundary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        // Input Detection
        bool playerInputUp;
        bool playerInputDown;

        // Special keys
        int spaceBarDown = 0;

        public Pong()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - paddle_player.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;
        }

        private void Pong_Load(object sender, EventArgs e)
        {

        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            Random random_num = new Random();
            int random_ball_location = random_num.Next(200, ClientSize.Height-200);

            // Apply new location to ball
            pong_ball.Top -= ballY;
            pong_ball.Left -= ballX;

            // Make cpu move
            paddle_cpu.Top += cpuDirection;
            
            // Check if cpu has reached top or bottom of screen
            if (paddle_cpu.Top < 0 || paddle_cpu.Top > bottomBoundary)
            {
                cpuDirection = -cpuDirection;
            }

            // Check if ball has hit left side of screen (cpu scores a point)
            if (pong_ball.Left < 0)
            {
                pong_ball.Left = xMidpoint;
                pong_ball.Top = random_ball_location;
                ballX = -ballX;
                cpuScore++;
                score_cpu.Text = cpuScore.ToString();
            }

            // Check if ball has hit right side of screen (player scores a point)
            if (pong_ball.Left + pong_ball.Width > ClientSize.Width)
            {
                pong_ball.Left = xMidpoint;
                pong_ball.Top = random_ball_location;
                ballX = -ballX;
                playerScore++;
                score_player.Text = playerScore.ToString();
            }

            // Ensure ball is withing boundraries of screen
            if (pong_ball.Top < 0 || pong_ball.Top + pong_ball.Height > ClientSize.Height)
            {
                ballY = -ballY;
            }

            // Check if ball hits player or cpu paddle
            if (pong_ball.Bounds.IntersectsWith(paddle_player.Bounds) || pong_ball.Bounds.IntersectsWith(paddle_cpu.Bounds))
            {
                // Reverse ball direction
                ballX = -ballX;
            }

            // Player input
            if (playerInputUp == true && paddle_player.Top > 0)
            {
                paddle_player.Top -= 10;
            }
            if (playerInputDown == true && paddle_player.Top < bottomBoundary)
            {
                paddle_player.Top += 10;
            }

            // Win state
            if (playerScore >= 5)
            {
                pongTimer.Stop();
            }
        }

        private void Pong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerInputUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerInputDown = true;
            }

            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarDown % 2 == 0)
                {
                    pongTimer.Stop();
                }
                else
                {
                    pongTimer.Start();
                }

                spaceBarDown++;
            }
        }

        private void Pong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                playerInputUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                playerInputDown = false;
            }
        }
    }
}