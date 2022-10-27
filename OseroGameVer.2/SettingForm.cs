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
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        public int size = 8;
        int mood = -1;


        //private void btn_save_Click(object sender, EventArgs e)
        //{
            

        //    private void cmb_SelectMode_SelectedIndexChanged(object sender, EventArgs e)
        //    {
        //        List<string> modeList = new List<string>() { "4×4", "5×5", "6×6", "7×7", "8×8" };

        //        switch (cmb_SelectMode.SelectedIndex)
        //        {
        //            case 1:
        //                mood = 1;
        //                break;
        //            case 2:
        //                mood = 2;
        //                break;
        //            case 3:
        //                mood = 3;
        //                break;
        //            case 4:
        //                mood = 4;
        //                modeList.RemoveRange(0, 4);
        //                //cmb_size.Items.AddRange( "8×8");
        //                break;
        //        }

        //        cmb_size.Items.Clear();
        //        cmb_size.Items.AddRange(modeList.ToArray());
        //        cmb_size.Enabled = true;

        //    }

        //private Button btn_save;

        private void btn_save_Click_1(object sender, EventArgs e)
        {
            //初期値として人が先行
            bool humanIsFirst = true;

            //先攻なら、
            if (this.cmb_firstOrSecond.SelectedIndex == 1)
            {
                humanIsFirst = true;


            }
            else if (this.cmb_firstOrSecond.SelectedIndex == 2)
            {
                humanIsFirst = false;

            }


            //サイズ
            if (cmb_size.SelectedItem == "8×8")
            {
                size = 8;
            }
            else
            {
                if (mood == 4)
                {
                    DialogResult result = MessageBox.Show("定石モードは８×８のみでPlayできます。\n サイズを８×８にしますか？", "確認", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        size = 8;
                    }
                    else
                    {
                        size = 0;
                    }

                }
                else
                {
                    switch (cmb_size.SelectedIndex)
                    {

                        case 0:
                            size = 4;
                            break;
                        case 1:
                            size = 5;
                            break;
                        case 2:
                            size = 6;
                            break;
                        case 3:
                            size = 7;
                            break;
                            //case 4:
                            //    mainClass.size = 7;
                            //    break;

                    }
                }

            }


            if (mood == -1)
            {
                mood = this.cmb_SelectMode.SelectedIndex;
                //MessageBox.Show("モードを選択してください。", "確認", MessageBoxButtons.OK);
            }

            //BaseBoardForm board = new BaseBoardForm();
            //board.refleshUI(nowPlayer, mainboard);
            //Player.josekiArray = Player.INITIA;

            BaseBoardForm baseForm = new BaseBoardForm(size, humanIsFirst, mood);


            //設定画面みえなくする
            this.Visible = false;
            //ゲーム画面表示
            baseForm.ShowDialog();


            //設定画面終わり
            this.Close();

        }

        private void SettingForm_Load(object sender, EventArgs e)
        {

        }



        private void cmb_SelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_SelectMode_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<string> modeList = new List<string>() {  "4×4", "5×5", "6×6", "7×7", "8×8" };

            switch (cmb_SelectMode.SelectedIndex)
            {
                case 1:
                    size = 1;
                    break;
                case 2:
                    size = 2;
                    break;
                case 3:
                    size = 3;
                    break;
                case 4:
                    size = 4;
                    //modeList.Count()
                    modeList.RemoveRange(0, modeList.Count()-1);
                    //cmb_size.Items.AddRange( "8×8");
                    break;
            }

            cmb_size.Items.Clear();
            cmb_size.Items.AddRange(modeList.ToArray());
            cmb_size.Enabled = true;
        }
    }

    
}
