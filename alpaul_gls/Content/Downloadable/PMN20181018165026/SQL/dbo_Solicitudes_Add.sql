USE PMN
GO

CREATE PROCEDURE dbo.Solicitudes_Add
(
       @SolicitudId int, @TSolicitudId int, @NoAprobacion nvarchar, @FechaAprobacion datetime, @Indice nvarchar, @CreditosCursados nvarchar, @PeriodoIngreso nvarchar, @PersonaId int, @TProgramaId nvarchar, @ProgramaId nvarchar, @Registro datetime, @Modificacion datetime, @Identificador uniqueidentifier, @UsuarioId int, @EstadoId int, @DestinoId_UniversidadId int, @OrigenId_UniversidadId int
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.Solicitudes
	            (
				 SolicitudId, TSolicitudId, NoAprobacion, FechaAprobacion, Indice, CreditosCursados, PeriodoIngreso, PersonaId, TProgramaId, Registro, Modificacion, Identificador, UsuarioId, EstadoId, DestinoId_UniversidadId, OrigenId_UniversidadId
				)
		 VALUES (
		         @SolicitudId, @TSolicitudId, @NoAprobacion, @FechaAprobacion, @Indice, @CreditosCursados, @PeriodoIngreso, @PersonaId, @TProgramaId, @ProgramaId, @Registro, @Modificacion, @Identificador, @UsuarioId, @EstadoId, @DestinoId_UniversidadId, @OrigenId_UniversidadId
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH