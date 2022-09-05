using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace Library
{
    public class Verificación
    {
        public string VerificarAppointment(Paciente paciente,Doctor doctor, string appoinmentPlace)
        {
            var isValid = true;
            this.Paciente=paciente;
            this.Doctor=doctor;
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");

            if (string.IsNullOrEmpty(paciente.PacientName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(paciente.PacientId))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(paciente.PacientPhone))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctor.DoctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();
        }

        public Paciente Paciente{ get; set ;}
        public Doctor Doctor{get ; set ;}

    }
}