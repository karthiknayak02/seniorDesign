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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.FileNameLBL = new System.Windows.Forms.Label();
            this.JobLBL = new System.Windows.Forms.Label();
            this.ExtensionLBL = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.Label();
            this.HardwareLBL = new System.Windows.Forms.Label();
            this.InputLBL = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Trigger = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel1.Controls.Add(this.FileNameLBL);
            this.splitContainer1.Panel1.Controls.Add(this.JobLBL);
            this.splitContainer1.Panel1.Controls.Add(this.ExtensionLBL);
            this.splitContainer1.Panel1.Controls.Add(this.Output);
            this.splitContainer1.Panel1.Controls.Add(this.HardwareLBL);
            this.splitContainer1.Panel1.Controls.Add(this.InputLBL);
            this.splitContainer1.Panel1.Controls.Add(this.loadButton);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.DarkGray;
            this.splitContainer1.Panel2.Controls.Add(this.imageBox1);
            this.splitContainer1.Panel2.Controls.Add(this.Process);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.Trigger);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1688, 900);
            this.splitContainer1.SplitterDistance = 562;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 0;
            // 
            // FileNameLBL
            // 
            this.FileNameLBL.AutoSize = true;
            this.FileNameLBL.Location = new System.Drawing.Point(130, 202);
            this.FileNameLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FileNameLBL.Name = "FileNameLBL";
            this.FileNameLBL.Size = new System.Drawing.Size(172, 25);
            this.FileNameLBL.TabIndex = 6;
            this.FileNameLBL.Text = "File Name: None";
            // 
            // JobLBL
            // 
            this.JobLBL.AutoSize = true;
            this.JobLBL.Location = new System.Drawing.Point(130, 527);
            this.JobLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.JobLBL.Name = "JobLBL";
            this.JobLBL.Size = new System.Drawing.Size(110, 25);
            this.JobLBL.TabIndex = 5;
            this.JobLBL.Text = "Job: None";
            // 
            // ExtensionLBL
            // 
            this.ExtensionLBL.AutoSize = true;
            this.ExtensionLBL.Location = new System.Drawing.Point(130, 448);
            this.ExtensionLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ExtensionLBL.Name = "ExtensionLBL";
            this.ExtensionLBL.Size = new System.Drawing.Size(236, 25);
            this.ExtensionLBL.TabIndex = 4;
            this.ExtensionLBL.Text = "File Extension(s): None";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(130, 367);
            this.Output.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(193, 25);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output Type: None";
            // 
            // HardwareLBL
            // 
            this.HardwareLBL.AutoSize = true;
            this.HardwareLBL.Location = new System.Drawing.Point(130, 448);
            this.HardwareLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HardwareLBL.Name = "HardwareLBL";
            this.HardwareLBL.Size = new System.Drawing.Size(167, 25);
            this.HardwareLBL.TabIndex = 2;
            this.HardwareLBL.Text = "Hardware: None";
            // 
            // InputLBL
            // 
            this.InputLBL.AutoSize = true;
            this.InputLBL.Location = new System.Drawing.Point(130, 283);
            this.InputLBL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.InputLBL.Name = "InputLBL";
            this.InputLBL.Size = new System.Drawing.Size(176, 25);
            this.InputLBL.TabIndex = 1;
            this.InputLBL.Text = "Input Type: None";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(136, 733);
            this.loadButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(290, 58);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.load_config);
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(662, 746);
            this.Process.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(150, 44);
            this.Process.TabIndex = 2;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.process);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(91, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 579);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Trigger
            // 
            this.Trigger.Location = new System.Drawing.Point(334, 746);
            this.Trigger.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(150, 44);
            this.Trigger.TabIndex = 0;
            this.Trigger.Text = "Trigger";
            this.Trigger.UseVisualStyleBackColor = true;
            this.Trigger.Click += new System.EventHandler(this.selectImage);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(60, 27);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(668, 693);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1688, 900);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button Trigger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label InputLBL;
        private System.Windows.Forms.Label ExtensionLBL;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label HardwareLBL;
        private System.Windows.Forms.Label FileNameLBL;
        private System.Windows.Forms.Label JobLBL;
        private System.Windows.Forms.Button Process;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}

