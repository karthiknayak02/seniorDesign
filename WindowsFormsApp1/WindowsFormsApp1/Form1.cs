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

using Emgu.CV;



//XElement

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        private XElement config_data;
        private string config_file_name = "None";
        private string input_location;
        private string output_location;
        private string job_description = "None";
        private string job_path;
        private string file_extensions = "None";
        private string hardware = "None";
        private string input_type = "None";
        private string output_type = "None";
        private bool config_file_loaded = false;

        VideoCapture capture;


        public Form1()
        {
            InitializeComponent();
            update_config_display();
            imgTrigger();
        }

        private void imgTrigger()
        {
            try
            {
                capture = new VideoCapture();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            imageBox1.Image = capture.QuerySmallFrame();
        }

        private void set_xml(XElement new_xml)
        {
            this.config_data = new_xml;
        }

        private void run_me(object sender, EventArgs e)
        {
            Console.WriteLine("Linked");
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int size = -1;
        //    DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
        //    if (result == DialogResult.OK) // Test result.
        //    {
        //        string file = openFileDialog1.FileName;
        //        if (result == DialogResult.OK) // Test result.
        //        {
        //            Console.WriteLine("bustin thru the roof like a AP", file);
        //        }
        //        Console.WriteLine(result); // <-- For debugging use.
        //    }
        //    Console.WriteLine(size); // <-- Shows file size in debugging mode.
        //    Console.WriteLine(result); // <-- For debugging use.
        //}

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

        private bool acceptable_extension(string ext, string[] list)
        {
            foreach( string elem in list)
            {
                string comp = elem; //new string to compare, gets rid of leading whitespace
                if(elem[0] == ' ')
                {
                    comp = elem.Substring(1, elem.Length - 1);
                }
                Console.WriteLine(comp);
                if (ext.ToLower() == comp.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private void selectImage(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                if (config_file_loaded)
                {
                    if (acceptable_extension(file.Split('.')[1], file_extensions.Split(','))) // Test result.
                    {
                        Console.WriteLine(file);
                        input_location = file;
                        pictureBox1.Image = Image.FromFile(@file);
                    }
                    else
                    {
                        MessageBox.Show($"Image file must be one of the following file types: {file_extensions}", "Error: Invalid File type");
                    }
                }
                else
                {
                    MessageBox.Show("Config file not selected", "Error");
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
                    this.config_file_loaded = true;
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
            output_location = config_data.Element("Output").Element("SavePath").Value;
            job_description = config_data.Element("Process").Element("Job").Element("Name").Value;
            job_path = config_data.Element("Process").Element("Job").Element("PathExe").Value;

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
            if (output_location == null)
            {
                run_cmd(@"python", $@"{job_path} {input_location}");
            } else
            {
                run_cmd(@"python", $@"{job_path} {input_location} -o {output_location}");

            }


            Console.WriteLine($"Output: {output_location.Split(':')[0]}");
            if(output_location != null && output_location != "")
            {
                pictureBox1.Image = Image.FromFile(@output_location);
            }
            else
            {
                MessageBox.Show("Could not detect shaped in image", "Error");
            }
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
