public class ProductoService
{
    // el nombre del producto no debe estar vacío
    public bool NombreValido(string nombre)
    {
        return !string.IsNullOrWhiteSpace(nombre);
    }

    // el precio debe ser mayor que cero
    public bool PrecioValido(decimal precio)
    {
        return precio > 0;
    }

    // Un producto es válido si cumple ambas condiciones
    public bool ProductoValido(string nombre, decimal precio)
    {
        return NombreValido(nombre) && PrecioValido(precio);
    }

    // comprobar si hay stock disponible
    public bool HayStock(int stock)
    {
        return stock > 0;
    }
}
