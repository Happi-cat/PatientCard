using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PatientCard.Data;
using PatientCard.Logic;

namespace PatientCard.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

	    private void buttonOk_Click(object sender, EventArgs e)
	    {
		    if (DataManager.ClinicDataSet.Users.Any(n => n.Username == textBoxUsername.Text && n.Password == textBoxPassword.Text))
		    {
		        var dbUser = DataManager.ClinicDataSet.Users.First(n => n.Username == textBoxUsername.Text);
                AuthManager.CurrentUser = new AuthManager.User
                    {
                        FirstName =  dbUser.FirstName,
                        MiddleName = dbUser.MiddleName,
                        LastName = dbUser.LastName,
                        Username = dbUser.Username,
                    };
			    DialogResult = DialogResult.OK;
		    }
		    else
		    {
			    DialogResult = DialogResult.Cancel;
		    }
	    }
    }
}
