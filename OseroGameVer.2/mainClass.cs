using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//■■■■■■■■■■■■■■■仕様■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
//このプログラムは　https://bassy84.net/othello-syosin.html　を参考に戦法を作っています。
//https://uguisu.skr.jp/othello/2-1.html　も参考にしている

//全体の60%が埋まるまで、機械は０以外の最も少なくひっくり返す場所に置く。

//接待モード　おけるところにらんだむでおく。メッセージボックスでよいしょ！3つ以上ひっくり返せると褒める。
//初級モード　一番多くひっくり返す番地におく。
//中級モード　全体の60%が埋まるまで、機械は０以外の最も少なくひっくり返す場所に置く。おければ4角に置く。
//上級級モード　帝石？
//ぴえん＝白　ねこ＝黒


//見やすいコードとは　=　変更しやすい。
//部品同士が依存関係にない
//構造化されている=構造があるということ。

namespace OseroGameVer._2
{
   
    static class mainClass
    {
        //fainal変数たち
        public static int SIZE = 8;
        public static int KARA = 0;
        public static int SHIRO = 1;
        public static int KURO = 2;
     
        //boardの正体を作る
        public static int[] boardIdentitiy = new int[SIZE * SIZE];
        public static readonly string BLANK = " ";

        //playerの実体を作る
        public static PlayerClass player1 = new PlayerClass(1);
        public static PlayerClass player2 = new PlayerClass(2);
        public static PlayerClass nowPlayer = player1;


        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BaseBoardForm mainboard = new BaseBoardForm();
            

            Application.Run(new doSettingForm());

            makeBoard(boardIdentitiy);

            BaseBoardForm.refleshUI(nowPlayer, mainboard);
            PlayerClass.josekiArray = PlayerClass.INITIA;
            
            if (player1.playerType == PlayerClass.AUTO) 
            {
                //mainboard.Show();
                //考えてる風にする
                //System.Threading.Thread.Sleep(3000);
                //mainboard.Close();
                putStone(mainboard, player1);

                BaseBoardForm.refleshUI(player2, mainboard);
                nowPlayer = player2;
            }

            mainboard.ShowDialog();
            //プロパティ
            //オブジェクト指向

            //モーダルとモーダレス
            //Windows　マルチスレッド　シングルスレッド

            //複数のものが同時にうごいているように見せかける　プロセス＞スレッド
            //show showdaialog
            
        }



        //一回しか使わないのに関数にしてる。
        private static int[] makeBoard(int[] someBoard)
        {
            for (int i = 0; i < SIZE * SIZE; i++)
            {
                someBoard[i] = KARA;
            }

            AIForAll.coordinateAddress(SIZE / 2 + 1, SIZE / 2 + 1);
            //SIZE /2 + 1

            someBoard[AIForAll.coordinateAddress(SIZE / 2 - 1, SIZE / 2 - 1)] = SHIRO;
            someBoard[AIForAll.coordinateAddress(SIZE / 2    , SIZE / 2 - 1)] = KURO;
            someBoard[AIForAll.coordinateAddress(SIZE / 2 - 1, SIZE / 2    )] = KURO;
            someBoard[AIForAll.coordinateAddress(SIZE / 2    , SIZE / 2    )] = SHIRO;
            return someBoard;
        }

        //public static void mainLoop(BaseBoardForm board,PlayerClass player1, PlayerClass  player2)
        //{
        //    //board.ShowDialog();
        //    PlayerClass nowPlayer = player1;
        //    //board.Refresh();
        //    for (int i = 0; i < mainClass.SIZE * mainClass.SIZE; i++)
        //    {
        //        //UI
        //        if (nowPlayer.PlayerType == PlayerClass.MANUAL)
        //        {
        //            board.label_info.Text = "あなたの番です";
        //        }
        //        else 
        //        {
        //            board.label_info.Text = "機械の番です";
        //        }
        //        board.btn_save.Visible = nowPlayer.SaveVisble;
        //        board.Refresh();

        //        //プログラム
        //        if (AIForAll.countBlank() == 0) { break; }
        //        putStone(board,nowPlayer);

        //        nowPlayer = nowPlayer == player1 ? player2 : player1;
        //        //board.Refresh();
        //    }
        //}
     

        public static void putStone(BaseBoardForm board,PlayerClass nowPlayer)
        {
            if (nowPlayer.PlayerType == PlayerClass.AUTO)
            {
                board.Cursor = Cursors.WaitCursor;
                //考えてる風にする
                System.Threading.Thread.Sleep(3000);
                //Task.Delay(5000);
                AIFforKikai.putByAout(nowPlayer);
                board.Cursor = Cursors.Default;

            }
            board.Refresh();

        }

    }
}
