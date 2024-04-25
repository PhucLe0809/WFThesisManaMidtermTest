using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisManagementProject.Database;
using ThesisManagementProject.Models;
using ThesisManagementProject.Process;

namespace ThesisManagementProject.DAOs
{
    internal class NotCompletedDAO : DBConnection
    {
        public List<NotCompleted> SelectListNotCompleted(People instructor)
        {
            string command = string.Format("SELECT * FROM {0} WHERE idinstructor = '{1}'", MyDatabase.DBNotCompleted, instructor.IdAccount);

            DataTable dataTable = Select(command);

            List<NotCompleted> list = new List<NotCompleted>();
            foreach (DataRow row in dataTable.Rows)
            {
                list.Add(GetFromDataRow(row));
            }

            return list;
        }
        public NotCompleted GetFromDataRow(DataRow row)
        {
            string idthesis = row["idthesis"].ToString();
            string idinstructor = row["idinstructor"].ToString();
            string idaccount = row["idaccount"].ToString();
            string reason = row["reason"].ToString();

            NotCompleted notCompleted = new NotCompleted(idthesis, idinstructor, idaccount, reason);

            return notCompleted;
        }
    }
}
