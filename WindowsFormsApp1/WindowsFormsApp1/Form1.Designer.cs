namespace WindowsFormsApp1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FileName = new System.Windows.Forms.Label();
            this.Job = new System.Windows.Forms.Label();
            this.Extension = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.Hardware = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel1.Controls.Add(this.FileName);
            this.splitContainer1.Panel1.Controls.Add(this.Job);
            this.splitContainer1.Panel1.Controls.Add(this.Extension);
            this.splitContainer1.Panel1.Controls.Add(this.Output);
            this.splitContainer1.Panel1.Controls.Add(this.Hardware);
            this.splitContainer1.Panel1.Controls.Add(this.Input);
            this.splitContainer1.Panel1.Controls.Add(this.loadButton);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(844, 468);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(89, 86);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(86, 13);
            this.FileName.TabIndex = 6;
            this.FileName.Text = "File Name: None";
            // 
            // Job
            // 
            this.Job.AutoSize = true;
            this.Job.Location = new System.Drawing.Point(89, 281);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(56, 13);
            this.Job.TabIndex = 5;
            this.Job.Text = "Job: None";
            // 
            // Extension
            // 
            this.Extension.AutoSize = true;
            this.Extension.Location = new System.Drawing.Point(89, 242);
            this.Extension.Name = "Extension";
            this.Extension.Size = new System.Drawing.Size(115, 13);
            this.Extension.TabIndex = 4;
            this.Extension.Text = "File Extension(s): None";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(89, 164);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(98, 13);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output Type: None";
            // 
            // Hardware
            // 
            this.Hardware.AutoSize = true;
            this.Hardware.Location = new System.Drawing.Point(89, 203);
            this.Hardware.Name = "Hardware";
            this.Hardware.Size = new System.Drawing.Size(85, 13);
            this.Hardware.TabIndex = 2;
            this.Hardware.Text = "Hardware: None";
            // 
            // Input
            // 
            this.Input.AutoSize = true;
            this.Input.Location = new System.Drawing.Point(89, 125);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(90, 13);
            this.Input.TabIndex = 1;
            this.Input.Text = "Input Type: None";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(68, 388);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(145, 30);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.load_config);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.run_me);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(844, 468);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Input;
        private System.Windows.Forms.Label Extension;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label Hardware;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Label Job;
    }
}

