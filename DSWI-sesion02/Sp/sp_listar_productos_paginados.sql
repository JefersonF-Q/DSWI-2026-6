
Create proc sp_listar_productos_paginados
(
	@pageSize int = 5, /*	Cantidad de elementos	*/
	@page int = 1	/*		Indice de pagina	*/
)
AS
BEGIN
	SET NOCOUNT ON	/*		DEsactiva el conteo de filas AFECTADAS	*/
	DECLARE @inicio  int = (@page -1) *@pageSize /*		Variable de inicio de pagina	*/
	SELECT	*  FROM Producto
	ORDER BY Nombre
	OFFSET @inicio rows	/*	Inicio de paginacion		*/
	fetch next @pageSize rows ONLY /*		Elementos Paginados		*/
END