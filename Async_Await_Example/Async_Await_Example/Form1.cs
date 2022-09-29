using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Async_Await_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader= new StreamReader("C:\\Users\\Suryash\\Documents\\Sample.txt"))
            {
                string content= reader.ReadToEnd();
                count= content.Length;
                Thread.Sleep(2000);
            }
            return count;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();
            labelcount.Text = "Processing file. Please wait!";
            int count= await task;
            labelcount.Text = count.ToString() + "characters in file";
        }

        private void labelcount_Click(object sender, EventArgs e)
        {

        }
    }
}
