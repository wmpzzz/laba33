using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;

namespace laba33
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            string FileText = File.ReadAllText("C:\\Users\\POMAXA\\source\\repos\\laba33\\laba33\\Logins.Txt");
            if (FileText.Contains(Convert.ToString(LoginTextBox.Text))) { 
                MessageBox.Show("Вы успешно авторизовались");
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы не зарегстирорваны");
            }
        }
    }
}
