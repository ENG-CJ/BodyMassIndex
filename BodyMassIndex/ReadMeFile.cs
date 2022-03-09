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
    public partial class ReadMeFile : KryptonForm
    {
        public ReadMeFile()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Back(object sender, EventArgs e)
        {
            Bmi bmi= new Bmi();
            bmi.Show();
            this.Hide();

        }
    }
}
