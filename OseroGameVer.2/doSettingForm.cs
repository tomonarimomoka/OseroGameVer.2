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
    public partial class doSettingForm : Form
    {
        public doSettingForm()
        {
            InitializeComponent();
        }
        
        private void btn_save_Click(object sender, EventArgs e)
        {
            //先攻なら、
            if(this.cmb_firstOrSecond.SelectedIndex == 1)
            {
                PlayerClass.humanIsFirst = true;
                mainClass.player1.playerType = PlayerClass.MANUAL;
                mainClass.player2.playerType = PlayerClass.AUTO;

            }
            else if(this.cmb_firstOrSecond.SelectedIndex == 2)
            {
                PlayerClass.humanIsFirst = false;
                mainClass.player1.playerType = PlayerClass.AUTO;
                mainClass.player2.playerType = PlayerClass.MANUAL;
            }

            



            //サイズ
            
            if (cmb_size.SelectedItem == "8×8")
            {
                mainClass.SIZE = 8;
            }
            else 
            {
                if (PlayerClass.mode == 4)
                {
                    DialogResult result = MessageBox.Show( "定石モードは８×８のみでPlayできます。\n サイズを８×８にしますか？","確認", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        mainClass.SIZE = 8;
                    }
                    else 
                    {
                        mainClass.SIZE = 0;
                    }

                }
                switch (cmb_size.SelectedIndex)
                {
                    
                    case 1:
                        mainClass.SIZE = 3;
                        break;
                    case 2:
                        mainClass.SIZE = 4;
                        break;
                    case 3:
                        mainClass.SIZE = 5;
                        break;
                    case 4:
                        mainClass.SIZE = 6;
                        break;
                    case 5:
                        mainClass.SIZE = 7;
                        break;
                    
                }

            }


            if (PlayerClass.mode == -1)
            {
                PlayerClass.mode = this.cmb_SelectMode.SelectedIndex;
                //MessageBox.Show("モードを選択してください。", "確認", MessageBoxButtons.OK);
            }
           
            
            this.Close();
                
        }

        //TEST
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PlayerClass.humanIsFirst = true;
            mainClass.SIZE = 8;
            PlayerClass.mode = 4;
        }

        private void cmb_SelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> modeList = new List<string>() { "3×3", "4×4", "5×5", "6×6", "7×7", "8×8" };

            switch (cmb_SelectMode.SelectedIndex)
            {
                case 1:
                    PlayerClass.mode = 1;
                    break;
                case 2:
                    PlayerClass.mode = 2;
                    break;
                case 3:
                    PlayerClass.mode = 3;
                    break;
                case 4:
                    PlayerClass.mode = 4;
                    modeList.RemoveRange(0,5);
                    //cmb_size.Items.AddRange( "8×8");
                    break;
            }

            cmb_size.Items.Clear();
            cmb_size.Items.AddRange(modeList.ToArray());
            cmb_size.Enabled = true;
        }
    }
}
