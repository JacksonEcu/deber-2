using System;
using System.Collections.Generic;
using System.Text;

namespace Deber2
{
    class Producto
    {
        public string ProdCodigo { get; set; }
        public string ProdMarca { get; set; }
        public string TipoProducto { get; set; }

        public string ProductoCodigo(string Codigo)
        {
            return $"Codigo de producto: {Codigo} codigos de productos :{this.ProdCodigo}";
        }
        public string ProductoMarca(string Marca)
        {
            return $"Marca de productos: {Marca} diferentes marcas : {this.ProdMarca}";
        }
        public string TipoDeProducto(string TipoProducto)
        {
            return $"Presentacion de producto: {TipoProducto} diferentes presentaciones :{this.TipoProducto}";
        }
    }
}
