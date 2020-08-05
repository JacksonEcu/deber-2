using System;
using System.Collections.Generic;
using System.Text;

namespace Deber2
{
    class EntregaProducto
    {
        public string DuenoProducto { get; set; }
        public string EntregaCantidad { get; set; }
        public string CiudadDeLlegada { get; set; }
        public string TipoDeTransporte { get; set; }

        //comportamientos de la clases
        public string NombreDeDueno(string DuenoProducto)
        {
            return $"Quien recibe el producto: {DuenoProducto} nombre del dueno : {this.DuenoProducto}";
        }
        public string CantidadDeProducto(string EntregaCantidad)
        {
            return $"numero de pedido o envio : {EntregaCantidad} codigo del envio : {this.EntregaCantidad}";
        }
        public string llega(string CiudadDeLlegada)
        {
            return $"ciudad de donde sale el producto : {CiudadDeLlegada} ciudad de destino de los productos : {this.CiudadDeLlegada}";
        }
        public string registro(string TipoDeTransporte)
        {
            return $"Guia de transporte : {TipoDeTransporte} oficial de lleganda :{this.TipoDeTransporte}";
        }
    }
}
