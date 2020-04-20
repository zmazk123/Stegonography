namespace Stegonograpy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Top_panel = new System.Windows.Forms.Panel();
            this.B_Min = new System.Windows.Forms.Button();
            this.B_Exit = new System.Windows.Forms.Button();
            this.B_OpenFile = new System.Windows.Forms.Button();
            this.Bot_Panel = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.EncodeLabel = new System.Windows.Forms.Label();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.LabelMaxSize = new System.Windows.Forms.Label();
            this.LabelSize = new System.Windows.Forms.Label();
            this.WorkPanel = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.B_Encode = new System.Windows.Forms.Button();
            this.B_Save = new System.Windows.Forms.Button();
            this.B_decode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Top_panel.SuspendLayout();
            this.Bot_Panel.SuspendLayout();
            this.WorkPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Top_panel.Controls.Add(this.B_Min);
            this.Top_panel.Controls.Add(this.B_Exit);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(410, 31);
            this.Top_panel.TabIndex = 0;
            this.Top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseDown);
            this.Top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseMove);
            this.Top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseUp);
            // 
            // B_Min
            // 
            this.B_Min.BackgroundImage = global::Stegonograpy.Properties.Resources.minus_square_outlined_button__1_;
            this.B_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Min.FlatAppearance.BorderSize = 0;
            this.B_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Min.Location = new System.Drawing.Point(353, 3);
            this.B_Min.Name = "B_Min";
            this.B_Min.Size = new System.Drawing.Size(24, 24);
            this.B_Min.TabIndex = 2;
            this.B_Min.UseVisualStyleBackColor = true;
            this.B_Min.Click += new System.EventHandler(this.B_Min_Click);
            // 
            // B_Exit
            // 
            this.B_Exit.BackgroundImage = global::Stegonograpy.Properties.Resources.cross_square_button;
            this.B_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Exit.FlatAppearance.BorderSize = 0;
            this.B_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Exit.Location = new System.Drawing.Point(383, 3);
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.Size = new System.Drawing.Size(24, 24);
            this.B_Exit.TabIndex = 1;
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.B_Exit_Click);
            // 
            // B_OpenFile
            // 
            this.B_OpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(116)))), ((int)(((byte)(7)))));
            this.B_OpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_OpenFile.FlatAppearance.BorderSize = 0;
            this.B_OpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_OpenFile.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_OpenFile.ForeColor = System.Drawing.Color.White;
            this.B_OpenFile.Location = new System.Drawing.Point(112, 46);
            this.B_OpenFile.Name = "B_OpenFile";
            this.B_OpenFile.Size = new System.Drawing.Size(186, 54);
            this.B_OpenFile.TabIndex = 1;
            this.B_OpenFile.Text = "Open File";
            this.B_OpenFile.UseVisualStyleBackColor = false;
            this.B_OpenFile.Click += new System.EventHandler(this.B_OpenFile_Click);
            // 
            // Bot_Panel
            // 
            this.Bot_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Bot_Panel.Controls.Add(this.StatusLabel);
            this.Bot_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bot_Panel.Location = new System.Drawing.Point(0, 589);
            this.Bot_Panel.Name = "Bot_Panel";
            this.Bot_Panel.Size = new System.Drawing.Size(410, 26);
            this.Bot_Panel.TabIndex = 2;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StatusLabel.ForeColor = System.Drawing.Color.White;
            this.StatusLabel.Location = new System.Drawing.Point(3, 7);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 15);
            this.StatusLabel.TabIndex = 10;
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 31);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(2, 558);
            this.LeftPanel.TabIndex = 3;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(408, 31);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(2, 558);
            this.RightPanel.TabIndex = 4;
            // 
            // EncodeLabel
            // 
            this.EncodeLabel.AutoSize = true;
            this.EncodeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EncodeLabel.ForeColor = System.Drawing.Color.White;
            this.EncodeLabel.Location = new System.Drawing.Point(162, 0);
            this.EncodeLabel.Name = "EncodeLabel";
            this.EncodeLabel.Size = new System.Drawing.Size(83, 19);
            this.EncodeLabel.TabIndex = 6;
            this.EncodeLabel.Text = "Message:";
            // 
            // RichTextBox
            // 
            this.RichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RichTextBox.ForeColor = System.Drawing.Color.White;
            this.RichTextBox.Location = new System.Drawing.Point(0, 40);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(404, 103);
            this.RichTextBox.TabIndex = 7;
            this.RichTextBox.Text = "";
            this.RichTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // LabelMaxSize
            // 
            this.LabelMaxSize.AutoSize = true;
            this.LabelMaxSize.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelMaxSize.ForeColor = System.Drawing.Color.White;
            this.LabelMaxSize.Location = new System.Drawing.Point(0, 146);
            this.LabelMaxSize.Name = "LabelMaxSize";
            this.LabelMaxSize.Size = new System.Drawing.Size(139, 15);
            this.LabelMaxSize.TabIndex = 8;
            this.LabelMaxSize.Text = "Largest message size: ";
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSize.ForeColor = System.Drawing.Color.White;
            this.LabelSize.Location = new System.Drawing.Point(232, 146);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(100, 15);
            this.LabelSize.TabIndex = 9;
            this.LabelSize.Text = "Current size: 0 B";
            // 
            // WorkPanel
            // 
            this.WorkPanel.Controls.Add(this.RichTextBox);
            this.WorkPanel.Controls.Add(this.LabelSize);
            this.WorkPanel.Controls.Add(this.EncodeLabel);
            this.WorkPanel.Controls.Add(this.LabelMaxSize);
            this.WorkPanel.Location = new System.Drawing.Point(3, 288);
            this.WorkPanel.Name = "WorkPanel";
            this.WorkPanel.Size = new System.Drawing.Size(404, 173);
            this.WorkPanel.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // B_Encode
            // 
            this.B_Encode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(116)))), ((int)(((byte)(7)))));
            this.B_Encode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Encode.Enabled = false;
            this.B_Encode.FlatAppearance.BorderSize = 0;
            this.B_Encode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Encode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_Encode.ForeColor = System.Drawing.Color.White;
            this.B_Encode.Location = new System.Drawing.Point(8, 467);
            this.B_Encode.Name = "B_Encode";
            this.B_Encode.Size = new System.Drawing.Size(186, 54);
            this.B_Encode.TabIndex = 11;
            this.B_Encode.Text = "Encode";
            this.B_Encode.UseVisualStyleBackColor = false;
            this.B_Encode.Click += new System.EventHandler(this.B_Encode_Click);
            // 
            // B_Save
            // 
            this.B_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(116)))), ((int)(((byte)(7)))));
            this.B_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_Save.Enabled = false;
            this.B_Save.FlatAppearance.BorderSize = 0;
            this.B_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_Save.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_Save.ForeColor = System.Drawing.Color.White;
            this.B_Save.Location = new System.Drawing.Point(216, 467);
            this.B_Save.Name = "B_Save";
            this.B_Save.Size = new System.Drawing.Size(186, 54);
            this.B_Save.TabIndex = 12;
            this.B_Save.Text = "Save";
            this.B_Save.UseVisualStyleBackColor = false;
            this.B_Save.Click += new System.EventHandler(this.B_Save_Click);
            // 
            // B_decode
            // 
            this.B_decode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(116)))), ((int)(((byte)(7)))));
            this.B_decode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_decode.Enabled = false;
            this.B_decode.FlatAppearance.BorderSize = 0;
            this.B_decode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_decode.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.B_decode.ForeColor = System.Drawing.Color.White;
            this.B_decode.Location = new System.Drawing.Point(8, 527);
            this.B_decode.Name = "B_decode";
            this.B_decode.Size = new System.Drawing.Size(186, 54);
            this.B_decode.TabIndex = 13;
            this.B_decode.Text = "Decode";
            this.B_decode.UseVisualStyleBackColor = false;
            this.B_decode.Click += new System.EventHandler(this.B_decode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(410, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.B_decode);
            this.Controls.Add(this.B_Save);
            this.Controls.Add(this.B_Encode);
            this.Controls.Add(this.WorkPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.Bot_Panel);
            this.Controls.Add(this.B_OpenFile);
            this.Controls.Add(this.Top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Top_panel.ResumeLayout(false);
            this.Bot_Panel.ResumeLayout(false);
            this.Bot_Panel.PerformLayout();
            this.WorkPanel.ResumeLayout(false);
            this.WorkPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Button B_Min;
        private System.Windows.Forms.Button B_OpenFile;
        private System.Windows.Forms.Panel Bot_Panel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label EncodeLabel;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Label LabelMaxSize;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Panel WorkPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button B_Encode;
        private System.Windows.Forms.Button B_Save;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button B_decode;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

