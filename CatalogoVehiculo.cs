using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronIterador
{
    public class CatalogoVehiculo: Catalogo<Vehiculo,IteradorVehiculo>
    {
        public CatalogoVehiculo() 
        {
            contenido.Add(new Vehiculo("vehiculo economico"));
            contenido.Add(new Vehiculo("vehiculo pequeño economico"));
            contenido.Add(new Vehiculo("vehiculo premium"));
            contenido.Add(new Vehiculo("vehiculo troca de Jazmin"));
        }
    }
}
