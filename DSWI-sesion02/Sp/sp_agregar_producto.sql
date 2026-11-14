CREATE PROC sp_agregar_producto
(
	@Nombre nvarchar(100) = null,
	@Precio decimal(10,2) = null,
	@Cantidad int = null,
	@Estado bit = null
)
as
INSERT INTO Producto(
	Id,
	Nombre,
	Precio,
	Cantidad,
	Estado
)
VALUES(
	default,
	@Nombre,
	@Precio,
	@Cantidad,
	@Estado
)