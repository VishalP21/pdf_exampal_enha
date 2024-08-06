using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pdf_exampal_enha
{
    public class person
    {
        public bool isaudelt;
        public bool isbirthDay;
        public string sugest_email;
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string email { get; set; }
        private DateTime DOB { get; set; }

        public person(string firstName, string lastName, DateTime DOB)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = DOB;
            //this.email = email;
        }

        public void input()
        {
            isaudelt = DateTime.Now.Year - DOB.Year > 18 ? true : false;

            isbirthDay = (DateTime.Now.Month == DOB.Month) && (DateTime.Now.Day == DOB.Day) ? true : false;

            
            string sugest_email = firstName.Substring(0, 2) + lastName.Substring(0, 2) + DOB.Month + DOB.Day + DOB.Year + "@gmail.com";
            email = sugest_email;
        }

        public void display()
        {
            Console.WriteLine(isaudelt);
            Console.WriteLine(isbirthDay);
            Console.WriteLine(email);

        }

    }
}
