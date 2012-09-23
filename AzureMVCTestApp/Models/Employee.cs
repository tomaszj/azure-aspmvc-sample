using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AzureMVCTestApp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public bool knowsAzure { get; set; }
    }
}