using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group5.Models
{
    public class Subject
    {
        public string SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectDv {  get; set; }
        public Subject(string SubjectId, string SubjectName, string SubjectDv) 
        {
            this.SubjectId = SubjectId;
            this.SubjectName = SubjectName;
            this.SubjectDv = SubjectDv;
        }

    }
}