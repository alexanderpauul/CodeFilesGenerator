USE PHAO20180925
GO

CREATE PROCEDURE dbo.Personas_GetAll
AS
	SELECT PersonaId, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, PaisId, NacionalidadId, SexoId, ECivilId, UserId, Registro, Modificacion, Identificador, EstadoId 
	  FROM dbo.Personas