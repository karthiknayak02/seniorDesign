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
            this.splitContainer1.Panel2.Controls.Add(this.Process);
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.Trigger);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(844, 468);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // FileNameLBL
            // 
            this.FileNameLBL.AutoSize = true;
            this.FileNameLBL.Location = new System.Drawing.Point(65, 105);
            this.FileNameLBL.Name = "FileNameLBL";
            this.FileNameLBL.Size = new System.Drawing.Size(86, 13);
            this.FileNameLBL.TabIndex = 6;
            this.FileNameLBL.Text = "File Name: None";
            // 
            // JobLBL
            // 
            this.JobLBL.AutoSize = true;
            this.JobLBL.Location = new System.Drawing.Point(65, 274);
            this.JobLBL.Name = "JobLBL";
            this.JobLBL.Size = new System.Drawing.Size(56, 13);
            this.JobLBL.TabIndex = 5;
            this.JobLBL.Text = "Job: None";
            // 
            // ExtensionLBL
            // 
            this.ExtensionLBL.AutoSize = true;
            this.ExtensionLBL.Location = new System.Drawing.Point(65, 233);
            this.ExtensionLBL.Name = "ExtensionLBL";
            this.ExtensionLBL.Size = new System.Drawing.Size(115, 13);
            this.ExtensionLBL.TabIndex = 4;
            this.ExtensionLBL.Text = "File Extension(s): None";
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(65, 191);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(98, 13);
            this.Output.TabIndex = 3;
            this.Output.Text = "Output Type: None";
            // 
            // HardwareLBL
            // 
            this.HardwareLBL.AutoSize = true;
            this.HardwareLBL.Location = new System.Drawing.Point(65, 233);
            this.HardwareLBL.Name = "HardwareLBL";
            this.HardwareLBL.Size = new System.Drawing.Size(85, 13);
            this.HardwareLBL.TabIndex = 2;
            this.HardwareLBL.Text = "Hardware: None";
            // 
            // InputLBL
            // 
            this.InputLBL.AutoSize = true;
            this.InputLBL.Location = new System.Drawing.Point(65, 147);
            this.InputLBL.Name = "InputLBL";
            this.InputLBL.Size = new System.Drawing.Size(90, 13);
            this.InputLBL.TabIndex = 1;
            this.InputLBL.Text = "Input Type: None";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(68, 381);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(145, 30);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.load_config);
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(331, 388);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(75, 23);
            this.Process.TabIndex = 2;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.process);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Trigger
            // 
            this.Trigger.Location = new System.Drawing.Point(167, 388);
            this.Trigger.Name = "Trigger";
            this.Trigger.Size = new System.Drawing.Size(75, 23);
            this.Trigger.TabIndex = 0;
            this.Trigger.Text = "Trigger";
            this.Trigger.UseVisualStyleBackColor = true;
            this.Trigger.Click += new System.EventHandler(this.selectImage);
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
        private System.Windows.Forms.Button Trigger;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label InputLBL;
        private System.Windows.Forms.Label ExtensionLBL;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.Label HardwareLBL;
        private System.Windows.Forms.Label FileNameLBL;
        private System.Windows.Forms.Label JobLBL;
        private System.Windows.Forms.Button Process;
    }
}

