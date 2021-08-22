using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ytSendMail
{
    public partial class TestEamil : Form
    {
        public TestEamil()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Fax.Common.Mail.SendJmail(txtServer.Text, txtUserAccount.Text, txtPwd.Text, txtReceive.Text, txtSubject.Text, txtBody.Text, "", "MeetingTel","43");
        }
    }
}
