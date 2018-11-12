using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;



//XElement

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private XElement config_data;

        public Form1()
        {
            InitializeComponent();
        }

        private void set_xml(XElement new_xml)
        {
            this.config_data = new_xml;
        }

        private void run_me(object sender, EventArgs e)
        {
            Console.WriteLine("Linked");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                if (result == DialogResult.OK) // Test result.
                {
                    Console.WriteLine("bustin thru the roof like a AP", file);
                }
                Console.WriteLine(result); // <-- For debugging use.
            }
            Console.WriteLine(size); // <-- Shows file size in debugging mode.
            Console.WriteLine(result); // <-- For debugging use.
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Console.WriteLine("running file dialog");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void selectImage(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                if (result == DialogResult.OK) // Test result.
                {
                    Console.WriteLine(file);
                    pictureBox1.Image = Image.FromFile(@file);
                }
                //Console.WriteLine(result); // <-- For debugging use.
            }
            //Console.WriteLine(size); // <-- Shows file size in debugging mode.
            //Console.WriteLine(result); // <-- For debugging use.
        }

        private void load_config(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                if (1 == 1) // Test result.
                {
                    XElement current_xml = XElement.Load(@file);
                    this.set_xml(current_xml);
                    this.update_config_display();
                }
                //Console.WriteLine(result); // <-- For debugging use.
            }
        }

        private void update_config_display()
        {
            FileName.Text = "File Name: " ;
            Input.Text = "Input Type: " ;
            Output.Text = "Output Type: " ;
            Hardware.Text = "Hardware: " ;
            Extension.Text = "File Extension(s): " ;
            Job.Text = "Job: ";
            Console.WriteLine(config_data.Element("Root").Element("Process").Element("Jobs").Name);
        }
    }
}
