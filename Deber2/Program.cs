using System;

namespace Deber2
{
    class Program
    {
        public static bool ProdNombre { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDO");

            //llamado a las clases persona

            string nombre = " Jackson";
            string apellido = " Malacatos";
            string correo = "Jsm.gualan@yavirac.edu ";
            string telefono = "12154644";

            //instancia clases producto

            Producto productoVenta = new Producto
            {
                ProdCodigo = "C42342 ",
                ProdMarca = "  lemoflu ",
                TipoProducto = "tyrua"
            };



            string pregunta1 = "Juiiuf ";
            string pregunta2 = "Hulios 1kg ";
            string pregunta3 = " tre ";



            Enviado pedido = new Enviado
            {
                Producto = " Omeprazol ",
                Cantidad = " 32 mg",
                Ciudad = "   uiui ",
                Direccion = "Avenidas America "
            };
            string envio = " Lemonflu  ";
            string envio1 = " 5343";
            string envio2 = " Quito ";
            string envio3 = "Naciones Unidas";



            EntregaProducto factura = new EntregaProducto
            {
                DuenoProducto = " Stiven Valverde",
                EntregaCantidad = "  323GDFGDF4 ",
                CiudadDeLlegada = " Cuenca ",
                TipoDeTransporte = " Cuenca Parque calzados"
            };
            string producto = " Fernado Diaz ";
            string producto1 = "3423TRTER3";
            string producto2 = " Cuenca ";
            string producto3 = " 43242342";



            Persona primeraPersona = new Persona
            {
                Nombre = nombre,
                Apellido = apellido,
                Correo = correo,
                Telefono = telefono
            };
            string pregunto = "Stiven ";
            string pregunto1 = " Valverde ";
            string pregunto2 = " 79789";
            string pregunto3 = " Stivwen_valv@hotmail.com";



            string MiNombre = primeraPersona.MiNombre(pregunto);
            Console.WriteLine(MiNombre);
            string MiApellido = primeraPersona.MiApellido(pregunto1);
            Console.WriteLine(MiApellido);
            string MiCorreo = primeraPersona.MiCorreo(pregunto2);
            Console.WriteLine(MiCorreo);
            string MiNumero = primeraPersona.MiNumero(pregunto3);
            Console.WriteLine(MiNumero);


            string ProdCodigo = productoVenta.ProductoCodigo(pregunta1);
            Console.WriteLine(ProdCodigo);
            string ProdMarca = productoVenta.ProductoMarca(pregunta2);
            Console.WriteLine(ProdMarca);
            string TipoProducto = productoVenta.TipoDeProducto(pregunta3);
            Console.WriteLine(TipoProducto);


            string Producto = pedido.MarcaDeProducto(envio);
            Console.WriteLine(Producto);
            string Cantidad = pedido.NumeroDeProducto(envio1);
            Console.WriteLine(Cantidad);
            string Ciudad = pedido.CiudadDeDestino(envio2);
            Console.WriteLine(Ciudad);
            string Direccion = pedido.DireccionDondeDelEnvio(envio3);
            Console.WriteLine(Direccion);


            string DuenoProducto = factura.NombreDeDueno(producto);
            Console.WriteLine(DuenoProducto);
            string CantidadDeProducto = factura.CantidadDeProducto(producto1);
            Console.WriteLine(CantidadDeProducto);
            string CiudadDeLlegada = factura.llega(producto2);
            Console.WriteLine(CiudadDeLlegada);
            string TipoDeTransporte = factura.registro(producto3);
            Console.WriteLine(TipoDeTransporte);

            Console.ReadKey();
        }
    }
}
