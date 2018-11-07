using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

                        try
            {
                XElement booksFromFile = XElement.Load(@"config01.xml");
                Console.WriteLine(booksFromFile);

                XmlReader r = XmlReader.Create("config01.xml");
                while (r.NodeType != XmlNodeType.Element)
                    r.Read();
                XElement e = XElement.Load(r);
                Console.WriteLine(e);



                //XmlSchemaSet schemas = new XmlSchemaSet();
                //schemas.Add("http://tempuri.org/XMLSchema1.xsd", "XMLSchema1.xsd");

                //Console.WriteLine("Attempting to validate");
                //XDocument custOrdDoc = XDocument.Load("config01.xml");
                //bool errors = false;
                //custOrdDoc.Validate(schemas, (o, e) =>
                //{
                //    Console.WriteLine("{0}", e.Message);
                //    errors = true;
                //});
                //Console.WriteLine("custOrdDoc {0}", errors ? "did not validate" : "validated");

            }
            catch (System.Xml.XmlException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (System.IO.FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
