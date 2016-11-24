using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GettingReal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void registereName_TextChanged(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void registereUser_Click(object sender, EventArgs e)
        {

        }

        private void loginUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginEnter_Click(object sender, EventArgs e)
        {
            // Show another form.
            this.Hide();
            Kalve calf = new Kalve();
            calf.Closed += (s, args) => this.Close();
            calf.Show();
        }
    }
}
