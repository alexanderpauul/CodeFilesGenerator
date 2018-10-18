USE PHAO20180925
GO

CREATE PROCEDURE dbo.Personas_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT PersonaId, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, PaisId, NacionalidadId, SexoId, ECivilId, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.Personas 
	 WHERE PersonaId = @valueUSE PHAO20180925
GO

CREATE PROCEDURE dbo.Personas_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT PersonaId, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, PaisId, NacionalidadId, SexoId, ECivilId, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.Personas 
	 WHERE PersonaId = @value