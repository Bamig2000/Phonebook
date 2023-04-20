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


namespace Project4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int count;
        int hashposition;

        
        private void Form3_Load(object sender, EventArgs e)
        {

           
 
         
            FileStream fs = new FileStream("Contacts.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            count = 1;
            label15.Text = count.ToString();
            hashposition = 0;
          
            string temp = sr.ReadLine();
            label7.Text = rightinfo(sr.ReadLine());
            label8.Text = rightinfo(sr.ReadLine());
            label9.Text = rightinfo(sr.ReadLine());
            label10.Text = rightinfo(sr.ReadLine());
            label11.Text = rightinfo(sr.ReadLine());
            label12.Text = rightinfo(sr.ReadLine());
            pictureBox1.Image = new Bitmap(rightinfo(sr.ReadLine()));
            string text = File.ReadAllText(@"Contacts.txt");
            int lines = File.ReadLines(@"Contacts.txt").Count();
            int hashnum;
            hashnum = lines / 8;
            updatelabel();
           

            sr.Close();
            fs.Close();
         }    
           

       

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            count = Convert.ToInt32(label15.Text)+1;
            hashposition += 8;
            updatelabel();

            try
            {
                FileStream fs = new FileStream("Contacts.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                string temp = (File.ReadLines("Contacts.txt").ElementAt(hashposition));
                label7.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 1));
                label8.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 2));
                label9.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 3));
                label10.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 4));
                label11.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 5));
                label12.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 6));
                pictureBox1.Image = new Bitmap(rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 7)));

                sr.Close();
                fs.Close();
            }
            catch (ArgumentOutOfRangeException )
            {
                button2.Enabled = false;
            }
            catch(ArgumentException)
                {
                pictureBox1.Image = new Bitmap(Properties.Resources.PICA);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Enabled = true;
                count = Convert.ToInt32(label15.Text) - 1;
                hashposition -= 8;
                updatelabel();

                FileStream fs = new FileStream("Contacts.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string temp= rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition));
                
                label7.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 1));
                label8.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 2));
                label9.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 3));
                label10.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 4));
                label11.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 5));
                label12.Text = rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 6));
                pictureBox1.Image = new Bitmap(rightinfo(File.ReadLines("Contacts.txt").ElementAt(hashposition + 7)));

                sr.Close();
                fs.Close();

            }
            catch (ArgumentOutOfRangeException)
            {

                button1.Enabled = false;
            }
            

        }
        public void updatelabel()
        {
            label15.Text = count.ToString();
            FileStream fs = new FileStream("Contacts.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string text = File.ReadAllText(@"Contacts.txt");
            int lines = File.ReadLines(@"Contacts.txt").Count();
            int hashnum;
            hashnum = lines / 8;
            label13.Text = $" out of {hashnum}";
            if (count == 1)
            {
                button1.Enabled = false;
            }
            else if (count == hashnum)
            {
                button2.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            sr.Close();
            fs.Close();

        }

        private string rightinfo(string str)
        {
            int lastdoubledot = str.LastIndexOf(':');
            string result = str.Substring(lastdoubledot + 1).Trim();
            return result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

       
    }
}
