
namespace OseroGameVer._2
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.cmb_SelectMode = new System.Windows.Forms.ComboBox();
            this.radio_btn_first = new System.Windows.Forms.RadioButton();
            this.radio_btn_second = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.settai = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_settai = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_first = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_middle = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_difficlt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.settai.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(135, 303);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(177, 54);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 592);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 44);
            this.label3.TabIndex = 12;
            this.label3.Text = "サイズ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 532);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "モード";
            // 
            // cmb_size
            // 
            this.cmb_size.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(227, 592);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(191, 39);
            this.cmb_size.TabIndex = 9;
            this.cmb_size.SelectedIndexChanged += new System.EventHandler(this.cmb_size_SelectedIndexChanged);
            // 
            // cmb_SelectMode
            // 
            this.cmb_SelectMode.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SelectMode.FormattingEnabled = true;
            this.cmb_SelectMode.Items.AddRange(new object[] {
            "",
            "接待モード",
            "初級モード",
            "中級モード",
            "上級モード"});
            this.cmb_SelectMode.Location = new System.Drawing.Point(227, 532);
            this.cmb_SelectMode.Name = "cmb_SelectMode";
            this.cmb_SelectMode.Size = new System.Drawing.Size(191, 39);
            this.cmb_SelectMode.TabIndex = 8;
            // 
            // radio_btn_first
            // 
            this.radio_btn_first.AutoSize = true;
            this.radio_btn_first.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radio_btn_first.Location = new System.Drawing.Point(54, 19);
            this.radio_btn_first.Name = "radio_btn_first";
            this.radio_btn_first.Size = new System.Drawing.Size(104, 37);
            this.radio_btn_first.TabIndex = 14;
            this.radio_btn_first.TabStop = true;
            this.radio_btn_first.Text = "先攻";
            this.radio_btn_first.UseVisualStyleBackColor = true;
            this.radio_btn_first.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radio_btn_second
            // 
            this.radio_btn_second.AutoSize = true;
            this.radio_btn_second.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radio_btn_second.Location = new System.Drawing.Point(280, 19);
            this.radio_btn_second.Name = "radio_btn_second";
            this.radio_btn_second.Size = new System.Drawing.Size(104, 37);
            this.radio_btn_second.TabIndex = 15;
            this.radio_btn_second.TabStop = true;
            this.radio_btn_second.Text = "後攻";
            this.radio_btn_second.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.settai);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 215);
            this.tabControl1.TabIndex = 16;
            // 
            // settai
            // 
            this.settai.Controls.Add(this.label1);
            this.settai.Controls.Add(this.cmb_settai);
            this.settai.Location = new System.Drawing.Point(4, 30);
            this.settai.Name = "settai";
            this.settai.Padding = new System.Windows.Forms.Padding(3);
            this.settai.Size = new System.Drawing.Size(470, 181);
            this.settai.TabIndex = 0;
            this.settai.Text = "接待モード";
            this.settai.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 44);
            this.label1.TabIndex = 18;
            this.label1.Text = "サイズ";
            // 
            // cmb_settai
            // 
            this.cmb_settai.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_settai.FormattingEnabled = true;
            this.cmb_settai.Items.AddRange(new object[] {
            "",
            "\"4×4\"",
            "\"5×5\"",
            "\"6×6\"",
            "\"7×7\"",
            "\"8×8\" "});
            this.cmb_settai.Location = new System.Drawing.Point(186, 32);
            this.cmb_settai.Name = "cmb_settai";
            this.cmb_settai.Size = new System.Drawing.Size(191, 39);
            this.cmb_settai.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmb_first);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(424, 183);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "初級モード";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 44);
            this.label4.TabIndex = 21;
            this.label4.Text = "サイズ";
            // 
            // cmb_first
            // 
            this.cmb_first.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_first.FormattingEnabled = true;
            this.cmb_first.Items.AddRange(new object[] {
            "",
            "\"4×4\"",
            "\"5×5\"",
            "\"6×6\"",
            "\"7×7\"",
            "\"8×8\" "});
            this.cmb_first.Location = new System.Drawing.Point(196, 27);
            this.cmb_first.Name = "cmb_first";
            this.cmb_first.Size = new System.Drawing.Size(191, 39);
            this.cmb_first.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cmb_middle);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 183);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "中級モード";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 44);
            this.label5.TabIndex = 21;
            this.label5.Text = "サイズ";
            // 
            // cmb_middle
            // 
            this.cmb_middle.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_middle.FormattingEnabled = true;
            this.cmb_middle.Items.AddRange(new object[] {
            "",
            "\"4×4\"",
            "\"5×5\"",
            "\"6×6\"",
            "\"7×7\"",
            "\"8×8\" "});
            this.cmb_middle.Location = new System.Drawing.Point(201, 32);
            this.cmb_middle.Name = "cmb_middle";
            this.cmb_middle.Size = new System.Drawing.Size(191, 39);
            this.cmb_middle.TabIndex = 20;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.cmb_difficlt);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(424, 183);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "上級モード";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 44);
            this.label6.TabIndex = 21;
            this.label6.Text = "サイズ";
            // 
            // cmb_difficlt
            // 
            this.cmb_difficlt.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_difficlt.FormattingEnabled = true;
            this.cmb_difficlt.Items.AddRange(new object[] {
            "８×８"});
            this.cmb_difficlt.Location = new System.Drawing.Point(201, 28);
            this.cmb_difficlt.Name = "cmb_difficlt";
            this.cmb_difficlt.Size = new System.Drawing.Size(191, 39);
            this.cmb_difficlt.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(384, 44);
            this.label7.TabIndex = 22;
            this.label7.Text = "※上級モードは8×8しか選べません。";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 368);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.radio_btn_second);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.radio_btn_first);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_size);
            this.Controls.Add(this.cmb_SelectMode);
            this.Name = "SettingForm";
            this.Text = "ゲーム設定";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.settai.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.ComboBox cmb_SelectMode;
        private System.Windows.Forms.RadioButton radio_btn_first;
        private System.Windows.Forms.RadioButton radio_btn_second;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage settai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_settai;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_first;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_middle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_difficlt;
        private System.Windows.Forms.Label label7;
    }
}