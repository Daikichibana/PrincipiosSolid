namespace SolidConsolaEjemplos.SRP.Despues
{
    public class Item
    {
        public int Cantidad { get; set; }
        public Producto Producto { get; set; }

        public Item(Producto producto, int cantidad)
        {
            this.Producto = producto;
            this.Cantidad = cantidad;
        }

        public double SubTotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}
