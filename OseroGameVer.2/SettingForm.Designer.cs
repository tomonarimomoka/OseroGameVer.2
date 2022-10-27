
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_size = new System.Windows.Forms.ComboBox();
            this.cmb_SelectMode = new System.Windows.Forms.ComboBox();
            this.cmb_firstOrSecond = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(136, 160);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(106, 36);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "サイズ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "モード";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "先攻OR後攻";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_size
            // 
            this.cmb_size.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_size.FormattingEnabled = true;
            this.cmb_size.Location = new System.Drawing.Point(136, 109);
            this.cmb_size.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_size.Name = "cmb_size";
            this.cmb_size.Size = new System.Drawing.Size(116, 29);
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
            this.cmb_SelectMode.Location = new System.Drawing.Point(136, 69);
            this.cmb_SelectMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_SelectMode.Name = "cmb_SelectMode";
            this.cmb_SelectMode.Size = new System.Drawing.Size(116, 29);
            this.cmb_SelectMode.TabIndex = 8;
            this.cmb_SelectMode.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectMode_SelectedIndexChanged_1);
            // 
            // cmb_firstOrSecond
            // 
            this.cmb_firstOrSecond.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_firstOrSecond.FormattingEnabled = true;
            this.cmb_firstOrSecond.Items.AddRange(new object[] {
            "",
            "先攻",
            "後攻"});
            this.cmb_firstOrSecond.Location = new System.Drawing.Point(136, 21);
            this.cmb_firstOrSecond.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_firstOrSecond.Name = "cmb_firstOrSecond";
            this.cmb_firstOrSecond.Size = new System.Drawing.Size(116, 29);
            this.cmb_firstOrSecond.TabIndex = 7;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 236);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_size);
            this.Controls.Add(this.cmb_SelectMode);
            this.Controls.Add(this.cmb_firstOrSecond);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingForm";
            this.Text = "ゲーム設定";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_size;
        private System.Windows.Forms.ComboBox cmb_SelectMode;
        private System.Windows.Forms.ComboBox cmb_firstOrSecond;
    }
}