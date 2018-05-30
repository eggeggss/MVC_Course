using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebRequest req = WebRequest.Create("http://localhost:53971/api/Course");
            req.Method = "GET";

            WebResponse res = req.GetResponse();

            StreamReader sr = new StreamReader(res.GetResponseStream());
            string result = sr.ReadToEnd();
            sr.Close();

            MessageBox.Show(result);
            Course[] data =  JsonConvert.DeserializeObject<Course[]>(result);
            foreach (var item in data)
            {
                listBox1.Items.Add(item.Id + " -- " + item.Name);
            }
        }
    }
}
