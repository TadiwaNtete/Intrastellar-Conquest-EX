namespace ISCEXtest1
{
    partial class GamePage2
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
            this.mapSize = new System.Windows.Forms.Label();
            this.medium = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.StartGame = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.small = new System.Windows.Forms.Button();
            this.big = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapSize
            // 
            this.mapSize.AutoSize = true;
            this.mapSize.Font = new System.Drawing.Font("SimSun", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mapSize.ForeColor = System.Drawing.Color.Lime;
            this.mapSize.Location = new System.Drawing.Point(437, 61);
            this.mapSize.Name = "mapSize";
            this.mapSize.Size = new System.Drawing.Size(213, 35);
            this.mapSize.TabIndex = 2;
            this.mapSize.Text = "Size of Map";
            // 
            // medium
            // 
            this.medium.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.medium.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.medium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.medium.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.medium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.medium.Location = new System.Drawing.Point(437, 125);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(200, 74);
            this.medium.TabIndex = 3;
            this.medium.Text = "IntraStellar";
            this.medium.UseVisualStyleBackColor = false;
            this.medium.Click += new System.EventHandler(this.initializeButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.StartGame);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(437, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 128);
            this.panel3.TabIndex = 4;
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartGame.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartGame.ForeColor = System.Drawing.Color.Lime;
            this.StartGame.Location = new System.Drawing.Point(0, 27);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(200, 74);
            this.StartGame.TabIndex = 5;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 128);
            this.panel4.TabIndex = 6;
            // 
            // small
            // 
            this.small.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.small.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.small.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.small.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.small.ForeColor = System.Drawing.Color.Lime;
            this.small.Location = new System.Drawing.Point(219, 125);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(200, 74);
            this.small.TabIndex = 5;
            this.small.Text = "IntraPlanetary";
            this.small.UseVisualStyleBackColor = false;
            this.small.Click += new System.EventHandler(this.small_Click);
            // 
            // big
            // 
            this.big.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.big.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.big.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.big.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.big.ForeColor = System.Drawing.Color.Red;
            this.big.Location = new System.Drawing.Point(655, 125);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(200, 74);
            this.big.TabIndex = 6;
            this.big.Text = "IntraGalactic";
            this.big.UseVisualStyleBackColor = false;
            this.big.Click += new System.EventHandler(this.big_Click);
            // 
            // GamePage2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 1061);
            this.Controls.Add(this.big);
            this.Controls.Add(this.small);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.mapSize);
            this.Name = "GamePage2";
            this.Text = "GamePage2";
            this.Load += new System.EventHandler(this.GamePage2_Load);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label mapSize;
        private Button medium;
        private Panel panel3;
        private Button StartGame;
        private Panel panel4;
        private Button small;
        private Button big;
    }
}