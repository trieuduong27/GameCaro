using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
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
		//private List<Player> player;

		//public List<Player> Player
		//{
		//    get { return player; }
		//    set { player = value; }
		//}
		//// lưu người dnash
		//private int currenPlayer;
		//public int CurrenPlayer
		//{
		//    get { return currenPlayer; }
		//    set { currenPlayer = value; }

		//}

		#endregion

		#region Initialize
		public ChessBoardManager(Panel chessBoard)
        {
            //thêm tính năng cho phép thay đôit ten người chơi
            this.ChessBoard = chessBoard;
            //this.Player = new List<Player>()
            //{
            //    new Player("O", Image.FromFile((Application.StartupPath+ "\\Resources\\O_caro.png"))),
            //    new Player("X" , Image.FromFile((Application.StartupPath+ "\\Resources\\X_caro.png")))
               
            //};
            //CurrenPlayer = 0;
        }
        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            for (int i = 0; i < Cons.CHEST_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j < Cons.CHEST_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch // fit ảnh
                    };
                    btn.Click += btn_Click;
                    ChessBoard.Controls.Add(btn);

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

            // đỏi ảnh 
            btn.BackgroundImage = Image.FromFile((Application.StartupPath + "\\Resources\\X_caro.png"));
            //btn.BackgroundImage = Player[CurrenPlayer].Mark;

            //CurrenPlayer = CurrenPlayer == 1 ? 0 : 1;
            #endregion

        }
    }
}
