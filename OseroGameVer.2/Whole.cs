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


//見やすいコードとは　=　変更しやすい。
//部品同士が依存関係にない
//構造化されている=構造があるということ。

namespace OseroGameVer._2
{
    public class Whole
    {

        //定数
        public int KARA
        {
            get { return 0; }
        }

        public int SHIRO
        {
            get { return 1; }
        }
        public int KURO
        {
            get { return 2; }
        }

        
        
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            SettingForm settingForm = new SettingForm();

            Application.Run(settingForm);
        }
    }
}
            
