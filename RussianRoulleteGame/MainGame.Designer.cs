namespace RussianRoulleteGame
{
    partial class MainGame
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
            this.war = new System.Windows.Forms.PictureBox();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.shootAwayBtn = new System.Windows.Forms.Button();
            this.shootBtn = new System.Windows.Forms.Button();
            this.spinBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.war)).BeginInit();
            this.SuspendLayout();
            // 
            // war
            // 
            this.war.Image = global::RussianRoulleteGame.Properties.Resources.war;
            this.war.Location = new System.Drawing.Point(133, 12);
            this.war.Name = "war";
            this.war.Size = new System.Drawing.Size(456, 309);
            this.war.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.war.TabIndex = 0;
            this.war.TabStop = false;
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.BackColor = System.Drawing.Color.Olive;
            this.playAgainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playAgainBtn.Location = new System.Drawing.Point(530, 359);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(116, 49);
            this.playAgainBtn.TabIndex = 11;
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = false;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // shootAwayBtn
            // 
            this.shootAwayBtn.BackColor = System.Drawing.Color.Olive;
            this.shootAwayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootAwayBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shootAwayBtn.Location = new System.Drawing.Point(392, 359);
            this.shootAwayBtn.Name = "shootAwayBtn";
            this.shootAwayBtn.Size = new System.Drawing.Size(116, 49);
            this.shootAwayBtn.TabIndex = 10;
            this.shootAwayBtn.Text = "Shoot Away";
            this.shootAwayBtn.UseVisualStyleBackColor = false;
            this.shootAwayBtn.Click += new System.EventHandler(this.shootAwayBtn_Click);
            // 
            // shootBtn
            // 
            this.shootBtn.BackColor = System.Drawing.Color.Olive;
            this.shootBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.shootBtn.Location = new System.Drawing.Point(248, 359);
            this.shootBtn.Name = "shootBtn";
            this.shootBtn.Size = new System.Drawing.Size(116, 49);
            this.shootBtn.TabIndex = 9;
            this.shootBtn.Text = "Shoot";
            this.shootBtn.UseVisualStyleBackColor = false;
            this.shootBtn.Click += new System.EventHandler(this.shootBtn_Click);
            // 
            // spinBtn
            // 
            this.spinBtn.BackColor = System.Drawing.Color.Olive;
            this.spinBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.spinBtn.Location = new System.Drawing.Point(122, 359);
            this.spinBtn.Name = "spinBtn";
            this.spinBtn.Size = new System.Drawing.Size(104, 49);
            this.spinBtn.TabIndex = 8;
            this.spinBtn.Text = "Spin";
            this.spinBtn.UseVisualStyleBackColor = false;
            this.spinBtn.Click += new System.EventHandler(this.spinBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.Olive;
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loadBtn.Location = new System.Drawing.Point(12, 359);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(104, 49);
            this.loadBtn.TabIndex = 7;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(701, 439);
            this.Controls.Add(this.playAgainBtn);
            this.Controls.Add(this.shootAwayBtn);
            this.Controls.Add(this.shootBtn);
            this.Controls.Add(this.spinBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.war);
            this.Name = "MainGame";
            this.Text = "Main Game";
            ((System.ComponentModel.ISupportInitialize)(this.war)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox war;
        private System.Windows.Forms.Button playAgainBtn;
        private System.Windows.Forms.Button shootAwayBtn;
        private System.Windows.Forms.Button shootBtn;
        private System.Windows.Forms.Button spinBtn;
        private System.Windows.Forms.Button loadBtn;
    }
}