CREATE DATABASE CustomerManagement;
GO
USE CustomerManagement;
GO
CREATE TABLE Customer
(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	PersonalNum varchar(11) NOT NULL,
	Name varchar(50) NOT NULL,
	LastName varchar(50) NOT NULL,
	TotalDebt decimal(18,2) NOT NULL,
	Note text
);
GO
CREATE PROCEDURE usp_AddCustomer
(
	@pPersonalNum varchar(11),
	@pName varchar(50),
	@pLastName varchar(50),
	@pTotalDebt decimal(18,2),
	@pNote text
)
AS
	INSERT INTO Customer(PersonalNum, Name, LastName, TotalDebt, Note) VALUES (@pPersonalNum, @pName, @pLastName, @pTotalDebt, @pNote);
GO
CREATE PROCEDURE usp_UpdateCustomer
(
	@ID int,
	@pPersonalNum varchar(11),
	@pName varchar(50),
	@pLastName varchar(50),
	@pTotalDebt decimal(18,2),
	@pNote text
)
AS
	UPDATE Customer SET PersonalNum = @pPersonalNum, Name = @pName, LastName = @pLastName, TotalDebt = @pTotalDebt, Note = @pNote WHERE ID = @ID;
GO
CREATE PROCEDURE usp_DeleteCustomer
(
	@ID int
)
AS
	DELETE FROM Customer WHERE ID = @ID;
GO
CREATE PROCEDURE usp_AllCustomers
AS
	SELECT * FROM Customer;
GO
CREATE TABLE CMUser
(
	ID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	UserName varchar(10) NOT NULL,
	UserPassword varchar(80) NOT NULL,
	Salt varchar(36) NOT NULL
);
GO
CREATE PROCEDURE usp_AddCMUser
(
	@pUserName varchar(10),
	@pUserPassword varchar(8)
)
AS
	INSERT INTO CMUser (UserName, UserPassword, Salt) VALUES (@pUserName, HASHBYTES('SHA2_512', @pUserPassword), NEWID());
GO
DROP PROCEDURE usp_CMLogin
CREATE PROCEDURE usp_CMLogin
(
	@pUserName varchar(10),
	@pUserPassword varchar(8),
	@pResult int OUTPUT
)
AS
	IF EXISTS (SELECT 1 FROM CMUser WHERE UserName = @pUserName AND UserPassword = HASHBYTES('SHA2_512', @pUserPassword))
		SET @pResult = 1
	ELSE
		SET @pResult = 0
GO
EXEC usp_AddCMUser @pUserName = 'Admin', @pUserPassword = '123'
GO
DECLARE @a int;
EXEC usp_CMLogin @pUserName = 'Admin', @pUserPassword = '123', @pResult = @a OUTPUT
SELECT @a;