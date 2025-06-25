using System;
using System.Net.Sockets;

namespace labwork37
{
    public partial class MainForm : Form
    {
        private int _ballSpeedX;
        private int _ballSpeedY;
        private int _score = 0;
        private int _lostBalls = 0;
        private Racket _racket;
        private Ball _ball;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region ball
            _ball = new Ball();
            var x = Random.Shared.Next(50, 850);
            var y = Random.Shared.Next(300, 450);

            _ball.Location = new Point(x, y);
            FieldPanel.Controls.Add(_ball);

            System.Drawing.Drawing2D.GraphicsPath path =
                new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(_ball.ClientRectangle);
            _ball.Region = new Region(path);

            _ballSpeedX = _ball.Location.X < FieldPanel.Width / 2 ? 4 : -4;
            _ballSpeedY = -4;
            #endregion

            #region racket
            _racket = new Racket();
            _racket.Location = new Point(405, 570);
            FieldPanel.Controls.Add(_racket);
            #endregion

            Reset();
        }

        private void Reset()
        {
            ContestLabel.Text = "";
            WinLabel.Text = "";
            ScoreLabel.Text = "Ñ×¨Ò: 0";
            _score = 0;
            LostBallLabel.Text = "ÏÎÒÅÐßÍÎ: 0";
            _lostBalls = 0;

            #region blocks
            for (int i = 0; i < 10; i++)
            {
                Block block = new Block()
                {
                    BackColor = Color.Red,
                    Location = new Point(i * 100 + 15, 90),
                };
                FieldPanel.Controls.Add(block);
            }

            for (int i = 0; i < 10; i++)
            {
                Block block = new Block()
                {
                    BackColor = Color.OrangeRed,
                    Location = new Point(i * 100 + 15, 120)
                };
                FieldPanel.Controls.Add(block);
            }

            for (int i = 0; i < 10; i++)
            {
                Block block = new Block()
                {
                    BackColor = Color.Orange,
                    Location = new Point(i * 100 + 15, 150)
                };
                FieldPanel.Controls.Add(block);
            }

            for (int i = 0; i < 10; i++)
            {
                Block block = new Block()
                {
                    BackColor = Color.Yellow,
                    Location = new Point(i * 100 + 15, 180)
                };
                FieldPanel.Controls.Add(block);
            }
            #endregion

            GameFrameTimer.Start();
        }

        private void GameFrameTimer_Tick(object sender, EventArgs e)
        {
            ScoreLabel.Text = $"Ñ×¨Ò: {_score}";
            LostBallLabel.Text = $"ÏÎÒÅÐßÍÎ: {_lostBalls}";

            if (_score >= 900)
            {
                GameFrameTimer.Stop();
                WinLabel.Text = "ÂÛ ÏÎÁÅÄÈËÈ";
            }

            var point = FieldPanel.PointToClient(MousePosition);
            int racketCenterX = _racket.Width / 2;
            if (point.X > racketCenterX && point.X < this.ClientSize.Width - racketCenterX)
            {
                _racket.Location = new Point(point.X - racketCenterX, _racket.Top);
            }

            #region ballColl
            _ball.Location = new Point(_ball.Location.X + _ballSpeedX, _ball.Location.Y + _ballSpeedY);
            Rectangle ball = _ball.Bounds;

            if (_ball.Left <= 0 || _ball.Right >= FieldPanel.Right)
            {
                _ballSpeedX = -_ballSpeedX;
            }
            else if(_ball.Top <= 0)
            {
                _ballSpeedY = -_ballSpeedY;
            }

            if (ball.IntersectsWith(_racket.Bounds))
            {
                _ballSpeedY = -_ballSpeedY;
            }
            #endregion

            #region score
            Rectangle ballRect = _ball.Bounds;
            for (int i = FieldPanel.Controls.Count - 1; i >= 0; i--)
            {
                Control item = FieldPanel.Controls[i];

                if (item is Panel && item != _ball && item != _racket)
                {
                    ballRect.Intersect(item.Bounds);
                    
                    if (ball.IntersectsWith(item.Bounds))
                    {
                        if (ballRect.Height > ballRect.Width)
                        { _ballSpeedX = -_ballSpeedX; }
                        else 
                        { _ballSpeedY = -_ballSpeedY; }

                        FieldPanel.Controls.Remove(item);

                        if (item.BackColor == Color.Red) _score += 40;
                        if (item.BackColor == Color.OrangeRed) _score += 30;
                        if (item.BackColor == Color.Orange) _score += 20;
                        if (item.BackColor == Color.Yellow) _score += 10;
                    }
                }
            }
            #endregion

            if (_ball.Location.Y > FieldPanel.Bounds.Bottom)
            {
                GameFrameTimer.Stop();
                _lostBalls += 1;
                MessageBox.Show("Ìÿ÷ ïîòåðÿí");
                _ball = new Ball();
                var x = Random.Shared.Next(50, 850);
                var y = Random.Shared.Next(300, 450);

                _ball.Location = new Point(x, y);
                FieldPanel.Controls.Add(_ball);

                System.Drawing.Drawing2D.GraphicsPath path =
                    new System.Drawing.Drawing2D.GraphicsPath();
                path.AddEllipse(_ball.ClientRectangle);
                _ball.Region = new Region(path);
                GameFrameTimer.Start();
                _ballSpeedX = _ball.Location.X < FieldPanel.Width / 2 ? 4 : -4;
                _ballSpeedY = -4;
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && GameFrameTimer.Enabled)
            {
                ContestLabel.Text = "ÏÀÓÇÀ";
                GameFrameTimer.Stop();
            }
            else if (e.KeyCode == Keys.Space && !GameFrameTimer.Enabled)
            {
                ContestLabel.Text = "";
                GameFrameTimer.Start();
            }

            if (_score == 900 && e.KeyCode == Keys.Enter)
            {
                Reset();
            }
        }
    }

    public class GameObject : Panel
    {
        public int LeftBound => Location.X;
        public int TopBound => Location.Y;
        public int RightBound => Location.X + Width;
        public int BottomBound => Location.Y + Height;
    }
    public class Block : GameObject
    {
        public Block()
        {
            Size = new Size(60, 15);
        }
    }
    public class Ball : GameObject
    {
        public Ball()
        {
            Size = new Size(10, 10);
            BackColor = Color.Honeydew;
            DoubleBuffered = true;
        }
    }
    public class Racket : GameObject
    {
        public Racket()
        {
            Size = new Size(50, 10);
            BackColor = Color.SpringGreen;
            DoubleBuffered = true;
        }
    }
}
