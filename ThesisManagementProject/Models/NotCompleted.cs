using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisManagementProject.Models
{
    public class NotCompleted
    {
        private string idthesis;
        private string idinstructor;
        private string idaccount;
        private string reason;

        public NotCompleted() { }
        public NotCompleted(string idthesis, string idinstructor, string idaccount, string reason) 
        {
            this.idthesis = idthesis;
            this.idinstructor = idinstructor;
            this.idaccount = idaccount;
            this.reason = reason;
        }
        public string IdThesis
        {
            get { return this.idthesis; }
        }
        public string IdInstructor
        {
            get { return this.idinstructor; }
        }
        public string IdAccount
        { 
            get { return this.idaccount; } 
        }
        public string Reason
        { 
            get { return this.reason; } 
        }
    }
}
