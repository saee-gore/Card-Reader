**Programmer: Saee A. Gore

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

namespace WindowsFormsApp2
{
    public partial class Swipe1 : Form
    {
        public Swipe1()
        {
            InitializeComponent();

            void write_line(string line)
            {

                string folderpath = @"C:\Users\sgore\Desktop\Saee\Smart Card Reader";
                string fileName = "SaeeFiles" + DateTime.Now.ToString("yyyyMMdd") + ".txt"; 
                folderpath = Path.Combine(folderpath, fileName);
                Console.WriteLine("Path to my file:", folderpath);
                if (!File.Exists(folderpath))
                {
                    using (FileStream fs = File.Create(folderpath))
                    {
                        Console.WriteLine("File created.", fileName);

                    }
                }
                else
                {
                    Console.WriteLine("File already exists.", fileName);
                }

                StreamWriter csv_file = File.AppendText(folderpath);
                csv_file.WriteLine("\n data in file is:" + line);
                csv_file.Close();
            }


            while (true)
            {
                string data;
                data = Console.ReadLine();
                Console.WriteLine("data is :" + data);
                write_line(data);
                Thread.Sleep(20);
            }


        }
        private void Form1_Load(object sender, EventArgs e)
        { }
        private void notifyIcon1_MouseDoubleClick(object sender, EventArgs e)
        { notifyIcon1.Visible = true;}

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {}
       
        void Initializecomponent()
        {}
    }

}
