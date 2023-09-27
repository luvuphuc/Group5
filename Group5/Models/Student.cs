using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;

namespace Group5.Models
{
    public class Student
    {
        public string Name {  get; set; }
        public string Class { get; set; }
        public Student(string n, string c)
        {
            this.Name = n;
            this.Class = c;
        }
    }
    public class College : Student
    {
        public int mssv { get; set; }
        public string mahp {  get; set; }
        public College(int mssv,string n, string c, string mahp) : base(n, c)
        {
            this.mssv = mssv;
            this.mahp = mahp;
        }
    }
}