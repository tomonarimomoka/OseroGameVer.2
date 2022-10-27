using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OseroGameVer._2
{
    //class AIFforKikai
    //{
    //    //4角におけるか調べてくれる関数。置けるなら、おけるアドレスを、置けないなら-1が帰ってくる関数。
    //    public 　int CanPutCornerOrNot(Player nowPlayer)
    //    {
    //        int returnNumber = -1;

    //        int[] cornerArray = {
    //            0 ,
    //            Whole.SIZE - 1 ,
    //            AIForAll.coordinateAddress(0, Whole.SIZE - 1),
    //            Whole.SIZE * Whole.SIZE - 1
    //        };

    //        for (int i = 0; i < 4; i++)
    //        {
    //            if (AIForAll.allDirReturn(cornerArray[i], false, nowPlayer) > 0
    //                && Whole.boardIdentitiy[cornerArray[i]] == Whole.KARA) 
    //            {
    //                returnNumber = cornerArray[i];
    //                break;

    //            } 

    //        }
            
    //        return returnNumber;
    //    }


    //    //ひっくり返せる数をそれぞれのアドレスで調べて配列に入れる。その配列を返す関数。
    //    public  int[] searchNextKikaiBannti(Player nowPlayer)
    //    {
    //        int countReturnNumber = 0;
    //        int[] arrayPoint = new int[64];
    //        for (int i = 0; i < Whole.SIZE*Whole.SIZE; i++)
    //        {
    //            if (Whole.boardIdentitiy[i] == Whole.KARA)
    //            {
    //                countReturnNumber = AIForAll.allDirReturn(i, false, nowPlayer);                    
    //            }
    //            else
    //            {
    //                countReturnNumber = 0;
    //            }
    //            arrayPoint[i] = countReturnNumber;
    //        }


    //        return arrayPoint;
    //    }

        
    //    public  void putByAout(Player nowPlayer) 
    //    {
    //        int nextAddress = -1;
    //        //おけたら4角に置く。
    //        if (CanPutCornerOrNot(nowPlayer) == -1)
    //        {
    //            //接待
    //            if (nowPlayer.Mode == 1) 
    //            {
    //                nextAddress = KIAKIrandom(nowPlayer);
    //            }
    //            else
    //            {
    //                int[] arrayCount = searchNextKikaiBannti(nowPlayer);

    //                switch (nowPlayer.Mode)
    //                {

    //                    //syokyuu
    //                    case 2:
    //                        //一番多くひっくり返せる場所に置く。
    //                        nextAddress = Array.IndexOf(arrayCount, arrayCount.Max());
    //                        break;
    //                    //中級モード
    //                    case 3:
    //                        nextAddress = chukyu(arrayCount);
    //                        break;
    //                    case 4:
    //                        nextAddress = returnAddressByJOSEKI(nowPlayer,arrayCount);
    //                        break;
    //                }

    //            }
    //        }
    //        //置ける
    //        else
    //        {
    //            nextAddress = CanPutCornerOrNot(nowPlayer);
    //        }
    //        Whole.boardIdentitiy[nextAddress] = nowPlayer.Color;
    //        //9/26用回収
    //        AIForAll.allDirReturn(nextAddress, true, nowPlayer);

    //    }


    //    public  int KIAKIrandom(Player nowPlayer)
    //    {
    //        int blankCount = 0;
    //        int address = -1;
    //        int[] boardBlank = new int[Whole.SIZE*Whole.SIZE + 1];
    //        //ランダムで打つために空いているばんちを boardBlankに記録しておく。
    //        for (int i = 0; i < Whole.SIZE * Whole.SIZE; i++)
    //        {
    //            //iが空であるかつ、一つ以上ひっくり返せるアドレスを探す。
    //            if (Whole.boardIdentitiy[i] ==  Whole.KARA && AIForAll.allDirReturn(i,false, nowPlayer) > 0)
    //            {
    //                //アドレスを配列に保存
    //                boardBlank[blankCount] = i;
    //                blankCount++;
    //            }
    //        }

    //        if (blankCount > 0)
    //        {
    //            Random random = new Random();
    //            int randomvalue = random.Next(blankCount);
    //            address = boardBlank[randomvalue];
                
    //        }

    //        return address;


    //    }



    //    public  bool IsFilledSixtyPaesent() 
    //    {
    //        //6割埋まっていない場合
    //        if (AIForAll.countBlank() >= Whole.SIZE * Whole.SIZE * 0.6)
    //        {
    //            return true;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }

    //    //一番少なくひっくり返せるアドレスを調べる。
    //    public  int lowestAddress(int[] arrayCount) 
    //    {
    //        int address = -1;
    //        for (int i = 1; 1 < Whole.SIZE * 4; i++)
    //        {
    //            address = Array.IndexOf(arrayCount, i);
    //            if (address != -1) { break; }
    //        }
    //        return address;
    //    }


    //    //-------------------------------------------------------------------------------------
    //    //  中級モード
    //    //-------------------------------------------------------------------------------------
    //    public  int chukyu(int[] arrayCount) 
    //    {
    //        int nextAddress = -1;
    //        if (IsFilledSixtyPaesent())
    //        {
    //            //一番多くひっくり返せる場所に置く。
    //            nextAddress = Array.IndexOf(arrayCount, arrayCount.Max());
    //        }
    //        else
    //        {
    //            //一番少なくひっくり返せる場所に置く。
    //            nextAddress = lowestAddress(arrayCount);
    //        }

    //        return nextAddress;
    //    }

    //    //-------------------------------------------------------------------------------------
    //    //  定石モード
    //    //-------------------------------------------------------------------------------------
    //    //前から空いてる配列があればおく。
    //    //定石全部埋まってるか調べられる。埋まってたらtrue
    //    public  int jouseki(int[,] array,Player nowPlayer)
    //    {
    //        int candidateAddress = -1;
    //        //二次元配列なので、２で÷
    //        int arraySize = array.Length / 2;

    //        for (int i = 0; i < arraySize; i++)
    //        {
    //            candidateAddress = AIForAll.coordinateAddress(array[i, 0], array[i, 1]);

    //            //からかつひっくり返せたら置く。
    //            if (Whole.boardIdentitiy[candidateAddress] == Whole.KARA 
    //                && AIForAll.allDirReturn(candidateAddress, false, nowPlayer) > 0)
    //            {
    //                break;
    //            }

    //            //配列が終わってからのコードも
    //            if (i == arraySize - 1) 
    //            {
    //                candidateAddress = -1;
    //            }
                    
    //        }
    //        return candidateAddress;
    //    }

    //    //ここでどこに打つか決める
    //    private  int returnAddressByJOSEKI(Player nowPlayer,int[] arrayCount)
    //    {
    //        //残りの空いているアドレスを調べる
    //        int restAddress = Whole.SIZE * Whole.SIZE - 4 - AIForAll.countBlank();
    //        int nextAddress = -1;
    //        //残りの空いているアドレス
    //        if (restAddress == 0)
    //        {
    //            //i=0のときは、なんでもOK
    //            //もし人が後攻を選んだら初めは機械。
    //            //初めは5,4が無難らしい。
    //            nextAddress = AIForAll.coordinateAddress(5, 4);
    //        }
    //        //else if(restAddress == 1) 
    //        else 
    //        {
    //            if (Player.josekiArray == Player.INITIA) 
    //            {
    //                switch (Player.lastHumanAddress)
    //                {
    //                    case 18://先攻は置けない

    //                        break;
    //                    case 19:
    //                        Player.josekiArray = Player.NEZUM;
    //                        break;
    //                    case 20:
    //                        Player.josekiArray = Player.USI;
    //                        break;
    //                    case 21://先攻は置けない

    //                        break;
    //                    case 26:
    //                        break;
    //                    case 29:
    //                        Player.josekiArray = Player.USAGI;
    //                        break;
    //                    case 34:
    //                        Player.josekiArray = Player.USAGI;
    //                        break;
    //                    case 37:
    //                        Player.josekiArray = Player.USI;
    //                        break;
    //                    case 42:
    //                        Player.josekiArray = Player.USAGI;
    //                        break;
    //                    case 43:
    //                        Player.josekiArray = Player.USAGI;
    //                        break;
    //                    case 44:
    //                        Player.josekiArray = Player.USI;
    //                        break;
    //                    case 45:
    //                        Player.josekiArray = Player.USI;
    //                        break;
    //                }

    //            }

    //            nextAddress = jouseki(Player.josekiArray, nowPlayer);
    //        }
            

    //        //もし配列が決まらなければ中級モードで
    //        if (nextAddress==-1) 
    //        {
    //            nextAddress = chukyu(arrayCount);

    //        }

    //        return nextAddress;

    //    }

    //}
}
