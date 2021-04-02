using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class ClientForm1 : Form
    {
        // created synchronous socket lister
        SynchronousSocketClient ssl = new SynchronousSocketClient();
        public ClientForm1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Send the user entry to the console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Whatever they type it, it will go to the contact server method
            TxtBoxResponse.Text = ssl.ContactServer(TxtBoxRequest.Text);
        }
    }
}
