namespace PatronIterador
{
    public class Program
    {
        static void Main(string[] args)
        {
            CatalogoVehiculo catalogo = new CatalogoVehiculo();
            IteradorVehiculo iterador = catalogo.busqueda("Jazmin");
            Vehiculo vehiculo;
            iterador.inicio();
            vehiculo = iterador.item();
            while(vehiculo != null)
            {
                vehiculo.visualiza();
                iterador.siguiente();
                vehiculo = iterador.item();
            }
        }
    }
}