using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OseroGameVer._2
{
    class Algorithm
    {
        int SIZE;
        int[] boardIdentitiy;
        //あとからmainClassに移植する
        //public  int SIZE = 8;

        //6/7の私の意見です
        //先攻は黒、後攻は白にする。
        //今、白か黒かで、判定しよう。
        public Algorithm(int size, int[] board)
        {
            SIZE = size;
            boardIdentitiy = board;
        }


        //x,yからアドレスを返す
        public  int coordinateAddress(int x, int y)
		{
			int address = x + y * (SIZE);
			return address;
		}

		//addressからX,Yを吐き出す。
		//二つ目の引数にｘ、ｙどちらを返してほしいか入れて使う。
		public  int getXorY(int address,string XorY)
		{
			int x = 0;
			int y = 0;
			for (int i = 0; i < SIZE; i++)
			{
				if (0 <= address && address <= (SIZE-1))
				{
					x = address;
					y = i;
					break;
				}
				address -= SIZE;
			}

			if(XorY == "x")
            {
				return x;

			}
			else 
            {
				return y;

			}
		}


		//①何個ひっくり返せるか調べる
		//②4つ目の引数にtrueを入れると保存までできる。falseなら保存はしない。
		public  int howManyReturn(int dirX, int dirY, int address, bool returnFlag,Player nowPlayer)
		{
            Whole whole = new Whole();
            bool flagNotReturn = true;
			int count = 0;
			int x = getXorY(address, "x");
			int y = getXorY(address, "y");
			//実際にひっくり返す時のため、操作前のaddressを保存しておく
			//int orignAddress = address;
			int tempAddress = address;

			for (int i = 0; i < 7; i++)
			{
				x = x + dirX;
				y = y + dirY;
				if (x < 0 || SIZE - 1 < x) { break; }
				if (y < 0 || SIZE - 1 < y) { break; }
				//Addressを作成
				tempAddress = coordinateAddress(x, y);

				//空なら抜ける
				if (boardIdentitiy[tempAddress] == whole.KARA)
				{
					break;
				}
				//自身の色ならひっくり返す
				//そして、ループ抜ける
				else if (boardIdentitiy[tempAddress] == nowPlayer.Color)
				{
					flagNotReturn = false;
					break;
				}
				//自身の色でなく、空でもないなら、countに＋
                else
                {
					count++;
				}
			}

			//もし、挟めていなかったら、ひっくり返さない。
			if (flagNotReturn == true)
			{
				count = 0;
			}
			else 
			{
				if (returnFlag)
				{
					x = getXorY(address, "x");
					y = getXorY(address, "y");
					
					for (int i = 0; i <= count; i++)
					{
						x += dirX;
						y += + dirY;
						tempAddress = coordinateAddress(x, y);
						boardIdentitiy[tempAddress] = nowPlayer.Color;
					}
				}
			}

			return count;
		}

		//すべての方向数えてひっくり返す関数。
		//数えることもできる
		public  int allDirReturn(int address,bool returnFlag, Player nowPlayer)
		{
			int count = 0;
			for (int x = -1; x <= 1; x++)
			{
				for (int y = -1; y <= 1; y++)
				{
					if (!(x == 0 && y == 0))
					{
						count += howManyReturn(x, y, address, returnFlag, nowPlayer);
					}
				}

			}
			return count;
		}

	

		//いくつ空があるかしらべる関数
		public  int countBlank()
        {
            Whole whole = new Whole();
            int count = 0;
			for (int i = 0; i < SIZE * SIZE; i++)
			{
				if (boardIdentitiy[i] == whole.KARA)
				{
					count++;
				}
			}

			return count;
		}

        public int CanPutCornerOrNot(Player nowPlayer)
        {
            Whole whole = new Whole();
            int returnNumber = -1;

            int[] cornerArray = {
                0 ,
                SIZE - 1 ,
                coordinateAddress(0, SIZE - 1),
                SIZE * SIZE - 1
            };

            for (int i = 0; i < 4; i++)
            {
                if (allDirReturn(cornerArray[i], false, nowPlayer) > 0
                    && boardIdentitiy[cornerArray[i]] == whole.KARA)
                {
                    returnNumber = cornerArray[i];
                    break;

                }

            }

            return returnNumber;
        }


        //ひっくり返せる数をそれぞれのアドレスで調べて配列に入れる。その配列を返す関数。
        public int[] searchNextKikaiBannti(Player nowPlayer)
        {
            Whole whole = new Whole();

            int countReturnNumber = 0;
            int[] arrayPoint = new int[64];
            for (int i = 0; i < SIZE * SIZE; i++)
            {
                if (boardIdentitiy[i] == whole.KARA)
                {
                    countReturnNumber = allDirReturn(i, false, nowPlayer);
                }
                else
                {
                    countReturnNumber = 0;
                }
                arrayPoint[i] = countReturnNumber;
            }


            return arrayPoint;
        }


        public void putByAout(Player nowPlayer)
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
                            nextAddress = returnAddressByJOSEKI(nowPlayer, arrayCount);
                            break;
                    }

                }
            }
            //置ける
            else
            {
                nextAddress = CanPutCornerOrNot(nowPlayer);
            }
            boardIdentitiy[nextAddress] = nowPlayer.Color;
            //9/26用回収
            allDirReturn(nextAddress, true, nowPlayer);

        }


        public int KIAKIrandom(Player nowPlayer)
        {
            Whole whole = new Whole();
            int blankCount = 0;
            int address = -1;
            int[] boardBlank = new int[SIZE * SIZE + 1];
            //ランダムで打つために空いているばんちを boardBlankに記録しておく。
            for (int i = 0; i < SIZE * SIZE; i++)
            {
                //iが空であるかつ、一つ以上ひっくり返せるアドレスを探す。
                if (boardIdentitiy[i] == whole.KARA && allDirReturn(i, false, nowPlayer) > 0)
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



        public bool IsFilledSixtyPaesent()
        {
            //6割埋まっていない場合
            if (countBlank() >= SIZE * SIZE * 0.6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //一番少なくひっくり返せるアドレスを調べる。
        public int lowestAddress(int[] arrayCount)
        {
            int address = -1;
            for (int i = 1; 1 < SIZE * 4; i++)
            {
                address = Array.IndexOf(arrayCount, i);
                if (address != -1) { break; }
            }
            return address;
        }


        //-------------------------------------------------------------------------------------
        //  中級モード
        //-------------------------------------------------------------------------------------
        public int chukyu(int[] arrayCount)
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
        public int jouseki(int[,] array, Player nowPlayer)
        {
            Whole whole = new Whole();
            int candidateAddress = -1;
            //二次元配列なので、２で÷
            int arraySize = array.Length / 2;

            for (int i = 0; i < arraySize; i++)
            {
                candidateAddress = coordinateAddress(array[i, 0], array[i, 1]);

                //からかつひっくり返せたら置く。
                if (boardIdentitiy[candidateAddress] == whole.KARA
                    && allDirReturn(candidateAddress, false, nowPlayer) > 0)
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
        private int returnAddressByJOSEKI(Player nowPlayer, int[] arrayCount)
        {
            //残りの空いているアドレスを調べる
            int restAddress = SIZE * SIZE - 4 - countBlank();
            int nextAddress = -1;
            //残りの空いているアドレス
            if (restAddress == 0)
            {
                //i=0のときは、なんでもOK
                //もし人が後攻を選んだら初めは機械。
                //初めは5,4が無難らしい。
                nextAddress = coordinateAddress(5, 4);
            }
            //else if(restAddress == 1) 
            else
            {
                if (nowPlayer.josekiArray == null)
                //    if (nowPlayer.josekiArray == nowPlayer.INITIA)
                {
                    switch (nowPlayer.LastHumanAddress)
                    {
                        case 18://先攻は置けない

                            break;
                        case 19:
                            nowPlayer.josekiArray = nowPlayer.NEZUM;
                            break;
                        case 20:
                            nowPlayer.josekiArray = nowPlayer.USI;
                            break;
                        case 21://先攻は置けない

                            break;
                        case 26:
                            break;
                        case 29:
                            nowPlayer.josekiArray = nowPlayer.USAGI;
                            break;
                        case 34:
                            nowPlayer.josekiArray = nowPlayer.USAGI;
                            break;
                        case 37:
                            nowPlayer.josekiArray = nowPlayer.USI;
                            break;
                        case 42:
                            nowPlayer.josekiArray = nowPlayer.USAGI;
                            break;
                        case 43:
                            nowPlayer.josekiArray = nowPlayer.USAGI;
                            break;
                        case 44:
                            nowPlayer.josekiArray = nowPlayer.USI;
                            break;
                        case 45:
                            nowPlayer.josekiArray = nowPlayer.USI;
                            break;
                    }

                }

                nextAddress = jouseki(nowPlayer.josekiArray, nowPlayer);
            }


            //もし配列が決まらなければ中級モードで
            if (nextAddress == -1)
            {
                nextAddress = chukyu(arrayCount);

            }

            return nextAddress;

        }

    }


}

