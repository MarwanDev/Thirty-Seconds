namespace ThirtySeconds
{
    partial class AddTeamForm
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
            this.btnGo = new System.Windows.Forms.Button();
            this.tbTeamName = new System.Windows.Forms.TextBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.fdImage = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowseImg = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.ForeColor = System.Drawing.Color.White;
            this.btnGo.Location = new System.Drawing.Point(93, 211);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(122, 52);
            this.btnGo.TabIndex = 35;
            this.btnGo.Text = "Go >";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbTeamName
            // 
            this.tbTeamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTeamName.Location = new System.Drawing.Point(26, 75);
            this.tbTeamName.MaxLength = 100;
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.Size = new System.Drawing.Size(250, 31);
            this.tbTeamName.TabIndex = 36;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTeam.Location = new System.Drawing.Point(22, 41);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(150, 21);
            this.lblTeam.TabIndex = 37;
            this.lblTeam.Text = "First Team Name";
            // 
            // fdImage
            // 
            this.fdImage.FileName = "openFileDialog1";
            this.fdImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // btnBrowseImg
            // 
            this.btnBrowseImg.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBrowseImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseImg.ForeColor = System.Drawing.Color.White;
            this.btnBrowseImg.Location = new System.Drawing.Point(370, 75);
            this.btnBrowseImg.Name = "btnBrowseImg";
            this.btnBrowseImg.Size = new System.Drawing.Size(196, 36);
            this.btnBrowseImg.TabIndex = 38;
            this.btnBrowseImg.Text = "Browse Image";
            this.btnBrowseImg.UseVisualStyleBackColor = false;
            this.btnBrowseImg.Click += new System.EventHandler(this.btnBrowseImg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ThirtySeconds.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(395, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrowseImg);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.tbTeamName);
            this.Controls.Add(this.btnGo);
            this.Name = "AddTeamForm";
            this.Text = "Add Team";
            this.Load += new System.EventHandler(this.AddTeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbTeamName;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.OpenFileDialog fdImage;
        private System.Windows.Forms.Button btnBrowseImg;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}