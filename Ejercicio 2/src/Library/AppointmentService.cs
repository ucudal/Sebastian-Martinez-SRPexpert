using System;
using System.Text;

namespace Library
{
    public class AppointmentService
    {
        public string CreateAppointment(Paciente paciente, DateTime date, string appoinmentPlace,Doctor doctor,string códigoidentificador)
        {
            string verificar= new Verificación().VerificarAppointment(paciente,doctor,appoinmentPlace);
            return verificar;
        }
        public Paciente Paciente{ get; set ;}
        public Doctor Doctor{get ; set ;}
        public Verificación verificar{get ; set;}
        

    }
}

/*
Esta clase no cumple con los patrones y principios SRP y Expert.
Esta no cumple ya que si quisiéramos agregar otros datos del paciente como por ejemplo su edad o agregar otros datos al Doctor como por ejemplo su especialidad.
Deberíamos de modificar toda la clase AppointmentService.
Agregando otros datos al Paciente y al Doctor estamos agregando también datos para verificar.
Por eso sería correcto crear una clase que verifique todos los datos del Paciente y del Doctor y a su vez imprima la consulta si esta es correcta.
Esta clase tendría como clases asociadas a las clases Paciente y Doctor.
AppointmentService está asociada a Verificación y tiene como responsabilidad retornar el resultado de Verificación y guardar la fecha y el código identificador .


*/
