namespace BACKENDELCAPITAL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public class Cliente
        {
            public int Id { get; set; }
            public string TipoDocumento { get; set; }
            public string NumeroDocumento { get; set; }
            public List<Restriccion> Restricciones { get; set; }
            public List<Paquete> Paquetes { get; set; }
            public List<Prestamo> Prestamos { get; set; }

            public Cliente()
            {
                Restricciones = new List<Restriccion>();
                Paquetes = new List<Paquete>();
                Prestamos = new List<Prestamo>();
            }
        }

        public class Restriccion
        {
            public int Id { get; set; }
            public string Motivo { get; set; }
            public DateTime FechaVigencia { get; set; }
        }

        public abstract class Producto
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }

        public class Paquete : Producto
        {
            public bool Crediticio { get; set; }
            public List<TarjetaCredito> TarjetasCredito { get; set; }

            public Paquete()
            {
                TarjetasCredito = new List<TarjetaCredito>();
            }
        }

        public class TarjetaCredito
        {
            public int Id { get; set; }
            public string Codigo { get; set; }
        }

        public class Prestamo : Producto
        {
            public string Tipo { get; set; }
        }

        public class SolicitudPaquete
        {
            public int Id { get; set; }
            public Cliente Cliente { get; set; }
            public Paquete Paquete { get; set; }
            public bool Aprobada { get; set; }
            public DateTime FechaAprobacion { get; set; }
        }

        public class FormularioRaiz
        {
            public int Id { get; set; }
            public SolicitudPaquete SolicitudPaquete { get; set; }
        }

        public class FormularioRechazo
        {
            public int Id { get; set; }
            public SolicitudPaquete SolicitudPaquete { get; set; }
            public string MotivoRechazo { get; set; }
            public DateTime FechaRechazo { get; set; }
        }

        public class SolicitudPrestamo
        {
            public int Id { get; set; }
            public Cliente Cliente { get; set; }
            public Prestamo Prestamo { get; set; }
            public FormularioRaiz FormularioRaiz { get; set; }
        }
    }
 }