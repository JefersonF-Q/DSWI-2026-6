CREATE PROC sp_agregar_producto
(
	@Nombre nvarchar(100) = null,
	@Precio decimal(10,2) = null,
	@Cantidad int = null,
	@Estado bit = null
)
as
INSERT INTO Producto(
	Nombre,
	Precio,
	Cantidad,
	Estado
)
VALUES(
	@Nombre,
	@Precio,
	@Cantidad,
	@Estado
)