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
    // naming convention for the db
    Model1 jb = new Model1();

    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Auto resize the data grid view depending on the string size of the jelly belly name
        /// </summary>
        public void AdjustColumns()
        {
            dgvFlavors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgvFlavors.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
        }
        /// <summary>
        /// Filter through the list as the user inputs the jelly belly type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<JellyBelly> jbList = (from j in jb.JellyBellies
                                       where j.jellyBellyFlavor.Contains(TxtBoxSearch.Text)
                                       select j).ToList();
            dgvFlavors.DataSource = jbList;
        }
        /// <summary>
        /// display the list in a data grid view and adjust the columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            List<JellyBelly> jbList = (from j in jb.JellyBellies
                                       select j).ToList();
            dgvFlavors.DataSource = jbList;
            AdjustColumns();
        }
        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
