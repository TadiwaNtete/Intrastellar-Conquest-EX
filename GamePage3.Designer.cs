namespace ISCEXtest1
{
    partial class GamePage3
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
            this.AddShip = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AddShip
            // 
            this.AddShip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddShip.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.AddShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddShip.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddShip.ForeColor = System.Drawing.Color.Lime;
            this.AddShip.Location = new System.Drawing.Point(442, 493);
            this.AddShip.Name = "AddShip";
            this.AddShip.Size = new System.Drawing.Size(200, 74);
            this.AddShip.TabIndex = 7;
            this.AddShip.Text = "InitializeShip";
            this.AddShip.UseVisualStyleBackColor = false;
            this.AddShip.Click += new System.EventHandler(this.AddShip_Click);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(442, 466);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 128);
            this.panel4.TabIndex = 8;
            // 
            // GamePage3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 1061);
            this.Controls.Add(this.AddShip);
            this.Controls.Add(this.panel4);
            this.Name = "GamePage3";
            this.Text = "GamePage3";
            this.ResumeLayout(false);

        }

        #endregion

        private Button AddShip;
        private Panel panel4;
    }
}