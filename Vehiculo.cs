using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterador
{
    public class Vehiculo : Elemento
    {
        public Vehiculo(string descripcion) : base(descripcion) { }
        public void visualiza()
        {
            Console.WriteLine("Descripcion del vehiculo: " + descripcion); 
        }
    }
}
