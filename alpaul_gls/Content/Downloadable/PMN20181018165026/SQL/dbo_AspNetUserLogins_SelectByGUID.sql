USE PMN
GO

CREATE PROCEDURE dbo.AspNetUserLogins_GetByGUID
(
	@value NVARCHAR(100)
)
AS
	SELECT LoginProvider, ProviderKey, UserId 
	  FROM dbo.AspNetUserLogins 
	 WHERE LoginProvider = @value