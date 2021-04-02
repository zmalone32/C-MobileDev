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
    public partial class JellyBellyForm : Form
    {
        // jelly belly db name
        JellyBelly db = new JellyBelly();

        /// instantiate the columns listed
        public JellyBellyForm()
        {
            InitializeComponent();
            LvCategory.Columns.Add("Category");
            LvCategory.Columns.Add("Number of Flavors");
        }
        /// <summary>
        /// for each of te items, bring the category with the item list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JellyBellyForm_Load(object sender, EventArgs e)
        {
            // grab the category and count the toal of jelly bellies
            var jbCat = db.jellyBellyFlavor.GroupBy(c => c.category).Select(
                cat => new CategoryTotal
                {

                    Category = cat.Key,
                    Total = cat.Count()
                });
            // Display the results of the count in a string array and add the list view item
            foreach (CategoryTotal item in jbCat)
            {
                String[] listValues = { item.Category, item.Total.ToString() };
                ListViewItem lvi = new ListViewItem(listValues);
                LvCategory.Items.Add(lvi);
            }
            // Auto resize the columns
            LvCategory.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            LvCategory.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);

        }

        /// <summary>
        /// Close the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
