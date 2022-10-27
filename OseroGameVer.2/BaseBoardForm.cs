using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OseroGameVer._2
{
    partial class BaseBoardForm : Form
    {
        int SIZE;
        bool HUMAN_IS_FIRST;
        int[] boardIdentitiy;
        //playerの実体を作る
        Player player1 = new Player(1);
        Player player2 = new Player(2);
        Player nowPlayer;
        //algorithmの実態を作る
        //Algorithm alg;
        public BaseBoardForm(int size , bool humanIsFirst,int mood)
        {
            InitializeComponent();
            SIZE = size;
            HUMAN_IS_FIRST = humanIsFirst;
            player1.mode = mood;
            player2.mode = mood;

            boardIdentitiy = makeBoard(SIZE);
            //alg = new Algorithm(SIZE, boardIdentitiy);
            //boardIdentitiy = { SIZE* SIZE};
        }


        private void BaseForm_Load(object sender, EventArgs e)//, PaintEventArgs e2)
        {
            //Whole whole = new Whole();
            //boardIdentitiy = makeBoard(SIZE);
            nowPlayer = player1;
            //先攻なら、
            if (HUMAN_IS_FIRST)
            {
                //Player.humanIsFirst = true;
                player1.playerType = Player.MANUAL;
                player2.playerType = Player.AUTO;

            }
            else 
            {
                //Player.humanIsFirst = false;
                player1.playerType = Player.AUTO;
                player2.playerType = Player.MANUAL;
                putStone(this, nowPlayer);
                nowPlayer = nowPlayer == player1 ? player2 : player1;
                //board.Refresh();
                refleshUI(nowPlayer, this);
            }


            this.Width = 44 + SIZE * 50;
            this.Height = SIZE * 50 + 200;
            pic_Board.Width = 1 + SIZE * 50;
            pic_Board.Height = 1 + SIZE * 50 ;

            txtAddress.Location = new Point(10, pic_Board.Height + 60 + btn_save.Height / 4);
            btn_save.Location = new Point(60, pic_Board.Height + 60);
            label_info.Location = new Point(10, pic_Board.Height + 10);

            refleshUI(nowPlayer,this);


        }


        //一回しか使わないのに関数にしてる。
        private int[] makeBoard(int SIZE)
        {
            
            int[] someBoard = new int[SIZE * SIZE];
            Whole whole = new Whole();
            for (int i = 0; i < SIZE * SIZE; i++)
            {
                someBoard[i] = whole.KARA;
            }
            Algorithm alg = new Algorithm(SIZE, someBoard);
            alg.coordinateAddress(SIZE / 2 + 1, SIZE / 2 + 1);
            //SIZE /2 + 1

            someBoard[alg.coordinateAddress(SIZE / 2 - 1, SIZE / 2 - 1)] = whole.SHIRO;
            someBoard[alg.coordinateAddress(SIZE / 2, SIZE / 2 - 1)] = whole.KURO;
            someBoard[alg.coordinateAddress(SIZE / 2 - 1, SIZE / 2)] = whole.KURO;
            someBoard[alg.coordinateAddress(SIZE / 2, SIZE / 2)] = whole.SHIRO;
            return someBoard;
        }

        //location
        private  double[] getLocation(int address)
        {
            Algorithm alg = new Algorithm(SIZE, boardIdentitiy);
            //side(辺)
            int SIDE = 50;
            
            int x = alg.getXorY(address, "x");
            int y = alg.getXorY(address, "y");

            double[] locatArray = { 2.5 + x * SIDE, 2.5 + y * SIDE };

            return locatArray;

        }


        //要改修
        public static void refleshUI(Player nowPlayer,BaseBoardForm board) 
        {
            //UI
            if (nowPlayer.PlayerType == Player.MANUAL)
            {
                board.label_info.Text = "あなたの番";
            }
            else
            {
                board.label_info.Text = "機械の番";
            }
            board.btn_save.Visible = nowPlayer.SaveVisble;
            board.Refresh();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Algorithm alg = new Algorithm(SIZE, boardIdentitiy);

            int outAddress;
            int putAddress = Int32.Parse(this.txtAddress.Text) ;
            //入力されたテキストが数字以外ならバリデーション
            if (!int.TryParse(this.txtAddress.Text, out outAddress))
            {
                MessageBox.Show("数字のみを入力してください");
                return;
            }
            else if (!(0 <= putAddress && putAddress <= SIZE * SIZE))
            {
                MessageBox.Show("入力された数字が範囲外です");
                return;
            }
            else
            {
                //1つ以上ひっくり返せる場所なら置く。
                if (alg.allDirReturn(putAddress, false, nowPlayer) != 0)
                {
                    //オセロの盤面に石を置く。
                    boardIdentitiy[putAddress] = nowPlayer.Color;
                    
                    
                    
                   
                    alg.allDirReturn(putAddress, true, nowPlayer);
                    
                    this.txtAddress.Text = string.Empty;

                    
                    //nowPlayer.LastHumanAddress = putAddress;
                }
                else
                {
                    //一つもひっくり返せる場所がない時置いてよい。


                    MessageBox.Show("ひっくり返さない場所にはおけません。");
                    return;
                }
            }


            //機械が打つ
            nowPlayer = nowPlayer == player1 ? player2 : player1;
            nowPlayer.LastHumanAddress = putAddress;
            refleshUI(nowPlayer,this);
            //プログラム
            if (alg.countBlank() != 0) 
            {
                putStone(this, nowPlayer);
            }

            nowPlayer = nowPlayer == player1 ? player2 : player1;
            //board.Refresh();
            refleshUI(nowPlayer,this);

        }





        private void pic_Board_Paint(object sender, PaintEventArgs e)
        {
            Whole whole = new Whole();
            //side(辺)
            int SIDE = 50;
            //x
            for (int i = 0; i < (SIZE + 1); i++)
            {
                var point1 = new Point(0, i * SIDE);
                var point2 = new Point(SIDE * SIZE, i * SIDE);

                e.Graphics.DrawLine(Pens.Black, point1, point2);

            }
            //y
            for (int i = 0; i < (SIZE + 1); i++)
            {
                var point1 = new Point(i * SIDE, 0);
                var point2 = new Point(i * SIDE, SIDE * SIZE);

                e.Graphics.DrawLine(Pens.Black, point1, point2);

            }


            //フォントオブジェクトの作成
            Font fnt = new Font("MS UI Gothic", 25);

            for (int i = 0; i < SIZE * SIZE; i++)
            {
                double[] Location = getLocation(i);
                float xLocation = (float)Location[0];
                float yLocation = (float)Location[1];


                if (boardIdentitiy[i] == whole.KURO)
                {
                    e.Graphics.FillEllipse(Brushes.Black, xLocation, yLocation, 45, 45);

                }
                else if (boardIdentitiy[i] == whole.SHIRO)
                {
                    e.Graphics.FillEllipse(Brushes.White, xLocation, yLocation, 45, 45);
                }
                else if (boardIdentitiy[i] == whole.KARA)
                {
                    e.Graphics.DrawString(i.ToString(), fnt, System.Drawing.Brushes.Black, xLocation, yLocation);
                }


            }


        }

        //エンターキーでも決定ボタンが押せるようにする
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyData == Keys.Enter )
            {
                btn_save_Click(sender, e);
            }
            
            
        }

        public void putStone(BaseBoardForm board, Player nowPlayer)
        {
            Algorithm alg = new Algorithm(SIZE, boardIdentitiy);
            //Algorithm alg = new Algorithm(SIZE, );
            if (nowPlayer.PlayerType == Player.AUTO)
            {
                board.Cursor = Cursors.WaitCursor;
                //考えてる風にする
                System.Threading.Thread.Sleep(2000);
                alg.putByAout(nowPlayer);
                board.Cursor = Cursors.Default;

            }
            board.Refresh();

        }


    }
}
