USE PMN
GO

CREATE PROCEDURE dbo.AspNetUserClaims_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT Id, UserId, ClaimType, ClaimValue 
	  FROM dbo.AspNetUserClaims 
	 WHERE Id = @value