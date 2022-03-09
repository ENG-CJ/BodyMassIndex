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
    public partial class MainForm : Form
    {
        private double BMI;
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            userTitle.Text = UserForm.UsernameLabel.ToUpper();
        }

        private void CheckBmi(object sender, EventArgs e)
        {
           if (Weight.Text=="" || Height.Text=="")
                MessageBox.Show("Input Required","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else
            {
                double weight = Double.Parse(Weight.Text);
                double height = Double.Parse(Height.Text);

                BMI = weight / (Math.Pow(height, height));
                ResultPannel.Visible = true;
                usernameTitle.Text = userTitle.Text;
                UserBMI.Text= BMI.ToString("0.##");
                WH.Text = weight.ToString();
                UserHieght.Text= height.ToString();
                if (BMICondition(BMI, Condition)) ;
            }
        }

        private bool BMICondition(double BMI,Label lableCondition)
        {
            bool isHighOrLow=false;
            if (BMI >= 18 && BMI <= 25)
            {
                isHighOrLow = true;
                lableCondition.Text = "Normal";
            }
            else if (BMI > 25)
                lableCondition.Text = "Over Weight";
            else
                lableCondition.Text = "Under Weigh";
            return isHighOrLow;
        }

        private void HideResultPanel(object sender ,EventArgs e)
        {
            Weight.Text = "";
            Height.Text = "";
            Weight.Focus();
            ResultPannel.Visible = false;
        }

        private void ResultPannel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
