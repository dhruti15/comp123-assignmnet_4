﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Name : Dhruti Patel
/// Student Id : 300857555
/// Date Created : 19 August 2016
/// </summary>
namespace Movie_Bonanza
{
    public partial class OrderForm : Form
    {
        private string title, category, cost;

        /*
         * 
         * @properties : titleValue,categoryValue,costValue
         * date Created : 19 August 2016
         * **/
        public string titleValue {
            get { return title; }
            set { title = value; }
        }
        public string categoryValue
        {
            get { return category; }
            set { category = value; }
        }
        public string costValue
        {
            get { return cost; }
            set { cost = value; }
        }

        public OrderForm()
        {
            InitializeComponent();
        }

        public OrderForm(System.Drawing.Image i)
        {
            InitializeComponent();
            MoviePictureBox.Image = i; 
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
        /*
         * @method Hide;
         * 
         * 
         * ***/
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();

            SelectionForm aSelectionForm = new SelectionForm();
            aSelectionForm.ShowDialog(); 
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = title;
            CategoryTextBox.Text = category;
            CostTextBox.Text = cost;
            decimal buyMovie = 10.00m;
            decimal subTotal = decimal.Parse(CostTextBox.Text);
            decimal salesTax = 0.13m * subTotal;
            decimal grandTotal = salesTax + subTotal; 

            if (BuyCheckBox.Checked)
            {
                AdditionalCostTextBox.Visible = true;
                AdditionalCostLabel.Visible = true; 
                decimal tempSubTotal = subTotal + buyMovie;
                decimal tempSalesTax = 0.13m * tempSubTotal;
                decimal tempGrandTotal = tempSalesTax + tempSubTotal; 
                subTotal = tempSubTotal;
                salesTax = tempSalesTax;
                grandTotal = tempGrandTotal;
                GrandTotalTextBox.Text = grandTotal.ToString("C"); 
                SubTotalTextBox.Text = subTotal.ToString("C");
                SalesTaxTextBox.Text = salesTax.ToString("C");
                AdditionalCostTextBox.Text = buyMovie.ToString("C"); 

            }
            else
            {
                AdditionalCostTextBox.Visible = false;
                AdditionalCostLabel.Visible = false; 
                SalesTaxTextBox.Text = salesTax.ToString("C");
                SubTotalTextBox.Text = subTotal.ToString("C");
                GrandTotalTextBox.Text = grandTotal.ToString("C"); 
            }
        }
        /*
         *  @method : StreamButton_Click
         *  @method : Hide
         *  Date created : 19 August 2016;
         * 
         * 
         * **/
        private void StreamButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StreamForm aStreamForm = new StreamForm();
            aStreamForm.titleValue = TitleTextBox.Text;
            aStreamForm.totalValue = GrandTotalTextBox.Text;
            aStreamForm.ShowDialog(); 
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        /*
         *  @method : aboutToolStripMenuItem_Click
         *  @Object : aSummaryForm
         * 
         * **/
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aSummaryForm = new AboutBox();
            // show the new form obejct
            aSummaryForm.ShowDialog();
        }
    }
}
