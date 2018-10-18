USE PHAO20180925
GO

CREATE PROCEDURE dbo.__MigrationHistory_GetAll
AS
	SELECT MigrationId, ContextKey, Model, ProductVersion 
	  FROM dbo.__MigrationHistory