using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    [Serializable]
    internal class Student
    {
        public int Id { get; set; } 
        public string Name { get; set; }    
        public DateTime dob { get; set; }
        public string Address { get; set; }
        public string Avatar { get; set; }


        //STRING AVT, DƯỜNG DÃN

        // Constructor mặc định
        public Student() { }

        // Constructor với tham số
        public Student(int id, string name, DateTime dob, string address, string avatar)
        {
            Id = id;
            Name = name;
            this.dob = dob;
            Address = address;
            Avatar = avatar;
        }
    }
}
