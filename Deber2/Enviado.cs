using System;
using System.Collections.Generic;
using System.Text;

namespace Deber2
{
    class Enviado
    {
       public string Producto { get; set; }
    public string Cantidad { get; set; }
    public string Ciudad { get; set; }
    public string Direccion { get; set; }

    //comportamientos de la clases
    public string MarcaDeProducto(string Producto)
    {
        return $"Referencias del producto :{Producto} otros productos para la entrega : {this.Producto}";
    }
    public string NumeroDeProducto(string Cantidad)
    {
        return $"Cantidad de producto que sale : {Cantidad} cantidad de producto que se entrega  :{this.Cantidad}";
    }
    public string CiudadDeDestino(string Ciudad)
    {
        return $"Ciudad de donde sale el pedido: {Ciudad} ciudad de llegada :{this.Ciudad}";
    }
    public string DireccionDondeDelEnvio(string Direccion)
    {
        return $"Direccion de salida del producto: {Direccion} destino de lleganda :{this.Direccion}";
    }
}
}

