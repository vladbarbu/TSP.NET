using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhotoProps;

namespace PhotoPropsForm
{
    public partial class Form1 : Form
    {
        List<Photo> photos = new List<Photo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void test(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            photos = LoadPhotos().ToList<Photo>();
            dgp.DataSource = photos;
            dgp.Columns[0].Width = 0;
            if (dgp.Rows.Count > 0)
                dgc.DataSource = photos[0].Props;
        }

        private static PhotoProps.Photo[] LoadPhotos()
        {
            PhotoPropsClient pc = new PhotoPropsClient();
            PhotoProps.Photo[] p = pc.GetPhotos();
            return p;
        }

        // Handler pentru evenimentul CellMouseClick din DatagridView numit dgp
        private void dgp_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            // Se afiseaza Comment-urile pentru Post-ul selectat
            dgc.DataSource = null;
            dgc.DataSource = photos[e.RowIndex].Props;
        }

    }
}
