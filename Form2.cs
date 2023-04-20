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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string name, middlename, lastname, address, gender, path;
            long phone;
            try
            {

                name = textBox1.Text;

                middlename = textBox2.Text;
                lastname = textBox3.Text;
                phone = Convert.ToInt64(textBox4.Text);
                address = textBox5.Text;
                gender = "none";
                path = textBox6.Text;



                if (textBox2.Text == "")
                {
                    middlename = " ";
                }
                else
                {
                    middlename = textBox2.Text;
                }

                if (radioButton1.Checked == true)
                {
                    gender = "Male";
                }
                else
                {
                    gender = "Female";
                }
                Program.contacts.Add(new Contacts(name, middlename, lastname, phone, address, gender));
                FileStream fs = new FileStream("Contacts.txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine("###################");
                sw.WriteLine($"Name: {name}");
                sw.WriteLine($"middle Name: {middlename}");
                sw.WriteLine($"Last Name: {lastname}");
                sw.WriteLine($"Phone: {phone}");
                sw.WriteLine($"Address: {address}");
                sw.WriteLine($"Gender: {gender}");
                sw.WriteLine($"Image: {path}");

                sw.Close();
                fs.Close();

                MessageBox.Show("Contact has been added");



                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                pictureBox1.Image = new Bitmap(Properties.Resources.PICA);
                radioButton1.Checked = false;
                radioButton2.Checked = false;




            }
            catch (FormatException fex)
            {
                MessageBox.Show(fex.Message);
                textBox4.Text = "";

            }
            
         
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Program.contacts.Count} contacts have been added");
            
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Properties.Resources.PICA);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            

            if (od.ShowDialog() == DialogResult.OK)
            {
                string source = od.FileName.ToString();
                textBox6.Text = source;
                pictureBox1.Image = new Bitmap(source);
            }
            else if (od.ShowDialog() == DialogResult.Cancel)
            {
                pictureBox1.Image = new Bitmap(Properties.Resources.PICA);
            }

           

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = System.Drawing.SystemColors.ButtonFace;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.SystemColors.ButtonFace;
        }
    }
}
