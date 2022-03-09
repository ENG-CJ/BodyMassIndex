using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
namespace BodyMassIndex
{
    public partial class Bmi :KryptonForm
    {
        public Bmi()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReadMe(object sender, EventArgs e)
        {
            ReadMeFile readMe=new ReadMeFile();
            readMe.Show();
            this.Hide();
        }

        private void GetStarted(object sender, EventArgs e)
        {
            UserForm user =new UserForm();
            user.Show();
            this.Hide();

        }
    }
}
