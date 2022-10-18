namespace ISCEXtest1
{
    partial class graphicstest
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shipDesignerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.shipDesignerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yLocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sizeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xLocDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yLocDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipDesignerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoveShip = new System.Windows.Forms.Button();
            this.ConfirmMove = new System.Windows.Forms.Button();
            this.movementbutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(459, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 1059);
            this.panel1.TabIndex = 0;
            this.panel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel1_Scroll);
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1003, 1056);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // shipDesignerBindingSource1
            // 
            this.shipDesignerBindingSource1.DataSource = typeof(ISCEXtest1.ShipDesigner);
            this.shipDesignerBindingSource1.CurrentChanged += new System.EventHandler(this.shipDesignerBindingSource1_CurrentChanged);
            // 
            // shipDesignerBindingSource
            // 
            this.shipDesignerBindingSource.DataSource = typeof(ISCEXtest1.ShipDesigner);
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // xLocDataGridViewTextBoxColumn
            // 
            this.xLocDataGridViewTextBoxColumn.DataPropertyName = "xLoc";
            this.xLocDataGridViewTextBoxColumn.HeaderText = "xLoc";
            this.xLocDataGridViewTextBoxColumn.Name = "xLocDataGridViewTextBoxColumn";
            // 
            // yLocDataGridViewTextBoxColumn
            // 
            this.yLocDataGridViewTextBoxColumn.DataPropertyName = "yLoc";
            this.yLocDataGridViewTextBoxColumn.HeaderText = "yLoc";
            this.yLocDataGridViewTextBoxColumn.Name = "yLocDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sizeDataGridViewTextBoxColumn1,
            this.xLocDataGridViewTextBoxColumn1,
            this.yLocDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.shipDesignerBindingSource2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // sizeDataGridViewTextBoxColumn1
            // 
            this.sizeDataGridViewTextBoxColumn1.DataPropertyName = "Size";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            this.sizeDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle3;
            this.sizeDataGridViewTextBoxColumn1.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn1.Name = "sizeDataGridViewTextBoxColumn1";
            this.sizeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // xLocDataGridViewTextBoxColumn1
            // 
            this.xLocDataGridViewTextBoxColumn1.DataPropertyName = "xLoc";
            this.xLocDataGridViewTextBoxColumn1.HeaderText = "xLoc";
            this.xLocDataGridViewTextBoxColumn1.Name = "xLocDataGridViewTextBoxColumn1";
            // 
            // yLocDataGridViewTextBoxColumn1
            // 
            this.yLocDataGridViewTextBoxColumn1.DataPropertyName = "yLoc";
            this.yLocDataGridViewTextBoxColumn1.HeaderText = "yLoc";
            this.yLocDataGridViewTextBoxColumn1.Name = "yLocDataGridViewTextBoxColumn1";
            // 
            // shipDesignerBindingSource2
            // 
            this.shipDesignerBindingSource2.DataSource = typeof(ISCEXtest1.ShipDesigner);
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Cyan;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.DataSource = this.shipDesignerBindingSource2;
            this.dataGridView2.GridColor = System.Drawing.Color.Black;
            this.dataGridView2.Location = new System.Drawing.Point(1565, 12);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(343, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Size";
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "Size";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "xLoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "xLoc";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "yLoc";
            this.dataGridViewTextBoxColumn3.HeaderText = "yLoc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // MoveShip
            // 
            this.MoveShip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoveShip.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.MoveShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveShip.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MoveShip.ForeColor = System.Drawing.Color.Lime;
            this.MoveShip.Location = new System.Drawing.Point(12, 168);
            this.MoveShip.Name = "MoveShip";
            this.MoveShip.Size = new System.Drawing.Size(156, 74);
            this.MoveShip.TabIndex = 9;
            this.MoveShip.Text = "Move Ship";
            this.MoveShip.UseVisualStyleBackColor = false;
            this.MoveShip.Click += new System.EventHandler(this.MoveShip_Click);
            // 
            // ConfirmMove
            // 
            this.ConfirmMove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ConfirmMove.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.ConfirmMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmMove.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConfirmMove.ForeColor = System.Drawing.Color.Lime;
            this.ConfirmMove.Location = new System.Drawing.Point(12, 272);
            this.ConfirmMove.Name = "ConfirmMove";
            this.ConfirmMove.Size = new System.Drawing.Size(156, 74);
            this.ConfirmMove.TabIndex = 10;
            this.ConfirmMove.Text = "Confirm";
            this.ConfirmMove.UseVisualStyleBackColor = false;
            this.ConfirmMove.Visible = false;
            this.ConfirmMove.Click += new System.EventHandler(this.ConfirmMove_Click);
            // 
            // movementbutton
            // 
            this.movementbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.movementbutton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.movementbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movementbutton.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.movementbutton.ForeColor = System.Drawing.Color.Lime;
            this.movementbutton.Location = new System.Drawing.Point(12, 384);
            this.movementbutton.Name = "movementbutton";
            this.movementbutton.Size = new System.Drawing.Size(156, 74);
            this.movementbutton.TabIndex = 11;
            this.movementbutton.Text = "Set";
            this.movementbutton.UseVisualStyleBackColor = false;
            this.movementbutton.Visible = false;
            this.movementbutton.Click += new System.EventHandler(this.movementbutton_Click);
            // 
            // graphicstest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.movementbutton);
            this.Controls.Add(this.ConfirmMove);
            this.Controls.Add(this.MoveShip);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "graphicstest";
            this.Text = "graphicstest";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.graphicstest_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicstest_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipDesignerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private BindingSource shipDesignerBindingSource1;
        private BindingSource shipDesignerBindingSource;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xLocDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yLocDataGridViewTextBoxColumn;
        private DataGridView dataGridView1;
        private BindingSource shipDesignerBindingSource2;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn xLocDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn yLocDataGridViewTextBoxColumn1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button MoveShip;
        private Button ConfirmMove;
        private Button movementbutton;
        private PictureBox pictureBox1;
    }
}