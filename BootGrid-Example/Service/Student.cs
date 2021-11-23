using BootGrid_Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootGrid_Example.Service
{
    public class StudentService
    {
        public List<Student> GetStudent()
        {
            List<Student> lstStudent = new List<Student>();
            for (int i = 0; i < 20; i++)
            {
                Student objStudent = new Student()
                {
                    Id = i,
                    Name = "Name" + i,
                    Address = "Address" + i
                };
                lstStudent.Add(objStudent);
            }

            return lstStudent;


        }


    }

    


}
