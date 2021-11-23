using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootGrid_Example.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class DataFormate
    {
        public int current { get; set; }
        public int rowCount { get; set; }
        public int total { get; set; }
        public string searchPhrase { get; set; }
        public List<Student> rows { get; set; }
    }
}