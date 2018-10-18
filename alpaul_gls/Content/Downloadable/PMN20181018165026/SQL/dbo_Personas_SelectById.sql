USE PMN
GO

CREATE PROCEDURE dbo.Personas_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT PersonaId, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, PaisId, NacionalidadId, SexoId, ECivilId, Registro, Modificacion, Identificador, UsuarioId 
	  FROM dbo.Personas 
	 WHERE PersonaId = @value