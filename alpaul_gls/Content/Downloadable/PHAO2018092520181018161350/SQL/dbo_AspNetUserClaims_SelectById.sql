USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetUserClaims_GetById
(
	@value NVARCHAR(100)
)
AS
	SELECT Id, UserId, ClaimType, ClaimValue 
	  FROM dbo.AspNetUserClaims 
	 WHERE Id = @value