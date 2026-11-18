using DSWI_sesion02.Models;
using DSWIsesion02.Migrations;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.Data.SqlClient;

namespace DSWI_sesion02.Data
{
    public class ProductoRepository
    {
        private readonly string _cadena;
        public ProductoRepository(IConfiguration configuracion)
        {
            _cadena = configuracion.GetConnectionString("DefaultConnection");
        }
        public async Task AgregarProducto(Producto producto)
        {
            var sql = "INSERT INTO Producto(Nombre,Precio,Cantidad,Estado)VALUES(@Nombre,@Precio,@Cantidad,@Estado)";
            using (var conn = new SqlConnection(_cadena))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                cmd.Parameters.AddWithValue("@Estado", producto.Estado);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }

        }

        //Funcion para insertar usando procedimiento almacenado
        public async Task AgregarProductoSP(Producto producto)
        {
            var sql = "sp_agregar_producto";
            using (var conn = new SqlConnection(_cadena))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                cmd.Parameters.AddWithValue("@Estado", producto.Estado);
                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }

        }

    }
}