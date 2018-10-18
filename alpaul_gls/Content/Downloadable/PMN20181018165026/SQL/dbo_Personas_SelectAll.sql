USE PMN
GO

CREATE PROCEDURE dbo.Personas_GetAll
AS
	SELECT PersonaId, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, PaisId, NacionalidadId, SexoId, ECivilId, Registro, Modificacion, Identificador, UsuarioId 
	  FROM dbo.Personas