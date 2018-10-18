USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetRoles_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT Id, Name 
	  FROM dbo.AspNetRoles 
	 WHERE Id = @value