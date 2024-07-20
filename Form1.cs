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

namespace ivan_asked_me_for_help
{
    public partial class Form1 : Form
    {
        public static string directory = "D:\\госномера"; //путь директории
        public Form1()
        {
            InitializeComponent();
            new Class1(listBox1, directory).refresh();
        }

        private void groupBox1_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                groupBox1.Visible = true;
                numbox.Text = textBox1.Text;
            }
            else
            {
                groupBox1.Visible = false;
            }
                
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (numbox.Text == "" || fullnamebox.Text == "" || modelbox.Text == "" || colorbox.Text == "")
            {
                MessageBox.Show("Проверьте ваши данные, возможно вы не всё заполнили. Если же какие-то данные у вас отсутсвуют просто укажите \"пусто\".");
            }
            else
            {
                try
                {
                    string path = $"D:\\госномера\\{numbox.Text}.txt";
                    string[] data = {numbox.Text, modelbox.Text, colorbox.Text, fullnamebox.Text };
                    File.WriteAllLines(path, data);
                    new Class1(listBox1, directory).refresh();
                    textBox1.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка! {ex}");
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
                groupBox1.Visible = true;
                string path = $"D:\\госномера\\{listBox1.SelectedItem}.txt";
                StreamReader sr = new StreamReader(path);
                numbox.Text = sr.ReadLine();
                modelbox.Text = sr.ReadLine();
                colorbox.Text = sr.ReadLine();
                fullnamebox.Text = sr.ReadLine();
                sr.Close();
            }
            catch (Exception ex)
            {

            }
            

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $"D:\\госномера\\{listBox1.SelectedItem.ToString()}.txt";
                int index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                File.Delete(path);
                new Class1(listBox1, directory).refresh();
                groupBox1.Visible = false;
                numbox.Text = "";
                modelbox.Text = "";
                colorbox.Text = "";
                fullnamebox.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            groupBox1.Visible = false;
            numbox.Text = "";
            modelbox.Text = "";
            colorbox.Text = "";
            fullnamebox.Text = "";
        }
    }
}
