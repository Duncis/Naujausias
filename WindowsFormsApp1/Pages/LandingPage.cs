using RestAPI.Classes;
using RestAPI.Models;
using System;
using System.Windows.Forms;
using WindowsFormsApp1.Pages;

namespace WindowsFormsApp1
{
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
            this.fill.Hide();
        }

        private async void LandingPage_Load(object sender, EventArgs e)
        {

        }


        private async void RedirectToNewsPage(object sender, EventArgs e)
        {
            

            var KeyWord = keyword.Text;
            var Country = country.Text;
            var Language = language.Text;
            var Category = category.Text;


            if(KeyWord != "" || Country != "" || Language != "" || Category != "")
            {
                var modal = new SearchModel
                {
                    KeyWord = KeyWord == "" ? null : KeyWord,
                    Category = Category == "" ? null : Category,
                    Language = Language == "" ? null : Language,
                    Country = Country == "" ? null : Country,
                };


                var collector = new DataCollector();
                var data = await collector.GetAllProperties(modal);
                new NewsDetailsPage(data);


                this.Visible = false;
            }
            else
            {
                fill.Visible = true;
                return;
            }
        }
       
     

    }
}
