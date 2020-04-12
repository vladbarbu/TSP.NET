using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelApi;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private PhotosProps pp = new PhotosProps();
        private int local_img_id;
        private List<int> prop_index = new List<int>();
        private bool textBox_flag = false;
        private bool comboBox_flag = false;
        private void PopulateComboBox(List<string> prop_list)
        {
            foreach(var item in prop_list)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void PopulateListView(int img_id)
        {
            listView1.Items.Clear();

            var details_list = pp.GetDetailsForImage(img_id);
            List<string> prop_list = new List<string>();

            foreach (var items in details_list)
            {

                string[] arr = new string[4];
                ListViewItem itm;
                //add items to ListView
                arr[0] = items.Item1;
                prop_list.Add(items.Item1);
                arr[1] = items.Item2;
                prop_index.Add(items.Item3);
                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }

            PopulateComboBox(prop_list);
        }

        private void ShowImage(string img_path)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap(Image.FromFile(img_path));
        }
        public Form2(string img_path, int img_id)
        {
            InitializeComponent();
            local_img_id = img_id;
            PopulateListView(img_id);
            ShowImage(img_path);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox_flag && comboBox_flag)
            {
               
                pp.AddProperty(comboBox1.Text, textBox1.Text,local_img_id);
                PopulateListView(local_img_id);
                resetFields();
            }
            else
            {
                MessageBox.Show("Please select a property and set a description", "Add property", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void resetFields()
        {
            textBox_flag = false;
            comboBox_flag = false;
            textBox1.Text = "Add a description";
            comboBox1.Text = "Select a property or add one";
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox_flag = true;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            comboBox_flag = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeProperty(object sender, EventArgs e)
        {

            pp.RemoveProperty(prop_index[listView1.FocusedItem.Index]);
            PopulateListView(local_img_id);
            resetFields();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interaction.InputBox("Question?", "Title", "Default Text");
        }
    }
}
