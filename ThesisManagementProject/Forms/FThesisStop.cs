using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThesisManagementProject.DAOs;
using ThesisManagementProject.Database;
using ThesisManagementProject.Models;
using ThesisManagementProject.Process;

namespace ThesisManagementProject.Forms
{
    public partial class FThesisStop : Form
    {
        public event EventHandler Stopped;
        private MyProcess myProcess = new MyProcess();
        private People people = new People();
        private Team team = new Team();
        private Thesis thesis = new Thesis();
        private PeopleDAO peopleDAO = new PeopleDAO();
        private ThesisDAO thesisDAO = new ThesisDAO();
        private ThesisStatusDAO thesisStatusDAO = new ThesisStatusDAO();
        private DBConnection dBConnection = new DBConnection();

        public FThesisStop()
        {
            InitializeComponent();
        }
        public FThesisStop(People people, Team team, Thesis thesis)
        {
            InitializeComponent();
            this.people = people;
            this.team = team;
            this.thesis = thesis;
            InitUserControl();
        }
        private void InitUserControl()
        {
            gTextBoxTopic.Text = thesis.Topic;
            gTextBoxTopic.FillColor = SystemColors.ControlLight;
            gTextBoxTopic.BorderThickness = 0;
            gButtonCancel.Focus();
        }
        public void SetViewMode(NotCompleted notCompleted)
        {
            this.people = peopleDAO.SelectOnlyByID(notCompleted.IdAccount);
            this.thesis = thesisDAO.SelectOnly(notCompleted.IdThesis);
            InitUserControl();
            gTextBoxReason.Text = notCompleted.Reason;
            gTextBoxReason.FillColor = SystemColors.ControlLight;
            gTextBoxReason.BorderThickness = 0;

            gButtonConfirm.Hide();
            gButtonCancel.Location = new Point(693, 426);
            gButtonCancel.Show();
            gButtonCancel.Focus();
        }
        private void gButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void gButtonConfirm_Click(object sender, EventArgs e)
        {
            if (gTextBoxReason.Text != string.Empty)
            {
                DialogResult result = MessageBox.Show("Are you sure you can't complete this " + thesis.Topic + " thesis",
                                                        "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    thesisDAO.UpdateStatus(thesis, EThesisStatus.NotCompleted);
                    thesisStatusDAO.UpdateThesisStatus(team.IDTeam, thesis.IdThesis, EThesisStatus.NotCompleted);

                    string command = string.Format("INSERT INTO {0} VALUES ('{1}', '{2}', '{3}', '{4}')", MyDatabase.DBNotCompleted,
                                                    thesis.IdThesis, thesis.IdInstructor, people.IdAccount, gTextBoxReason.Text);
                    dBConnection.SQLExecuteByCommand(command);

                    Stopped?.Invoke(this, e);
                    this.Close();
                }
            }
            else
            {
                myProcess.RunCheckDataValid(gTextBoxReason.Text != string.Empty, erpReason, gTextBoxReason, "Reason cannot be left blank");
            }
        }
        private void gTextBoxReason_TextChanged(object sender, EventArgs e)
        {
            myProcess.RunCheckDataValid(gTextBoxReason.Text != string.Empty, erpReason, gTextBoxReason, "Reason cannot be left blank");
        }
    }
}
