using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OseroGameVer._2
{
    public class PlayerClass
    {
        //実態を2つ作る
        //PLAYER1 と　PLAYER2
        public  int playerType = 0;
        public  int color = 0;
        public  static bool humanIsFirst = true;
        public  static int mode = -1;
        public  static int lastHumanAddress = -1;
        public  static int josekiType = -1;
        public  static int[,] josekiArray ;
        public  bool saveVisble = false;

        ///const変数       
        public static int AUTO = 1;
        public static int MANUAL = 2;

        //初期設定配列(この配列に意味はない)
        public static int[,] INITIA = { {1 ,1 }};

        public static int[,] USAGI =
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
        public static int[,] USI =
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
        public static int[,] NEZUM =
        {
            { 5,4 }, //37
            { 5,3 }, //29
            { 4,2 }, //20
            { 5,5 }, //45
            { 3,2 }  //19
        };

        //コンストラクタとは特殊なメソッド
        public PlayerClass(int num)
        {
            if (num == 1)
            {
                playerType = humanIsFirst == true ? MANUAL : AUTO;
                color = mainClass.KURO;

            }
            else if(num == 2)
            {
                playerType = playerType = humanIsFirst == true ? AUTO : MANUAL ;
                color = mainClass.SHIRO;
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
        


    }
}
