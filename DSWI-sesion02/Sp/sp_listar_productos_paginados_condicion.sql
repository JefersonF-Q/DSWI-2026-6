
Create proc sp_listar_productos_paginados_condicion
(
	@pageSize int = 5, /*	Cantidad de elementos	*/
	@page int = 1	/*		Indice de pagina	*/,
	@nombre nvarchar(100) 
)
AS
BEGIN
	SET NOCOUNT ON	/*		DEsactiva el conteo de filas AFECTADAS	*/
	DECLARE @inicio  int = (@page -1) *@pageSize /*		Variable de inicio de pagina	*/
	SELECT	*  FROM Producto  
	where Nombre LIKE '%' + @nombre + '%'
	ORDER BY Nombre
	OFFSET @inicio rows	/*	Inicio de paginacion		*/
	fetch next @pageSize ROWS ONLY /*		Elementos Paginados		*/
END