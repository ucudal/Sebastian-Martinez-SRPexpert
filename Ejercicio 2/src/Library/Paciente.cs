using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library
{
    public class Paciente
    {
        public Paciente(string name, string id, string phoneNumber)
        {
            this.PacientName= name;
            this.PacientId= id;
            this.PacientPhone= phoneNumber;

        }
        public string PacientName{get ; set ;}
        public string PacientId{get ; set ;}
        public string PacientPhone{get ; set ;}
    }
}