using System;
using System.Collections.Generic;
using System.Text;

namespace Deber2
{
    class Persona
    {
      
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string MiNombre(string Nombre)
        {
            return $"Mi nombre es: { Nombre} un gusto cual es su nombre : {this.Nombre}";
        }
        public string MiApellido(string Apellido)
        {
            return $"Mi Apellido es: {Apellido}  Y el tuyo :{this.Apellido }";
        }
        public string MiCorreo(string Correo)
        {
            return $"Mi correo es: {Correo} Y correo :{this.Correo}";
        }
        public string MiNumero(string Telefono)
        {
            return $"Mi numero es :{Telefono} cual es su numero telefonico :{ this.Telefono}";
        }

    }
}

