using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TA__
{
   
    public class Doctor
    {
        
        public string Name { get; set; }
        
        public int CountOfPacientd { get; set; }

        [JsonPropertyName("XZ")]
        public int DepartmentNumber { get; set; }
        public string Specialization { get; set; }
        
        public Doctor(string name, int countOfPacientd, int departmentNumber, string specialization)
        {
            Name = name;
            CountOfPacientd = countOfPacientd;
            DepartmentNumber = departmentNumber;
            Specialization = specialization;
        }
    }
}
