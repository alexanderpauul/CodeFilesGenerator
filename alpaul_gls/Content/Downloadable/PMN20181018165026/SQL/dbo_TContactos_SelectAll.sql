USE PMN
GO

CREATE PROCEDURE dbo.TContactos_GetAll
AS
	SELECT TContactoId, DscTContacto, Registro, Modificacion, Identificador, UsuarioId, EstadoId 
	  FROM dbo.TContactos