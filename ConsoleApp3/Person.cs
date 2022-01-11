using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        private decimal Salary;

       
        public string IntroduceYourself()
        {
            string full = this.Name + " " + this.Surname + " " + this.Age + " " + this.Salary;
            return full;
        }


        public void MakeSalary()
        {
            this.Salary = 1500;
        }

        //Bir kitabxanamiz var. Kitabxanada çoxlu kitablar və həmin kitablardan istifadə edən Müştərilər.

        //Kitabın adı , səhifə sayı , müəllifinin adı , yerləşdiyi rəfin nömrəsi var.

        //Müştərinin adı , soyadı , adında olan kitabların massivi var.


    }
}
