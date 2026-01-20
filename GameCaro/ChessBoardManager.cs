using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public class ChessBoardManager
    {

        #region Properties
        private Panel chessBoard;

        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        //tạo 1 mảng player

        private List<Player> player;
        public List<Player> Player
        {
            get => player;
            set => player = value;
        }
        //// lưu người đánh
        private int currenPlayer;
        public int CurrenPlayer
        {
            get { return currenPlayer; }
            set { currenPlayer = value; }
        }

        private TextBox playerName;
        public TextBox PlayerName
        {
            get => playerName;
            set => playerName = value;
        }

        private PictureBox playerMark;
        public PictureBox PlayerMark
        {
            get => playerMark;
            set => playerMark = value;
        }

        private List<List<Button>> Matrix;
        //public List<List<Button>> Matrix
        //{
        //    get => matrix;
        //    set => matrix = value;
        //}

        private event EventHandler<ButtonClickEvent> playerMarked;
        public event EventHandler<ButtonClickEvent> PlayerMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        private Stack<Playinfo> playTimeLine;
		public Stack<Playinfo> PlayTimeLine { get => playTimeLine; set => playTimeLine = value; }

		#endregion

		#region Initialize
		public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            //thêm tính năng cho phép thay đổi ten người chơi
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;

            this.Player = new List<Player>() // phat trien tinh nang cho phep them nguoi choi, cho phep thay doi ki tu nguoi choi
            {
				  new Player("Người chơi X" , Image.FromFile((Application.StartupPath+ "\\Resources\\X_caro1.png"))),

				  new Player("Người chơi O", Image.FromFile((Application.StartupPath+ "\\Resources\\O_caro1.png")))
              

            };
         
		}
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear();

			PlayTimeLine = new Stack<Playinfo>();

			currenPlayer = 0;

			ChangePlayer();

			Matrix = new List<List<Button>>();

            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHEST_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.CHEST_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch, // fit ảnh
                        //Lưu text
                        Tag = i.ToString()
                    };

                    btn.Click += btn_Click;

                    ChessBoard.Controls.Add(btn);
                    
                    Matrix[i].Add(btn);

                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.CHESS_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            // ktra neu ton tai thi khong can doi bg
            if (btn.BackgroundImage != null)
                return;
            
            Mark(btn);

            PlayTimeLine.Push(new Playinfo(GetChessPoint(btn), CurrenPlayer));

			currenPlayer = currenPlayer == 1 ? 0 : 1;

			ChangePlayer();

            if (playerMarked != null)
                playerMarked(this, new ButtonClickEvent(GetChessPoint(btn)));

            if (isEndGame(btn))
            {

                EndGame();
            }
        }

        public void OtherPlayerMark(Point point)
        {
            Button btn = Matrix[point.Y][point.X];

            if (btn.BackgroundImage != null)
                return;

            Mark(btn);

            PlayTimeLine.Push(new Playinfo(GetChessPoint(btn), CurrenPlayer));

            currenPlayer = currenPlayer == 1 ? 0 : 1;

            ChangePlayer();

            if (isEndGame(btn))
            {

                EndGame();
            }
        }

        public void EndGame()
        {
            if (endedGame !=  null)
                endedGame(this, new EventArgs());
        }

        public bool Undo()
        {

            if (PlayTimeLine.Count <= 0)
            {
                return false;
            }
            Playinfo oldPoint = PlayTimeLine.Pop();
			Button btn = Matrix[oldPoint.Point.Y][oldPoint.Point.X];

            btn.BackgroundImage = null;


            if (PlayTimeLine.Count <= 0)
            {
                
                CurrenPlayer = 0;
            }
            else
            {
				oldPoint = PlayTimeLine.Peek();
				CurrenPlayer = oldPoint.CurrentPlayer == 1 ? 0 : 1;
            }
			ChangePlayer();

			return true;
		}
		private bool isEndGame (Button btn)
        {
            return isEndHorizontal(btn)||isEndVerical(btn)||isEndPrimary(btn)||isEndSub(btn);
        }
        // lấy tọa độ burtton 
        private Point GetChessPoint(Button btn)
        {
           
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

			Point point = new Point(horizontal , vertical);

			return point;
        }

        // kiểm tra hàng ngang
		private bool isEndHorizontal(Button btn)
		{
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Cons.CHEST_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight >= 5;
        }

        // hàng dọc
		private bool isEndVerical(Button btn)
		{
			Point point = GetChessPoint(btn);

			int countTop = 0;
			for (int i = point.Y; i >= 0; i--)
			{
				if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
				{
					countTop++;
				}
				else
					break;
			}

			int countBottom = 0;
			for (int i = point.Y + 1; i < Cons.CHEST_BOARD_HEIGHT; i++)
			{
				if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
				{
					countBottom++;
				}
				else
					break;
			}

			return countTop + countBottom >= 5;
		}
        //hàng chéo chính
        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0) //kiem tra có tràn khỏi mảng
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Cons.CHEST_BOARD_WIDTH - point.X; i++)
            {
                if (point.Y + i >= Cons.CHEST_BOARD_HEIGHT || point.X + i >= Cons.CHEST_BOARD_WIDTH) //kiem tra có tràn khỏi mảng
                    break;
                
                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        //cheo phụ
        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= Cons.CHEST_BOARD_WIDTH - point.X; i++)
            {
                if (point.X + i > Cons.CHEST_BOARD_WIDTH || point.Y - i < 0) //kiem tra có tràn khỏi mảng
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= point.X; i++)
            {
                if (point.Y + i >= Cons.CHEST_BOARD_HEIGHT || point.X - i < 0) //kiem tra có tràn khỏi mảng
                    break;
                
                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom >= 5;
        }

        // đổi ảnh X vs O theo player
        private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrenPlayer].Mark;

           
        }
        private void ChangePlayer()
        {
            PlayerName.Text = Player[currenPlayer].Name;

            PlayerMark.Image = Player[currenPlayer].Mark;
        }
        #endregion
    }

    public class ButtonClickEvent : EventArgs
    {
        private Point clickedPoint;

        public Point ClickedPoint 
        { 
            get => clickedPoint; 
            set => clickedPoint = value; 
        }

        public ButtonClickEvent(Point point)
        {
            this.clickedPoint = point;
        }
    }
}
