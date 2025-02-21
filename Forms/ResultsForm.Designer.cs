namespace ThirtySeconds
{
    partial class ResultsForm
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
            this.lblTeam2 = new System.Windows.Forms.Label();
            this.lblTeam1 = new System.Windows.Forms.Label();
            this.lblFinalResult = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.pbTeam2 = new System.Windows.Forms.PictureBox();
            this.pbTeam1 = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeam2
            // 
            this.lblTeam2.AutoSize = true;
            this.lblTeam2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTeam2.Location = new System.Drawing.Point(647, 148);
            this.lblTeam2.Name = "lblTeam2";
            this.lblTeam2.Size = new System.Drawing.Size(67, 21);
            this.lblTeam2.TabIndex = 2;
            this.lblTeam2.Text = "Team2";
            // 
            // lblTeam1
            // 
            this.lblTeam1.AutoSize = true;
            this.lblTeam1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblTeam1.Location = new System.Drawing.Point(100, 148);
            this.lblTeam1.Name = "lblTeam1";
            this.lblTeam1.Size = new System.Drawing.Size(67, 21);
            this.lblTeam1.TabIndex = 3;
            this.lblTeam1.Text = "Team1";
            // 
            // lblFinalResult
            // 
            this.lblFinalResult.AutoSize = true;
            this.lblFinalResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalResult.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblFinalResult.Location = new System.Drawing.Point(320, 574);
            this.lblFinalResult.Name = "lblFinalResult";
            this.lblFinalResult.Size = new System.Drawing.Size(189, 25);
            this.lblFinalResult.TabIndex = 4;
            this.lblFinalResult.Text = "Winner: saasve 🎉";
            this.lblFinalResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblSummary.Location = new System.Drawing.Point(81, 216);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(100, 30);
            this.lblSummary.TabIndex = 5;
            this.lblSummary.Text = "Results";
            // 
            // pbTeam2
            // 
            this.pbTeam2.Location = new System.Drawing.Point(620, 29);
            this.pbTeam2.Name = "pbTeam2";
            this.pbTeam2.Size = new System.Drawing.Size(120, 100);
            this.pbTeam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTeam2.TabIndex = 1;
            this.pbTeam2.TabStop = false;
            // 
            // pbTeam1
            // 
            this.pbTeam1.Location = new System.Drawing.Point(73, 29);
            this.pbTeam1.Name = "pbTeam1";
            this.pbTeam1.Size = new System.Drawing.Size(120, 100);
            this.pbTeam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTeam1.TabIndex = 0;
            this.pbTeam1.TabStop = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.Color.White;
            this.btnPlayAgain.Location = new System.Drawing.Point(323, 655);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(176, 52);
            this.btnPlayAgain.TabIndex = 32;
            this.btnPlayAgain.Text = "Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.BtnPlayAgain_Click);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 721);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.lblFinalResult);
            this.Controls.Add(this.lblTeam1);
            this.Controls.Add(this.lblTeam2);
            this.Controls.Add(this.pbTeam2);
            this.Controls.Add(this.pbTeam1);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeam1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTeam1;
        private System.Windows.Forms.PictureBox pbTeam2;
        private System.Windows.Forms.Label lblTeam2;
        private System.Windows.Forms.Label lblTeam1;
        private System.Windows.Forms.Label lblFinalResult;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}