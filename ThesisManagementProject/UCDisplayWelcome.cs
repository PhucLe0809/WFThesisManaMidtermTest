﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ThesisManagementProject
{
    public partial class UCDisplayWelcome : UserControl
    {
        public UCDisplayWelcome()
        {
            InitializeComponent();
        }

        #region PROPERTIES

        public Guna2GradientButton GGradientButtonLecture
        {
            get { return this.gGradientButtonLecture; }
        }

        public Guna2GradientButton GGradientButtonRegister
        {
            get { return this.gGradientButtonRegister; }
        }

        public Guna2Button GButtonLogin
        {
            get { return this.gButtonLogin; }
        }

        #endregion

        #region METHOD

        private void gButtonLogin_Click(object sender, EventArgs e)
        {

        }
        private void gGradientButtonRegister_Click(object sender, EventArgs e)
        {

        }
        private void gGradientButtonLecture_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
