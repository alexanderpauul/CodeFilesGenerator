USE PMN
GO

CREATE PROCEDURE dbo.__MigrationHistory_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT MigrationId, ContextKey, Model, ProductVersion 
	  FROM dbo.__MigrationHistory 
	 WHERE MigrationId = @value