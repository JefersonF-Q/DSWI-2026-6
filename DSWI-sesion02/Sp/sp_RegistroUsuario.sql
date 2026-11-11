CREATE PROCEDURE [dbo].[sp_RegistroUsuario]
(	@nombre nvarchar(100),
	@correo nvarchar(100),
	@clave nvarchar(100)
)
AS
	INSERT INTO Usuarios(nombre,correo,clave,fechaRegistro)
	VALUES (@nombre, @correo, @clave, GETdate());
GO