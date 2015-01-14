using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS.login
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Login Button
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            login.loginLogic authentication = new loginLogic();
            if (radioButtonAdmin.Checked == true)
                labelLoginError.Text = authentication.athunticate(radioButtonAdmin.Text, textBoxUserName.Text, textBoxPassword.Text);
            else
                labelLoginError.Text = authentication.athunticate(radioButtonDoctor.Text, textBoxUserName.Text, textBoxPassword.Text);
            if (labelLoginError.Text == "true")
            {
                this.Hide();
                CMS.clientGui client = new CMS.clientGui();
                client.Show();
                //this.Close();
            }
            else
                labelLoginError.Visible = true;
            this.Validate();
        }

        //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> cancel Button
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
