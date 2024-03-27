﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisManagementProject.Models;
using ThesisManagementProject.Process;

namespace ThesisManagementProject
{
    public partial class UCTeamMiniLine : UserControl
    {
        private MyProcess myProcess = new MyProcess();
        public event EventHandler ThesisAddAccepted;
        private Team team = new Team();

        public UCTeamMiniLine()
        {
            InitializeComponent();
        }
        public UCTeamMiniLine(Team team)
        {
            InitializeComponent();

            SetInformation(team);
        }

        #region PROPERTIES

        public Team GetTeam
        {
            get { return this.team; }
        }

        #endregion

        #region FUNCTIONS 

        public void SetInformation(Team team)
        {
            this.team = team;
            InitUserControl();
        }
        private void InitUserControl()
        {
            gCirclePictureBoxAvatar.Image = myProcess.NameToImage(team.AvatarName);
            lblTeamName.Text = team.TeamName;
            lblTeamCode.Text = team.IDTeam;
            gTextBoxTeamMemebrs.Text = team.Members.Count.ToString() + " members";
        }

        #endregion

        #region EVENT CONTROLS

        private void gShadowPanelBack_Click(object sender, EventArgs e)
        {
            FTeamDetails fTeamDetails = new FTeamDetails(team);
            fTeamDetails.ShowDialog();
        }
        private void gButtonAdd_Click(object sender, EventArgs e)
        {
            ThesisAddAcceptedClicked(EventArgs.Empty);
        }
        public virtual void ThesisAddAcceptedClicked(EventArgs e)
        {
            ThesisAddAccepted?.Invoke(this, e);
        }

        #endregion

    }
}
