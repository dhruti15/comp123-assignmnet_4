﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 
/// <summary>
/// Name : Dhruti Patel
/// Student Id : 300877959  
/// Date Created : 19 August 2016 
/// 
/// </summary>
namespace Movie_Bonanza
{
    public partial class SelectionForm : Form
    {
        
        decimal[] downloadCost = new decimal[] 
        { 1.99m, 1.99m, 2.99m, 2.99m, 2.99m, 1.99m, 0.99m, 4.99m  };

        string[] movies = new string[] { };

        string[] category = new string[] { "Comedy", "Drama", "Action", "Sci-Fi", "Horror", "Thriller", "Family", "New Release" };
        string[] comedyMovies = new string[] { "The Dilemma", "No Strings Attached", "Cedar Rapids", "Just Go With it" };
        string[] dramaMovies = new string[] {"Company Men", "The Way Back", "Waiting for Forever"  };
        string[] actionMovies = new string[] {"The Green Hornet", "Death Race 2", "The Mechanic", "Sanctum", "The Other Woman", "The Eagle" };
        string[] scifiMovies = new string[] {"Season of the Witch", "I am Number Four" };
        string[] horrorMovies = new string[] {"The Rite"};
        string[] thrillerMovies = new string[] {"The Roommate" };
        string[] familyMovies = new string[] {"Gnomeo and Juliet" };
        string[] newReleaseMovies = new string[] {"Footloose", "Real Steel" }; 
        


        public SelectionForm()
        {
            //to be added splashscreen
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

        }

        /*
        * funciton for splashstart to be called 
        * */
        public void SplashStart()
        {
            Application.Run(new SplashScreenForm());
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TitleTextBox.Text = string.Empty; 
           
            foreach (string value in MoviesListBox.SelectedItems) {
                TitleTextBox.Text = value.ToString();
                if (value == "The Dilemma") {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thedilemma);
                }
                if (value == "No Strings Attached")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.nostringsattached);
                }
                if (value == "Cedar Rapids")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.cedarrapids);
                }
                if (value == "Just Go With it")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.justgowithit);
                }
                if (value == "Company Men")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.companymen);
                }
                if (value == "The Way Back")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thewayback);
                }
                if (value == "Waiting for Forever")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.waitingforever);
                }
                if (value == "The Green Hornet")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.thegreenhornet);
                }
                if (value == "Death Race 2")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.deathrace2);
                }
                if (value == "The Mechanic")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.themechanic);
                }
                if (value == "Sanctum")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.sanctum);
                }
                if (value == "The Other Woman")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theotherwoman);
                }
                if (value == "The Eagle")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theeagle);
                }
                if (value == "Season of the Witch")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.seasonofthewitch);
                }
                if (value == "I am Number Four")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.iamnumberfour);
                }
                if (value == "The Rite")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.therite);
                }
                if (value == "The Roommate")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.theroommate);
                }
                if (value == "Gnomeo and Juliet")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.gnomeoandjuliet);
                }
                if (value == "Footloose")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.footloose);
                }
                if (value == "Real Steel")
                {
                    MoviePictureBox.Image = new Bitmap(Properties.Resources.realsteel);
                }
                
            }
        }

             /**
              *  @method CategoryListBox_SelectedIndexChanged
              *  Date Created : 19 august 2016
              * 
              * 
              * **/

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryIndexInteger = CategoryListBox.SelectedIndex;

            
                if (categoryIndexInteger == 0)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(comedyMovies);
                    CategoryTextBox.Text = category[0];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 1)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(dramaMovies);
                    CategoryTextBox.Text = category[1];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 2)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(actionMovies);
                    CategoryTextBox.Text = category[2];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 3)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(scifiMovies);
                    CategoryTextBox.Text = category[3];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 4)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(horrorMovies);
                    CategoryTextBox.Text = category[4];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 5)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(thrillerMovies);
                    CategoryTextBox.Text = category[5];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 6)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(familyMovies);
                    CategoryTextBox.Text = category[6];
                    CostTextBox.Text = downloadCost[0].ToString();
                }
                if (categoryIndexInteger == 7)
                {
                    MoviesListBox.Items.Clear();
                    MoviesListBox.Items.AddRange(newReleaseMovies);
                    CategoryTextBox.Text = category[7];
                    CostTextBox.Text = downloadCost[7].ToString();
                }
            
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            this.Hide();

                OrderForm aOrderForm = new OrderForm(MoviePictureBox.Image);
                aOrderForm.titleValue = TitleTextBox.Text;
                aOrderForm.categoryValue = CategoryTextBox.Text;
                aOrderForm.costValue = CostTextBox.Text;
                
                aOrderForm.ShowDialog();
                
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
