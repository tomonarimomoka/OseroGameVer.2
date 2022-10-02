using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OseroGameVer._2
{
    class AIForAll
    {
		//あとからmainClassに移植する
		//public static int SIZE = 8;

		//6/7の私の意見です
		//先攻は黒、後攻は白にする。
		//今、白か黒かで、判定しよう。



		//x,yからアドレスを返す
		public static int coordinateAddress(int x, int y)
		{
			int address = x + y * (mainClass.SIZE);
			return address;
		}

		//addressからX,Yを吐き出す。
		//二つ目の引数にｘ、ｙどちらを返してほしいか入れて使う。
		public static int getXorY(int address,string XorY)
		{
			int x = 0;
			int y = 0;
			for (int i = 0; i < mainClass.SIZE; i++)
			{
				if (0 <= address && address <= (mainClass.SIZE-1))
				{
					x = address;
					y = i;
					break;
				}
				address -= mainClass.SIZE;
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
		public static int howManyReturn(int dirX, int dirY, int address, bool returnFlag,PlayerClass nowPlayer)
		{
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
				if (x < 0 || mainClass.SIZE - 1 < x) { break; }
				if (y < 0 || mainClass.SIZE - 1 < y) { break; }
				//Addressを作成
				tempAddress = coordinateAddress(x, y);

				//空なら抜ける
				if (mainClass.boardIdentitiy[tempAddress] == mainClass.KARA)
				{
					break;
				}
				//自身の色ならひっくり返す
				//そして、ループ抜ける
				else if (mainClass.boardIdentitiy[tempAddress] == nowPlayer.Color)
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
						mainClass.boardIdentitiy[tempAddress] = nowPlayer.Color;
					}
				}
			}

			return count;
		}

		//すべての方向数えてひっくり返す関数。
		//数えることもできる
		public static int allDirReturn(int address,bool returnFlag, PlayerClass nowPlayer)
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
		public static int countBlank()
        {
			int count = 0;
			for (int i = 0; i < mainClass.SIZE * mainClass.SIZE; i++)
			{
				if (mainClass.boardIdentitiy[i] == mainClass.KARA)
				{
					count++;
				}
			}

			return count;
		}


	}
}
