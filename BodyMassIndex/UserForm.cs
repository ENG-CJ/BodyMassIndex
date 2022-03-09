using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyMassIndex
{
    public partial class UserForm : Form
    {
        public static string usernameLabel;
        public UserForm()
        {
            InitializeComponent();
        }

        private void RemoveWaterMark(object sender, MouseEventArgs e)
        {
         
        }

        public static string UsernameLabel { get { return usernameLabel; } }

        // next page 
        private void Next(object sender, EventArgs e)
        {
          
            usernameLabel=userFormName.Text;
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
