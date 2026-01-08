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

        private TextBox playerName1;
        public TextBox PlayerName
        {
            get => playerName1;
            set => playerName1 = value;
        }

        private PictureBox playerMark;
        public PictureBox PlayerMark
        {
            get => playerMark;
            set => playerMark = value;
        }
        private List<List<Button>> Matrix;

        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            //thêm tính năng cho phép thay đôi ten người chơi
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.PlayerMark = mark;

            this.Player = new List<Player>() // phat trien tinh nhan cho phep them nguoi choi, cho phep thay doi ki tu nguoi choi
            {
                new Player("Người chơi O", Image.FromFile((Application.StartupPath+ "\\Resources\\O_caro1.png"))),
                new Player("Người chơi X" , Image.FromFile((Application.StartupPath+ "\\Resources\\X_caro1.png")))

            };
            currenPlayer = 0;

            ChangePlayer();
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
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
                        //luwuw texxt
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

            ChangePlayer();
            if (isEndGame(btn))
            {

                EndGame();
            }
        }
        private void EndGame()
        {
            MessageBox.Show("Ket thuc game");
        }

        private bool isEndGame (Button btn)
        {
            return isEndGameHorizontal(btn)||isEndGamePrimary(btn)||isEndGamePrimary(btn)||isEndSub(btn);
        }

        private Point GetChessPoint(Button btn)
        {
           
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

			Point point = new Point(horizontal , vertical);

			return point;
        }
		private bool isEndGameHorizontal(Button btn)
		{
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i > 0; i--)
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

            return countLeft + countRight == 5;
        }
		private bool isEndGameVerical(Button btn)
		{
			return false;
		}
		private bool isEndGamePrimary(Button btn)
		{
			return false;
		}
		private bool isEndSub(Button btn)
		{
			return false;
		}


		// đổi ảnh X vs O theo player
		private void Mark(Button btn)
        {
            btn.BackgroundImage = Player[CurrenPlayer].Mark;

            currenPlayer = currenPlayer == 1 ? 0 : 1;
        }
        private void ChangePlayer()
        {
            PlayerName.Text = Player[currenPlayer].Name;

            PlayerMark.Image = Player[currenPlayer].Mark;
        }
        #endregion



    }
}
