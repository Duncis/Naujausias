using RestAPI.Classes;
using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1.Pages
{
    public partial class NewsDetailsPage : Form
    {

        public NewsDetailsPage(Tuple<List<AllPropertiesModel>,int> data)
        {
            InitializeComponent();
            this.Visible = true;
            label3.Text = data.Item2.ToString();
            label5.Text = data.Item1.Count().ToString();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = data.Item1;
          
        }

        private void RedirectToLandingPage(object sender, EventArgs e)
        {
            this.Hide();
            this.TopMost = false;

            new LandingPage
            {
                Visible = true,
                StartPosition = FormStartPosition.CenterScreen,
                WindowState = FormWindowState.Normal
            };
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
