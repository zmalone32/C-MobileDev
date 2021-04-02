using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JellyBellyAcheCentral
{
    CategoryForm fForm = CategoryForm();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Show the form and direct when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowFlavorCat_Click(object sender, EventArgs e)
        {
            fForm.Show();
        }
    }
}
