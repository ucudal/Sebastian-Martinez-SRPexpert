using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente1= new Paciente("Ralf Manson", "765655665", "5555-555-555");
            Doctor doctor1= new Doctor("");
            string  appointmentResult = new AppointmentService().CreateAppointment(paciente1, DateTime.Now, "Wall Street", doctor1,"ses-1233");
            Console.WriteLine(appointmentResult);
            string appointmentResult2 = new AppointmentService().CreateAppointment(paciente1, DateTime.Now,"",doctor1,"ses-1234");
            Console.WriteLine(appointmentResult2);
        }
    }
}
