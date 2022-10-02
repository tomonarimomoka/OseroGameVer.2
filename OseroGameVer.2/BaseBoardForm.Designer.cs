
namespace OseroGameVer._2
{
    partial class BaseBoardForm
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
            this.pic_Board = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.label_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Board)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Board
            // 
            this.pic_Board.BackColor = System.Drawing.Color.ForestGreen;
            this.pic_Board.Location = new System.Drawing.Point(12, 8);
            this.pic_Board.Name = "pic_Board";
            this.pic_Board.Size = new System.Drawing.Size(800, 790);
            this.pic_Board.TabIndex = 0;
            this.pic_Board.TabStop = false;
            this.pic_Board.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Board_Paint);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(25, 846);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(64, 25);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn_save.Location = new System.Drawing.Point(103, 825);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 60);
            this.btn_save.TabIndex = 195;
            this.btn_save.Text = "決定";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("MS UI Gothic", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_info.Location = new System.Drawing.Point(318, 825);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(92, 56);
            this.label_info.TabIndex = 196;
            this.label_info.Text = "    ";
            // 
            // BaseBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 1175);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.pic_Board);
            this.Location = new System.Drawing.Point(1000, 0);
            this.Name = "BaseBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Osero";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAddress;
        public System.Windows.Forms.PictureBox pic_Board;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Label label_info;
    }
}