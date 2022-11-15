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
        //用回収
        int size;
        bool fumanIsFirst;
        int[] boardIdentitiy;
        //playerの実体を作る
        Player player1 = new Player(1);
        Player player2 = new Player(2);
        Player nowPlayer;

        public BaseBoardForm(int inputSize , bool inputHumanIsFirst,int inputMode)
        {
            InitializeComponent();
            size = inputSize;
            fumanIsFirst = inputHumanIsFirst;
            player1.mode = inputMode;
            player2.mode = inputMode;

            boardIdentitiy = makeBoard(size);
            
        }


        private void BaseForm_Load(object sender, EventArgs e)
        {
            nowPlayer = player1;
            //先攻なら、
            if (fumanIsFirst)
            {
                player1.playerType = Player.MANUAL;
                player2.playerType = Player.AUTO;

            }
            else 
            {
                player1.playerType = Player.AUTO;
                player2.playerType = Player.MANUAL;
                putStone(this, nowPlayer);
                nowPlayer = nowPlayer == player1 ? player2 : player1;
                //board.Refresh();
                //綴り
                refreshUI(nowPlayer, this);
            }


            this.Width = 44 + size * 50;
            this.Height = size * 50 + 200;
            pic_Board.Width = 1 + size * 50;
            pic_Board.Height = 1 + size * 50 ;

            txtAddress.Location = new Point(10, pic_Board.Height + 60 + btn_save.Height / 4);
            btn_save.Location = new Point(60, pic_Board.Height + 60);
            label_info.Location = new Point(10, pic_Board.Height + 10);

            refreshUI(nowPlayer,this);


        }


        //一回しか使わないのに関数にしてる。
        private int[] makeBoard(int size)
        {
            
            int[] someBoard = new int[size * size];
            Whole whole = new Whole();
            for (int i = 0; i < size * size; i++)
            {
                someBoard[i] = whole.KARA;
            }
            Algorithm alg = new Algorithm(size, someBoard);
            alg.coordinateAddress(size / 2 + 1, size / 2 + 1);
            //size /2 + 1

            someBoard[alg.coordinateAddress(size / 2 - 1, size / 2 - 1)] = whole.SHIRO;
            someBoard[alg.coordinateAddress(size / 2, size / 2 - 1)] = whole.KURO;
            someBoard[alg.coordinateAddress(size / 2 - 1, size / 2)] = whole.KURO;
            someBoard[alg.coordinateAddress(size / 2, size / 2)] = whole.SHIRO;
            return someBoard;
        }

        //location
        private  double[] getLocation(int address)
        {
            Algorithm alg = new Algorithm(size, boardIdentitiy);
            //side(辺)
            int SIDE = 50;
            
            int x = alg.getXorY(address, "x");
            int y = alg.getXorY(address, "y");

            double[] locatArray = { 2.5 + x * SIDE, 2.5 + y * SIDE };

            return locatArray;

        }


        public static void refreshUI(Player nowPlayer,BaseBoardForm board) 
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
            Algorithm alg = new Algorithm(size, boardIdentitiy);
            Whole whole = new Whole();
            

            if (this.txtAddress.Text == string.Empty) 
            {
                MessageBox.Show("値を入力してください。");
                return;
            }

            int outAddress;
            int putAddress = Int32.Parse(this.txtAddress.Text);
            if (!int.TryParse(this.txtAddress.Text, out outAddress))
            //入力されたテキストが数字以外ならバリデーション
            {
                MessageBox.Show("数字のみを入力してください");
                return;
            }
            else if (!(0 <= putAddress && putAddress <= size * size))
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

                }
                else
                {
                    if (alg.canPassOrNot(nowPlayer)) 
                    {
                        MessageBox.Show("ひっくり返せませんが、おける場所がないのでおきます。");
                        //オセロの盤面に石を置く。
                        boardIdentitiy[putAddress] = nowPlayer.Color;
                        this.txtAddress.Text = string.Empty;
                    }
                    else 
                    {
                        MessageBox.Show("ひっくり返せない場所には置けません。");
                        return;
                    }
                }
            }


            //機械が打つ
            nowPlayer = nowPlayer == player1 ? player2 : player1;
            nowPlayer.LastHumanAddress = putAddress;
            refreshUI(nowPlayer,this);
            //プログラム
            if (alg.countBlank() != 0) 
            {
                putStone(this, nowPlayer);
            }

            nowPlayer = nowPlayer == player1 ? player2 : player1;
            //board.Refresh();
            refreshUI(nowPlayer,this);


            //勝敗判定
            if (alg.countBlank() == 0) 
            {
                DialogResult result =  MessageBox.Show(alg.retrunWinOrLossMess()+"\nゲームを終了します。");

                if(result == DialogResult.OK) { this.Close(); }
            }

        }





        private void pic_Board_Paint(object sender, PaintEventArgs e)
        {
            Whole whole = new Whole();
            //side(辺)
            int SIDE = 50;
            //x
            for (int i = 0; i < (size + 1); i++)
            {
                var point1 = new Point(0, i * SIDE);
                var point2 = new Point(SIDE * size, i * SIDE);

                e.Graphics.DrawLine(Pens.Black, point1, point2);

            }
            //y
            for (int i = 0; i < (size + 1); i++)
            {
                var point1 = new Point(i * SIDE, 0);
                var point2 = new Point(i * SIDE, SIDE * size);

                e.Graphics.DrawLine(Pens.Black, point1, point2);

            }


            //フォントオブジェクトの作成
            Font fnt = new Font("MS UI Gothic", 25);

            for (int i = 0; i < size * size; i++)
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
            Algorithm alg = new Algorithm(size, boardIdentitiy);

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
