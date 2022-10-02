
namespace OseroGameVer._2
{
    partial class doSettingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_SelectMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.chooseFirstOrSecond = new System.Windows.Forms.Label();
            this.cmb_firstOrSecond = new System.Windows.Forms.ComboBox();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(159, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "▼設定を選択してください";
            // 
            // cmb_SelectMode
            // 
            this.cmb_SelectMode.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_SelectMode.FormattingEnabled = true;
            this.cmb_SelectMode.Items.AddRange(new object[] {
            "",
            "接待モード",
            "初級モード",
            "中級モード",
            "上級モード"});
            this.cmb_SelectMode.Location = new System.Drawing.Point(360, 188);
            this.cmb_SelectMode.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_SelectMode.Name = "cmb_SelectMode";
            this.cmb_SelectMode.Size = new System.Drawing.Size(135, 30);
            this.cmb_SelectMode.TabIndex = 10;
            this.cmb_SelectMode.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(206, 196);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "モード";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_save.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_save.Location = new System.Drawing.Point(275, 295);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 52);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "はじめる";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // chooseFirstOrSecond
            // 
            this.chooseFirstOrSecond.AutoSize = true;
            this.chooseFirstOrSecond.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chooseFirstOrSecond.Location = new System.Drawing.Point(215, 139);
            this.chooseFirstOrSecond.Name = "chooseFirstOrSecond";
            this.chooseFirstOrSecond.Size = new System.Drawing.Size(102, 22);
            this.chooseFirstOrSecond.TabIndex = 7;
            this.chooseFirstOrSecond.Text = "先攻後攻";
            // 
            // cmb_firstOrSecond
            // 
            this.cmb_firstOrSecond.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_firstOrSecond.FormattingEnabled = true;
            this.cmb_firstOrSecond.Items.AddRange(new object[] {
            "         ",
            "先攻",
            "後攻"});
            this.cmb_firstOrSecond.Location = new System.Drawing.Point(360, 139);
            this.cmb_firstOrSecond.Name = "cmb_firstOrSecond";
            this.cmb_firstOrSecond.Size = new System.Drawing.Size(135, 30);
            this.cmb_firstOrSecond.TabIndex = 6;
            // 
            // cmb_size
            // 
            this.cmb_size.Enabled = false;
            this.cmb_size.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(360, 233);
            this.cmb_size.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(135, 30);
            this.cmb_size.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("BIZ UDP明朝 Medium", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(206, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "サイズ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(275, 385);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 22);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "テスト";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // doSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cmb_size);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_SelectMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.chooseFirstOrSecond);
            this.Controls.Add(this.cmb_firstOrSecond);
            this.Name = "doSettingForm";
            this.Text = "ようこそ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_SelectMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label chooseFirstOrSecond;
        private System.Windows.Forms.ComboBox cmb_firstOrSecond;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}