USE PMN
GO

CREATE PROCEDURE dbo.AspNetUserClaims_Edit
(
       @Id int, @UserId nvarchar, @ClaimType nvarchar, @ClaimValue nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
		UPDATE dbo.AspNetUserClaims 
		   SET Id = @Id, UserId = @UserId, ClaimType = @ClaimType, ClaimValue = @ClaimValue
		 WHERE Id = @Id

	COMMIT TRANSACTION
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH