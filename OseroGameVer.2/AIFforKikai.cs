using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OseroGameVer._2
{
    class AIFforKikai
    {
        //4角におけるか調べてくれる関数。置けるなら、おけるアドレスを、置けないなら-1が帰ってくる関数。
        public static　int CanPutCornerOrNot(PlayerClass nowPlayer)
        {
            int returnNumber = -1;
            int first = 0;
            int second = mainClass.SIZE - 1;
            int thard = AIForAll.coordinateAddress(0, mainClass.SIZE - 1);
            int forth = mainClass.SIZE * mainClass.SIZE - 1;

            if (AIForAll.allDirReturn(first,false, nowPlayer) > 0)
            {
                returnNumber = first;
            }
            if (AIForAll.allDirReturn(second, false, nowPlayer) > 0)
            {
                returnNumber = second;
            }
            if (AIForAll.allDirReturn(thard, false, nowPlayer) > 0)
            {
                returnNumber = thard;
            }
            if (AIForAll.allDirReturn(forth, false, nowPlayer) > 0)
            {
                returnNumber = forth;
            }
            return returnNumber;
        }


        //ひっくり返せる数をそれぞれのアドレスで調べて配列に入れる。その配列を返す関数。
        public static int[] searchNextKikaiBannti(PlayerClass nowPlayer)
        {
            int countReturnNumber = 0;
            int[] arrayPoint = new int[64];
            for (int i = 0; i < mainClass.SIZE*mainClass.SIZE; i++)
            {
                if (mainClass.boardIdentitiy[i] == mainClass.KARA)
                {
                    countReturnNumber = AIForAll.allDirReturn(i, false, nowPlayer);                    
                }
                else
                {
                    countReturnNumber = 0;
                }
                arrayPoint[i] = countReturnNumber;
            }


            return arrayPoint;
        }

        
        public static void putByAout(PlayerClass nowPlayer) 
        {
            int nextAddress = -1;
            //おけたら4角に置く。
            if (CanPutCornerOrNot(nowPlayer) == -1)
            {
                //接待
                if (nowPlayer.Mode == 1) 
                {
                    nextAddress = KIAKIrandom(nowPlayer);
                }
                else
                {
                    int[] arrayCount = searchNextKikaiBannti(nowPlayer);

                    switch (nowPlayer.Mode)
                    {

                        //syokyuu
                        case 2:
                            //一番多くひっくり返せる場所に置く。
                            nextAddress = Array.IndexOf(arrayCount, arrayCount.Max());
                            break;
                        //中級モード
                        case 3:
                            nextAddress = chukyu(arrayCount);
                            break;
                        case 4:
                            nextAddress = returnAddressByJOSEKI(nowPlayer,arrayCount);
                            break;
                    }

                }
            }
            //置ける
            else
            {
                nextAddress = CanPutCornerOrNot(nowPlayer);
            }
            mainClass.boardIdentitiy[nextAddress] = nowPlayer.Color;
            //9/26用回収
            AIForAll.allDirReturn(nextAddress, true, nowPlayer);

        }


        public static int KIAKIrandom(PlayerClass nowPlayer)
        {
            int blankCount = 0;
            int address = -1;
            int[] boardBlank = new int[mainClass.SIZE*mainClass.SIZE + 1];
            //ランダムで打つために空いているばんちを boardBlankに記録しておく。
            for (int i = 0; i < mainClass.SIZE * mainClass.SIZE; i++)
            {
                //iが空であるかつ、一つ以上ひっくり返せるアドレスを探す。
                if (mainClass.boardIdentitiy[i] ==  mainClass.KARA && AIForAll.allDirReturn(i,false, nowPlayer) > 0)
                {
                    //アドレスを配列に保存
                    boardBlank[blankCount] = i;
                    blankCount++;
                }
            }

            if (blankCount > 0)
            {
                Random random = new Random();
                int randomvalue = random.Next(blankCount);
                address = boardBlank[randomvalue];
                
            }

            return address;


        }



        public static bool IsFilledSixtyPaesent() 
        {
            //6割埋まっていない場合
            if (AIForAll.countBlank() >= mainClass.SIZE * mainClass.SIZE * 0.6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //一番少なくひっくり返せるアドレスを調べる。
        public static int lowestAddress(int[] arrayCount) 
        {
            int address = -1;
            for (int i = 1; 1 < mainClass.SIZE * 4; i++)
            {
                address = Array.IndexOf(arrayCount, i);
                if (address != -1) { break; }
            }
            return address;
        }


        //-------------------------------------------------------------------------------------
        //  中級モード
        //-------------------------------------------------------------------------------------
        public static int chukyu(int[] arrayCount) 
        {
            int nextAddress = -1;
            if (IsFilledSixtyPaesent())
            {
                //一番多くひっくり返せる場所に置く。
                nextAddress = Array.IndexOf(arrayCount, arrayCount.Max());
            }
            else
            {
                //一番少なくひっくり返せる場所に置く。
                nextAddress = lowestAddress(arrayCount);
            }

            return nextAddress;
        }

        //-------------------------------------------------------------------------------------
        //  定石モード
        //-------------------------------------------------------------------------------------
        //前から空いてる配列があればおく。
        //定石全部埋まってるか調べられる。埋まってたらtrue
        public static int jouseki(int[,] array,PlayerClass nowPlayer)
        {
            int candidateAddress = -1;
            //二次元配列なので、２で÷
            int arraySize = array.Length / 2;

            for (int i = 0; i < arraySize; i++)
            {
                candidateAddress = AIForAll.coordinateAddress(array[i, 0], array[i, 1]);

                //からかつひっくり返せたら置く。
                if (mainClass.boardIdentitiy[candidateAddress] == mainClass.KARA 
                    && AIForAll.allDirReturn(candidateAddress, false, nowPlayer) > 0)
                {
                    break;
                }

                //配列が終わってからのコードも
                if (i == arraySize - 1) 
                {
                    candidateAddress = -1;
                }
                    
            }
            return candidateAddress;
        }

        //ここでどこに打つか決める
        private static int returnAddressByJOSEKI(PlayerClass nowPlayer,int[] arrayCount)
        {
            //残りの空いているアドレスを調べる
            int restAddress = mainClass.SIZE * mainClass.SIZE - 4 - AIForAll.countBlank();
            int nextAddress = -1;
            //残りの空いているアドレス
            if (restAddress == 0)
            {
                //i=0のときは、なんでもOK
                //もし人が後攻を選んだら初めは機械。
                //初めは5,4が無難らしい。
                nextAddress = AIForAll.coordinateAddress(5, 4);
            }
            //else if(restAddress == 1) 
            else 
            {
                if (PlayerClass.josekiArray == PlayerClass.INITIA) 
                {
                    switch (PlayerClass.lastHumanAddress)
                    {
                        case 18://先攻は置けない

                            break;
                        case 19:
                            PlayerClass.josekiArray = PlayerClass.NEZUM;
                            break;
                        case 20:
                            PlayerClass.josekiArray = PlayerClass.USI;
                            break;
                        case 21://先攻は置けない

                            break;
                        case 26:
                            break;
                        case 29:
                            PlayerClass.josekiArray = PlayerClass.USAGI;
                            break;
                        case 34:
                            PlayerClass.josekiArray = PlayerClass.USAGI;
                            break;
                        case 37:
                            PlayerClass.josekiArray = PlayerClass.USI;
                            break;
                        case 42:
                            PlayerClass.josekiArray = PlayerClass.USAGI;
                            break;
                        case 43:
                            PlayerClass.josekiArray = PlayerClass.USAGI;
                            break;
                        case 44:
                            PlayerClass.josekiArray = PlayerClass.USI;
                            break;
                        case 45:
                            PlayerClass.josekiArray = PlayerClass.USI;
                            break;
                    }

                }

                nextAddress = jouseki(PlayerClass.josekiArray, nowPlayer);
            }
            

            //もし配列が決まらなければ中級モードで
            if (nextAddress==-1) 
            {
                nextAddress = chukyu(arrayCount);

            }

            return nextAddress;

        }

    }
}
