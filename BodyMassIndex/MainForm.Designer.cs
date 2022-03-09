namespace BodyMassIndex
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userTitle = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.WLabel = new System.Windows.Forms.Label();
            this.Weight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.HLabel = new System.Windows.Forms.Label();
            this.Height = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.check = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ResultPannel = new System.Windows.Forms.Panel();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Condition = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UserBMI = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.UserHieght = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.WH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.usernameTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ResultPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.userTitle);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 79);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BodyMassIndex.Properties.Resources.unknown;
            this.pictureBox1.Location = new System.Drawing.Point(26, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userTitle
            // 
            this.userTitle.AutoSize = true;
            this.userTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTitle.ForeColor = System.Drawing.Color.White;
            this.userTitle.Location = new System.Drawing.Point(99, 18);
            this.userTitle.Name = "userTitle";
            this.userTitle.Size = new System.Drawing.Size(212, 38);
            this.userTitle.TabIndex = 0;
            this.userTitle.Text = "USERNAME";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BodyMassIndex.Properties.Resources.fitness;
            this.pictureBox2.Location = new System.Drawing.Point(378, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(549, 407);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WLabel.ForeColor = System.Drawing.Color.Blue;
            this.WLabel.Location = new System.Drawing.Point(39, 172);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(101, 40);
            this.WLabel.TabIndex = 2;
            this.WLabel.Text = "Weight";
            // 
            // Weight
            // 
            this.Weight.Location = new System.Drawing.Point(39, 212);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(261, 34);
            this.Weight.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.Weight.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.Weight.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.Weight.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Weight.StateCommon.Border.Rounding = 7;
            this.Weight.StateCommon.Border.Width = 0;
            this.Weight.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Weight.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weight.TabIndex = 3;
            // 
            // HLabel
            // 
            this.HLabel.AutoSize = true;
            this.HLabel.Font = new System.Drawing.Font("Poppins SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HLabel.ForeColor = System.Drawing.Color.Blue;
            this.HLabel.Location = new System.Drawing.Point(37, 273);
            this.HLabel.Name = "HLabel";
            this.HLabel.Size = new System.Drawing.Size(93, 40);
            this.HLabel.TabIndex = 2;
            this.HLabel.Text = "Height";
            this.HLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Height
            // 
            this.Height.Location = new System.Drawing.Point(37, 315);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(261, 34);
            this.Height.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(84)))));
            this.Height.StateCommon.Border.Color1 = System.Drawing.Color.Navy;
            this.Height.StateCommon.Border.Color2 = System.Drawing.Color.Navy;
            this.Height.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Height.StateCommon.Border.Rounding = 7;
            this.Height.StateCommon.Border.Width = 0;
            this.Height.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.Height.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Height.TabIndex = 3;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(39, 377);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(135, 42);
            this.check.TabIndex = 4;
            this.toolTip1.SetToolTip(this.check, "Check Your BMI");
            this.check.Values.Text = "Check";
            this.check.Click += new System.EventHandler(this.CheckBmi);
            // 
            // ResultPannel
            // 
            this.ResultPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ResultPannel.Controls.Add(this.kryptonButton1);
            this.ResultPannel.Controls.Add(this.Condition);
            this.ResultPannel.Controls.Add(this.label9);
            this.ResultPannel.Controls.Add(this.UserBMI);
            this.ResultPannel.Controls.Add(this.label7);
            this.ResultPannel.Controls.Add(this.UserHieght);
            this.ResultPannel.Controls.Add(this.label5);
            this.ResultPannel.Controls.Add(this.WH);
            this.ResultPannel.Controls.Add(this.label3);
            this.ResultPannel.Controls.Add(this.usernameTitle);
            this.ResultPannel.Controls.Add(this.label1);
            this.ResultPannel.Location = new System.Drawing.Point(1, 76);
            this.ResultPannel.Name = "ResultPannel";
            this.ResultPannel.Size = new System.Drawing.Size(926, 447);
            this.ResultPannel.TabIndex = 5;
            this.ResultPannel.Visible = false;
            this.ResultPannel.Paint += new System.Windows.Forms.PaintEventHandler(this.ResultPannel_Paint);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(568, 136);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(199, 83);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 6;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.kryptonButton1, "Hide The Result Pane");
            this.kryptonButton1.Values.Text = "Hide Result";
            this.kryptonButton1.Click += new System.EventHandler(this.HideResultPanel);
            // 
            // Condition
            // 
            this.Condition.AutoSize = true;
            this.Condition.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condition.ForeColor = System.Drawing.Color.White;
            this.Condition.Location = new System.Drawing.Point(232, 290);
            this.Condition.Name = "Condition";
            this.Condition.Size = new System.Drawing.Size(116, 53);
            this.Condition.TabIndex = 0;
            this.Condition.Text = "VALUE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(95, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Condition:";
            // 
            // UserBMI
            // 
            this.UserBMI.AutoSize = true;
            this.UserBMI.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBMI.ForeColor = System.Drawing.Color.White;
            this.UserBMI.Location = new System.Drawing.Point(232, 227);
            this.UserBMI.Name = "UserBMI";
            this.UserBMI.Size = new System.Drawing.Size(172, 53);
            this.UserBMI.TabIndex = 0;
            this.UserBMI.Text = "BMI Value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(95, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "BMI:";
            // 
            // UserHieght
            // 
            this.UserHieght.AutoSize = true;
            this.UserHieght.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserHieght.ForeColor = System.Drawing.Color.White;
            this.UserHieght.Location = new System.Drawing.Point(232, 166);
            this.UserHieght.Name = "UserHieght";
            this.UserHieght.Size = new System.Drawing.Size(124, 53);
            this.UserHieght.TabIndex = 0;
            this.UserHieght.Text = "Height";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(95, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "Height: ";
            // 
            // WH
            // 
            this.WH.AutoSize = true;
            this.WH.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WH.ForeColor = System.Drawing.Color.White;
            this.WH.Location = new System.Drawing.Point(232, 106);
            this.WH.Name = "WH";
            this.WH.Size = new System.Drawing.Size(133, 53);
            this.WH.TabIndex = 0;
            this.WH.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Weight: ";
            // 
            // usernameTitle
            // 
            this.usernameTitle.AutoSize = true;
            this.usernameTitle.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTitle.ForeColor = System.Drawing.Color.White;
            this.usernameTitle.Location = new System.Drawing.Point(232, 53);
            this.usernameTitle.Name = "usernameTitle";
            this.usernameTitle.Size = new System.Drawing.Size(181, 53);
            this.usernameTitle.TabIndex = 0;
            this.usernameTitle.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 510);
            this.Controls.Add(this.ResultPannel);
            this.Controls.Add(this.check);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.HLabel);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResultPannel.ResumeLayout(false);
            this.ResultPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userTitle;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label WLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Weight;
        private System.Windows.Forms.Label HLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox Height;
        private ComponentFactory.Krypton.Toolkit.KryptonButton check;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel ResultPannel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.Label Condition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label UserBMI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label UserHieght;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label WH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label usernameTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}