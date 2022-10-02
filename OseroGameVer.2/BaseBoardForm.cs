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
    public partial class BaseBoardForm : Form
    {
        public BaseBoardForm()
        {
            InitializeComponent();
        }


        private void BaseForm_Load(object sender, EventArgs e)//, PaintEventArgs e2)
        {
            this.Width = 44 + mainClass.SIZE * 50;
            this.Height = mainClass.SIZE * 50 + 200;
            pic_Board.Width = 1 + mainClass.SIZE * 50;
            pic_Board.Height = 1 + mainClass.SIZE * 50 ;

            txtAddress.Location = new Point(10, pic_Board.Height + 60 + btn_save.Height / 4);
            btn_save.Location = new Point(60, pic_Board.Height + 60);
            label_info.Location = new Point(10, pic_Board.Height + 10);
            
        }

   


        //location
        private static double[] getLocation(int address)
        {
            //side(辺)
            int SIDE = 50;
            int x = AIForAll.getXorY(address, "x");
            int y = AIForAll.getXorY(address, "y");

            double[] locatArray = { 2.5 + x * SIDE, 2.5 + y * SIDE };

            return locatArray;

        }


        //要改修
        public static void refleshUI(PlayerClass nowPlayer,BaseBoardForm board) 
        {
            //UI
            if (nowPlayer.PlayerType == PlayerClass.MANUAL)
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
            int outAddress;
            int putAddress = Int32.Parse(this.txtAddress.Text) ;
            //入力されたテキストが数字以外ならバリデーション
            if (!int.TryParse(this.txtAddress.Text, out outAddress))
            {
                MessageBox.Show("数字のみを入力してください");
                return;
            }
            else if (!(0 <= putAddress && putAddress <= mainClass.SIZE * mainClass.SIZE))
            {
                MessageBox.Show("入力された数字が範囲外です");
                return;
            }
            else
            {
                //1つ以上ひっくり返せる場所なら置く。
                if (AIForAll.allDirReturn(putAddress, false, mainClass.nowPlayer) != 0)
                {
                    //オセロの盤面に石を置く。
                    mainClass.boardIdentitiy[putAddress] = mainClass.nowPlayer.Color;
                    
                    
                    
                   
                    AIForAll.allDirReturn(putAddress, true, mainClass.nowPlayer);
                    
                    this.txtAddress.Text = string.Empty;

                    PlayerClass.lastHumanAddress = putAddress;
                }
                else
                {
                    MessageBox.Show("ひっくり返さない場所にはおけません。");
                    return;
                }
            }


            //機械が打つ
            mainClass.nowPlayer = mainClass.nowPlayer == mainClass.player1 ? mainClass.player2 : mainClass.player1;

            refleshUI(mainClass.nowPlayer,this);
            //プログラム
            if (AIForAll.countBlank() != 0) 
            {
                mainClass.putStone(this, mainClass.nowPlayer);
            }

            mainClass.nowPlayer = mainClass.nowPlayer == mainClass.player1 ? mainClass.player2 : mainClass.player1;
            //board.Refresh();
            refleshUI(mainClass.nowPlayer,this);

        }





        private void pic_Board_Paint(object sender, PaintEventArgs e)
        {
            //side(辺)
            int SIDE = 50;
            //x
            for (int i = 0; i < (mainClass.SIZE + 1); i++)
            {
                var point1 = new Point(0, i * SIDE);
                var point2 = new Point(SIDE * mainClass.SIZE, i * SIDE);

                e.Graphics.DrawLine(Pens.Black, point1, point2);

            }
            //y
            for (int i = 0; i < (mainClass.SIZE + 1); i++)
            {
                var point1 = new Point(i * SIDE, 0);
                var point2 = new Point(i * SIDE, SIDE * mainClass.SIZE);

                e.Graphics.DrawLine(Pens.Black, point1, point2);

            }


            //フォントオブジェクトの作成
            Font fnt = new Font("MS UI Gothic", 25);

            for (int i = 0; i < mainClass.SIZE * mainClass.SIZE; i++)
            {
                double[] Location = getLocation(i);
                float xLocation = (float)Location[0];
                float yLocation = (float)Location[1];


                if (mainClass.boardIdentitiy[i] == mainClass.KURO)
                {
                    e.Graphics.FillEllipse(Brushes.Black, xLocation, yLocation, 45, 45);

                }
                else if (mainClass.boardIdentitiy[i] == mainClass.SHIRO)
                {
                    e.Graphics.FillEllipse(Brushes.White, xLocation, yLocation, 45, 45);
                }
                else if (mainClass.boardIdentitiy[i] == mainClass.KARA)
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

        
    }
}
