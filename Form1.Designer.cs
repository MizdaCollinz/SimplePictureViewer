namespace WindowsFormsApplication1
{
	partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearPictureButton = new System.Windows.Forms.Button();
            this.setBGColorButton = new System.Windows.Forms.Button();
            this.showPictureButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkboxPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.checkboxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkboxPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 515);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.AliceBlue;
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Controls.Add(this.setBGColorButton);
            this.flowLayoutPanel1.Controls.Add(this.clearPictureButton);
            this.flowLayoutPanel1.Controls.Add(this.showPictureButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(120, 524);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(661, 34);
            this.flowLayoutPanel1.TabIndex = 2;
            
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.Snow;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Font = new System.Drawing.Font("Malgun Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(583, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 30);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearPictureButton
            // 
            this.clearPictureButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearPictureButton.AutoSize = true;
            this.clearPictureButton.BackColor = System.Drawing.Color.Snow;
            this.clearPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearPictureButton.Font = new System.Drawing.Font("Malgun Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.clearPictureButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.clearPictureButton.Location = new System.Drawing.Point(235, 3);
            this.clearPictureButton.Name = "clearPictureButton";
            this.clearPictureButton.Size = new System.Drawing.Size(133, 30);
            this.clearPictureButton.TabIndex = 2;
            this.clearPictureButton.Text = "Clear the Picture";
            this.clearPictureButton.UseVisualStyleBackColor = false;
            this.clearPictureButton.Click += new System.EventHandler(this.clearPictureButton_Click);
            // 
            // setBGColorButton
            // 
            this.setBGColorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setBGColorButton.AutoSize = true;
            this.setBGColorButton.BackColor = System.Drawing.Color.Snow;
            this.setBGColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.setBGColorButton.Font = new System.Drawing.Font("Malgun Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.setBGColorButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setBGColorButton.Location = new System.Drawing.Point(374, 3);
            this.setBGColorButton.Name = "setBGColorButton";
            this.setBGColorButton.Size = new System.Drawing.Size(203, 30);
            this.setBGColorButton.TabIndex = 3;
            this.setBGColorButton.Text = "Set the background colour";
            this.setBGColorButton.UseVisualStyleBackColor = false;
            this.setBGColorButton.Click += new System.EventHandler(this.setBGButton_Click);
            // 
            // showPictureButton
            // 
            this.showPictureButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPictureButton.AutoSize = true;
            this.showPictureButton.BackColor = System.Drawing.Color.Snow;
            this.showPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showPictureButton.Font = new System.Drawing.Font("Malgun Gothic", 7.5F, System.Drawing.FontStyle.Bold);
            this.showPictureButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showPictureButton.Location = new System.Drawing.Point(122, 3);
            this.showPictureButton.Name = "showPictureButton";
            this.showPictureButton.Size = new System.Drawing.Size(107, 30);
            this.showPictureButton.TabIndex = 0;
            this.showPictureButton.Text = "Show a Picture";
            this.showPictureButton.UseVisualStyleBackColor = false;
            this.showPictureButton.Click += new System.EventHandler(this.showPictureButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Font = new System.Drawing.Font("Malgun Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(20, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(3);
            this.checkBox1.Size = new System.Drawing.Size(74, 24);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Stretch";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.openFileDialog1.Title = "Select a picture file";
            // 
            // checkboxPanel
            // 
            this.checkboxPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.checkboxPanel.Controls.Add(this.checkBox1);
            this.checkboxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkboxPanel.Location = new System.Drawing.Point(3, 524);
            this.checkboxPanel.Name = "checkboxPanel";
            this.checkboxPanel.Size = new System.Drawing.Size(111, 34);
            this.checkboxPanel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Cornsilk;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Simple Picture Viewer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.checkboxPanel.ResumeLayout(false);
            this.checkboxPanel.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button showPictureButton;
		private System.Windows.Forms.Button clearPictureButton;
		private System.Windows.Forms.Button setBGColorButton;
		private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel checkboxPanel;
    }
}

