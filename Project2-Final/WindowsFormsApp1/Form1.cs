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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<int> index_list = new List<int>();
        private PhotosProps pp = new PhotosProps();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap(Image.FromFile(@"C:\\Users\\vladb\\Desktop\\pic1.jpg"));

            foreach (var item in new HashSet<string>(pp.GetAllLabels()))
            {
                checkedListBox1.Items.Add(item);
            }

            listBox1.Items.Clear();
            foreach (Tuple<string, int> tuple in pp.GetAllImages())
            {
                listBox1.Items.Add(tuple.Item1);
                index_list.Add(tuple.Item2);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> filter_list = new List<string>();
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
               filter_list.Add(itemChecked.ToString());
            }

            if(filter_list.Count == 0)
            {
                listBox1.Items.Clear();
                foreach (Tuple<string, int> tuple in pp.GetAllImages())
                {
                    listBox1.Items.Add(tuple.Item1);
                    index_list.Add(tuple.Item2);
                }
            }
            else
            {
                listBox1.Items.Clear();
                foreach (Tuple<string, int> tuple in pp.GetFilteredImages(filter_list))
                {
                    listBox1.Items.Add(tuple.Item1);
                    index_list.Add(tuple.Item2);
                }
            }
        }

        private void findImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select multiple images";
            ofd.Multiselect = true;
            ofd.Filter = "JPG|*.jpg|JPEG|*jpeg|GIF|*.gif|PNG|*.png";
            DialogResult dr = ofd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                foreach ( string filepath in files)
                {
                    bool response = pp.AddPictures(filepath);

                    if (response)
                    {
                        button1_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("The image "+filepath+" is already in the database", "Image Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = new Bitmap(Image.FromFile(listBox1.SelectedItem.ToString()));

          
        }

        private void remove_Image(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.SelectedIndex);
            if (listBox1.SelectedIndex != -1)
            {
                pp.RemoveImage(index_list[listBox1.SelectedIndex]);
                index_list.Remove(index_list[listBox1.SelectedIndex]);
            }
            button1_Click(sender, e);
        }

        private void GoToDetails(object sender, EventArgs e)
        {
            var frm = new Form2(listBox1.SelectedItem.ToString(), index_list[listBox1.SelectedIndex]);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }
    }
}
