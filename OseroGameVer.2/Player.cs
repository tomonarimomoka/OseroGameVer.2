using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OseroGameVer._2
{
    public class Player
    {
        //実態を2つ作る
        //PLAYER1 と　PLAYER2
        public  int playerType = 0;
        public  int color = 0;
        public   bool humanIsFirst = true;
        public   int mode = -1;
        public   int lastHumanAddress = -1;
        public   int josekiType = -1;
        public   int[,] josekiArray ;
        public  bool saveVisble = false;


        ///const変数       
        public const int AUTO = 1;
        public const int MANUAL = 2;

        //初期設定配列(この配列に意味はない)
        public  int[,] INITIA = { {1 ,1 }};

        public  int[,] USAGI =
        {   { 5, 4 }, //37
            { 3, 5 }, //43
            { 2, 4 }, //34
            { 5, 3 }, //27
            { 4, 2 }, //20
            { 2, 5 }, //42
            { 3, 2 }, //11
            { 5, 5 }, //45
            { 4, 5 }, //29
            { 3, 6 }  //51
        };

        //牛はいれつ
        public  int[,] USI =
        {
            { 5,4 }, //37
            { 5,5 }, //45
            { 4,5 }, //44
            { 5,3 }, //29
            { 4,2 }, //20
            { 2,4 }, //34
            { 2,3 }, //24
            { 4,6 }, //52
            { 2,5 }  //82
        };

        //鼠配列
        public  int[,] NEZUM =
        {
            { 5,4 }, //37
            { 5,3 }, //29
            { 4,2 }, //20
            { 5,5 }, //45
            { 3,2 }  //19
        };

        //コンストラクタとは特殊なメソッド
        public Player(int num)
        {
            Whole whole = new Whole();
            if (num == 1)
            {
                //playerType = humanIsFirst == true ? MANUAL : AUTO;
                color = whole.KURO;

            }
            else if(num == 2)
            {
                //playerType = playerType = humanIsFirst == true ? AUTO : MANUAL ;
                color = whole.SHIRO;
            }

        }

        public int PlayerType
        {
            get { return playerType; }

        }

        public bool SaveVisble 
        {
            get 
            {
                if (playerType == MANUAL) return true;
                else return false;
            }
        }

        public int Color 
        {
            get { return color; }
        }

        public int Mode 
        {
            get { return mode; }
        }

        public int[,] JosekiArray
        {
            get { return josekiArray; }

        }

        public int LastHumanAddress
        {
            get { return lastHumanAddress; }
            set { lastHumanAddress = value; }
        }



    }
}
