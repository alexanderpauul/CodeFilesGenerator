USE PMN
GO

CREATE PROCEDURE dbo.Contactos_GetAll
AS
	SELECT ContactoId, DscContacto, TContactoId, PersonaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.Contactos