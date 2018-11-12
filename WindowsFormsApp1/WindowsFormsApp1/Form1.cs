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
using System.Diagnostics;



//XElement

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private XElement config_data;
        private string config_file_name = "None";
        private string input_location = "None";
        private string output_location = "None";
        private string job_description = "None";
        private string file_extensions = "None";
        private string hardware = "None";
        private string input_type = "None";
        private string output_type = "None";


        public Form1()
        {
            InitializeComponent();
            update_config_display();
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
                    input_location = file;
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
                if (file.Split('.')[1] == "xml") // Test result.
                {
                    XElement current_xml = XElement.Load(@file);
                    this.config_file_name = file.Split('\\')[file.Split('\\').Length-1];
                    this.set_xml(current_xml);
                    this.set_config_vars();
                    this.update_config_display();
                }
                else
                {
                    MessageBox.Show("Config file must be of type \".xml\"", "Error: Invalid File type");
                }
                //Console.WriteLine(result); // <-- For debugging use.
            }
        }

        private string get_ext_display()
        {
            string result = "";
            foreach (string typ in config_data.Element("Input").Element("FileTypes").Value.Split('.'))
            {
                if(typ != "")
                {
                    result += typ + ", ";
                }
            }
            if(result.Length > 3)
            {
                return result.Substring(0, result.Length - 2);
            }
            return "None";
        }

        private void set_config_vars()
        {
            input_type = config_data.Element("Input").Attribute("type").Value;
            if (input_type == "File System")
            {
                HardwareLBL.Visible = false; // sets which label is shown on screen
                ExtensionLBL.Visible = true;
                file_extensions = get_ext_display();
            }
            else
            {
                HardwareLBL.Visible = true; // sets which label is shown on screen
                ExtensionLBL.Visible = false;
                hardware = config_data.Element("Input").Element("Hardware").Attribute("type").Value;
            }
            output_type = config_data.Element("Output").Attribute("type").Value;
            job_description = config_data.Element("Process").Element("Job").Element("Name").Value;

        }

        private void update_config_display() 
            //needs a lot of error handling
        {
            FileNameLBL.Text = $"File Name: {config_file_name}";
            InputLBL.Text = $"Input Type: {input_type}";
            Output.Text = $"Output Type: {output_type}";
            HardwareLBL.Text = $"Hardware: {hardware}";
            ExtensionLBL.Text = $"File Extension(s): {file_extensions}";
            JobLBL.Text = $"Job: {job_description}";
            //Console.WriteLine($"hi: {config_data.Element("Process").Element("Job").Element("Name").Value}");
        }

        public string get_string_from_file_extensions(string[] ext)
        {
            string r = "";
            foreach (var e in ext)
            {
                if(e != null)
                {
                    r += e + ", ";
                } 
            }
            if(r.Length > 3)
            {
                return r.Substring(0, r.Length - 3);
            }
            else
            {
                return "None";
            }
            
        }

        // Execute cmd with filename(args in str if needed) and receive stdout
        public void run_cmd(string exe, string fileName)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo(exe, fileName)
            {
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            p.Start();

            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();
            Console.WriteLine($"here <{output}>");

            output_location = output;

        }

        public void process(object sender, EventArgs e)
        {
            run_cmd(@"python", $@"C:\Users\deavin\Documents\school\499CS\opencv_test\process\center_of_shape.py -i {input_location}");
            pictureBox1.Image = Image.FromFile(@output_location);
        }
    }
}
