using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProductRatingSystem.Enity;


namespace ProductRatingSystem
{
    public partial class MainMenu : Form
    {

        public MainMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Dialog_Form1 login = new Login_Dialog_Form1();
            login.Show();
          
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'productRatingSystemDataSet.Ratings' table. You can move, or remove it, as needed.
            this.ratingsTableAdapter.Fill(this.productRatingSystemDataSet.Ratings);
            // TODO: This line of code loads data into the 'productRatingSystemDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productRatingSystemDataSet.Product);

        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.productRatingSystemDataSet);

        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }







    }
}
