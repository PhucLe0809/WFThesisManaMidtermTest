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
using ThesisManagementProject.Forms;
using ThesisManagementProject.Models;

namespace ThesisManagementProject
{
    public partial class UCThesisNotCompleted : UserControl
    {
        private People people = new People();
        private NotCompletedDAO notCompletedDAO = new NotCompletedDAO();
        private List<NotCompleted> listNotCompleted = new List<NotCompleted>();

        public UCThesisNotCompleted()
        {
            InitializeComponent();
        }
        public void SetUpUserControl(People people)
        {
            this.people = people;
            listNotCompleted = notCompletedDAO.SelectListNotCompleted(people);
            
            flpStudentList.Controls.Clear();
            foreach (NotCompleted notCompleted in listNotCompleted)
            {
                UCPeopleMiniLine line = new UCPeopleMiniLine();
                line.SetSize(new Size(1230, 60));
                line.SetNotCompletedMode(notCompleted);
                line.ViewNotCompletedClicked += Line_ViewNotCompletedClicked;
                flpStudentList.Controls.Add(line);
            }
        }
        private void Line_ViewNotCompletedClicked(object sender, EventArgs e)
        {
            UCPeopleMiniLine line = sender as UCPeopleMiniLine;

            if (line != null)
            {
                FThesisStop fThesisStop = new FThesisStop();
                fThesisStop.SetViewMode(line.GetNotCompleted);
                fThesisStop.ShowDialog();
            }
        }
    }
}
