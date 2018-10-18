USE PHAO20180925
GO

CREATE PROCEDURE dbo.AspNetUserClaims_Add
(
       @Id int, @UserId nvarchar, @ClaimType nvarchar, @ClaimValue nvarchar
)
AS
BEGIN TRANSACTION
BEGIN TRY
	INSERT INTO dbo.AspNetUserClaims
	            (
				 Id, UserId, ClaimType, ClaimValue
				)
		 VALUES (
		         @Id, @UserId, @ClaimType, @ClaimValue
				)

	COMMIT TRANSACTION

	SELECT ISNULL(CAST(SCOPE_IDENTITY() AS INT), 0)
END TRY
BEGIN CATCH
	ROLLBACK TRANSACTION
END CATCH