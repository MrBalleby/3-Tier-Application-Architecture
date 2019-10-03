# DB Tables

create database CoreApplication;

create table Customer (
	id int identity primary key,
	firstname varchar(50),
	surname varchar(50),
	age int,
	mail varchar(50),
	phone int,
	customerGroupId int, 
	AddressId int
);
go
create table CustomerAddress (
	id int identity primary key,
	street varchar(50),
	number int,
	city varchar(50),
	zip int
);
go
create table CustomerGroup (
	id int identity primary key,
	name varchar(50),
	grouptype varchar(7) NOT NULL CHECK (grouptype IN('Company', 'Private','State')),
	custtype varchar(5) NOT NULL CHECK (custtype IN('Child', 'Adult')),
	ticketId int unique not null
);
go
create table ConcertHall (
	id int identity primary key,
	name varchar(50),
	ticketType varchar(8) NOT NULL CHECK (ticketType IN('Standing', 'Sitting')),
	totalOfPpl int,
	AddressId int
);
go
create table Events_ (
	id int identity primary key,
	eventName varchar(50),
	eventDate datetime,
	grouptype varchar(7) NOT NULL CHECK (grouptype IN('Company', 'Private','State')),
	custtype varchar(5) NOT NULL CHECK (custtype IN('Child', 'Adult'))
);
go
create table Customer_Customergroup (
	id int identity primary key,
	custId int,
	custName varchar(50),
	custMail varchar(50),
	groupName varchar(50),
	ticketId int
);
go
create table Events_Customergroup (
	id int identity primary key,
	eventName varchar(50),
	groupName varchar(50),
	groupId int,
	ticketId int
);
create table Events_ConcertHall (
	id int identity primary key,
	eventName varchar(50),
	eventDate datetime,
	totalOfPpl int,
	ticketType varchar(8) NOT NULL CHECK (ticketType IN('Standing', 'Sitting'))
);
go
create table EventTickets_TicketsSold (
	id int identity primary key,
	eventname varchar(50),
	eventDate datetime,
	groupId int,
	ticketId int,
	custtype varchar(5) NOT NULL CHECK (custtype IN('Child', 'Adult')),
	ticketType varchar(8) NOT NULL CHECK (ticketType IN('Standing', 'Sitting'))
);
go
insert into Customer_Customergroup
	select a.custId, b.firstname, b.mail, c.name, c.ticketId
	from ((Customer_Customergroup a
		INNER JOIN Customer b 
			on a.custName = b.firstname)
		INNER JOIN Customergroup c 
			on a.custId = b.id); 
go
insert into Events_Customergroup
	select b.eventName, c.name, c.id, c.ticketId
	from ((Events_Customergroup a
		INNER JOIN Events_ b
			on a.eventName = b.eventName)
		INNER JOIN CustomerGroup c
			on a.groupId = c.id);
go
insert into Events_ConcertHall
	select b.eventName, b.eventDate, c.totalOfPpl, c.ticketType
	from ((Events_ConcertHall a
		INNER JOIN Events_ b
			on a.eventDate = b.eventDate)
		INNER JOIN ConcertHall c
			on a.totalOfPpl = c.totalOfPpl);
go
insert into EventTickets_TicketsSold
	select b.eventName, b.eventDate, c.groupId, c.ticketId, a.custtype, a.ticketType
	from ((EventTickets_TicketsSold a
		INNER JOIN Events_ConcertHall b
			on a.eventname = b.eventName)
		INNER JOIN Events_Customergroup c
			on a.groupId = c.groupId);
      
      
      
      
      
 # Sproc
 
 /* DELETE */

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_DeleteConcertHall] ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_DeleteConcertHall]

(
	@id int
)

AS
DELETE FROM [ConcertHall]

WHERE
id = @id


/*DROP PROC dbo.sproc_DeleteConcertHall*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_DeleteCustomer]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_DeleteCustomer]

(
	@id int
)

AS
DELETE FROM [Customer]

WHERE
id = @id


/*DROP PROC dbo.sproc_DeleteCustomer*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_DeleteCustomer_Customergroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_DeleteCustomer_Customergroup]

(
	@id int
)

AS
DELETE FROM [Customer_Customergroup]

WHERE
id = @id


/*DROP PROC dbo.sproc_DeleteCustomer_Customergroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_DeleteCustomerAddres]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_DeleteCustomerAddres]

(
	@id int
)

AS
DELETE FROM [CustomerAddress]

WHERE
id = @id


/*DROP PROC dbo.sproc_DeleteCustomerAddres*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_DeleteCustomerGroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_DeleteCustomerGroup]

(
	@id int
)

AS
DELETE FROM [CustomerGroup]

WHERE
id = @id


/*DROP PROC dbo.sproc_DeleteCustomerGroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_DeleteEvents_]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_DeleteEvents_]

(
	@id int
)

AS
DELETE FROM [Events_]

WHERE
id = @id


/*DROP PROC dbo.sproc_DeleteEvents_*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_DeleteEvents_ConcertHall]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_DeleteEvents_ConcertHall]

(
	@id int
)

AS
DELETE FROM [Events_ConcertHall]

WHERE
id = @id


/*DROP PROC dbo.sproc_DeleteEvents_ConcertHall*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_DeleteEvents_Customergroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_DeleteEvents_Customergroup]

(
	@id int
)

AS
DELETE FROM [Events_Customergroup]

WHERE
id = @id


/*DROP PROC dbo.sproc_DeleteEvents_Customergroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_DeleteEventTickets_TicketsSold]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_DeleteEventTickets_TicketsSold]

(
	@id int
)

AS
DELETE FROM [EventTickets_TicketsSold]

WHERE
id = @id


/*DROP PROC dbo.sproc_DeleteEventTickets_TicketsSold*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetConcertHall]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/* GET */

CREATE PROCEDURE [dbo].[sproc_GetConcertHall]
AS
SELECT * FROM [ConcertHall]

/*DROP PROC dbo.sproc_GetConcertHall*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetConcertHallDetails]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetConcertHallDetails]

(
	@id int
)

AS
SELECT * FROM [ConcertHall]

WHERE
id = @id


/*DROP PROC dbo.sproc_GetConcertHallDetails*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetCustomer]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetCustomer]
AS
SELECT * FROM [Customer]

/*DROP PROC dbo.sproc_GetCustomer*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetCustomer_Customergroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetCustomer_Customergroup]
AS
SELECT * FROM [Customer_Customergroup]

/*DROP PROC dbo.sproc_GetCustomer_Customergroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetCustomer_CustomergroupDetails]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetCustomer_CustomergroupDetails]

(
	@id int
)

AS
SELECT * FROM [Customer_Customergroup]

WHERE
id = @id


/*DROP PROC dbo.sproc_GetCustomer_CustomergroupDetails*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetCustomerAddresDetails]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetCustomerAddresDetails]

(
	@id int
)

AS
SELECT * FROM [CustomerAddress]

WHERE
id = @id


/*DROP PROC dbo.sproc_GetCustomerAddresDetails*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetCustomerAddress]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetCustomerAddress]
AS
SELECT * FROM [CustomerAddress]

/*DROP PROC dbo.sproc_GetCustomerAddress*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetCustomerDetails]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetCustomerDetails]

(
	@id int
)

AS
SELECT * FROM [Customer]

WHERE
id = @id


/*DROP PROC dbo.sproc_GetCustomerDetails*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetCustomerGroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetCustomerGroup]
AS
SELECT * FROM [CustomerGroup]

/*DROP PROC dbo.sproc_GetCustomerGroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetCustomerGroupDetails]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetCustomerGroupDetails]

(
	@id int
)

AS
SELECT * FROM [CustomerGroup]

WHERE
id = @id


/*DROP PROC dbo.sproc_GetCustomerGroupDetails*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetEvents_]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetEvents_]
AS
SELECT * FROM [Events_]

/*DROP PROC dbo.sproc_GetEvents_*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetEvents_ConcertHall]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetEvents_ConcertHall]
AS
SELECT * FROM [Events_ConcertHall]

/*DROP PROC dbo.sproc_GetEvents_ConcertHall*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetEvents_ConcertHallDetails]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetEvents_ConcertHallDetails]

(
	@id int
)

AS
SELECT * FROM [Events_ConcertHall]

WHERE
id = @id


/*DROP PROC dbo.sproc_GetEvents_ConcertHallDetails*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetEvents_Customergroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetEvents_Customergroup]
AS
SELECT * FROM [Events_Customergroup]

/*DROP PROC dbo.sproc_GetEvents_Customergroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetEvents_CustomergroupDetails]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetEvents_CustomergroupDetails]

(
	@id int
)

AS
SELECT * FROM [Events_Customergroup]

WHERE
id = @id


/*DROP PROC dbo.sproc_GetEvents_CustomergroupDetails*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetEvents_Details]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetEvents_Details]

(
	@id int
)

AS
SELECT * FROM [Events_]

WHERE
id = @id


/*DROP PROC dbo.sproc_GetEvents_Details*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetEventTickets_TicketsSold]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetEventTickets_TicketsSold]
AS
SELECT * FROM [EventTickets_TicketsSold]

/*DROP PROC dbo.sproc_GetEventTickets_TicketsSold*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_GetEventTickets_TicketsSoldDetails]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_GetEventTickets_TicketsSoldDetails]

(
	@id int
)

AS
SELECT * FROM [EventTickets_TicketsSold]

WHERE
id = @id


/*DROP PROC dbo.sproc_GetEventTickets_TicketsSoldDetails*/
GO

/* INSERT */

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_InsertConcertHall]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_InsertConcertHall]
(
	@name nvarchar (MAX),
	@ticketType nvarchar (MAX),
	@totalOfPpl int,
	@AddressId int,
	@id  int OUTPUT
)

AS
INSERT INTO [ConcertHall]
( 
	name,
	ticketType,
	totalOfPpl,
	AddressId

)
VALUES 
(
	@name,
	@ticketType,
	@totalOfPpl,
	@AddressId
)


SET @id= @@IDENTITY
 Return @id
/*DROP PROC dbo.sproc_InsertConcertHall*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_InsertCustomer]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_InsertCustomer]
(
	@firstname nvarchar (MAX),
	@surname nvarchar (MAX),
	@age int,
	@mail nvarchar (MAX),
	@phone int,
	@customerGroupId int,
	@AddressId int,
	@id  int OUTPUT
)

AS
INSERT INTO [Customer]
( 
	firstname,
	surname,
	age,
	mail,
	phone,
	customerGroupId,
	AddressId

)
VALUES 
(
	@firstname,
	@surname,
	@age,
	@mail,
	@phone,
	@customerGroupId,
	@AddressId
)


SET @id= @@IDENTITY
 Return @id
/*DROP PROC dbo.sproc_InsertCustomer*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_InsertCustomer_Customergroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_InsertCustomer_Customergroup]
(
	@custId int,
	@custName nvarchar (MAX),
	@custMail nvarchar (MAX),
	@groupName nvarchar (MAX),
	@ticketId int,
	@id  int OUTPUT
)

AS
INSERT INTO [Customer_Customergroup]
( 
	custId,
	custName,
	custMail,
	groupName,
	ticketId

)
VALUES 
(
	@custId,
	@custName,
	@custMail,
	@groupName,
	@ticketId
)


SET @id= @@IDENTITY
 Return @id
/*DROP PROC dbo.sproc_InsertCustomer_Customergroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_InsertCustomerAddres]*****/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_InsertCustomerAddres]
(
	@street nvarchar (MAX),
	@number int,
	@city nvarchar (MAX),
	@zip int,
	@id  int OUTPUT
)

AS
INSERT INTO [CustomerAddress]
( 
	street,
	number,
	city,
	zip

)
VALUES 
(
	@street,
	@number,
	@city,
	@zip
)


SET @id= @@IDENTITY
 Return @id
/*DROP PROC dbo.sproc_InsertCustomerAddres*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_InsertCustomerGroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_InsertCustomerGroup]
(
	@name nvarchar (MAX),
	@grouptype nvarchar (MAX),
	@custtype nvarchar (MAX),
	@ticketId int,
	@id  int OUTPUT
)

AS
INSERT INTO [CustomerGroup]
( 
	name,
	grouptype,
	custtype,
	ticketId

)
VALUES 
(
	@name,
	@grouptype,
	@custtype,
	@ticketId
)


SET @id= @@IDENTITY
 Return @id
/*DROP PROC dbo.sproc_InsertCustomerGroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_InsertEvents_]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_InsertEvents_]
(
	@eventName nvarchar (MAX),
	@eventDate datetime,
	@grouptype nvarchar (MAX),
	@custtype nvarchar (MAX),
	@id  int OUTPUT
)

AS
INSERT INTO [Events_]
( 
	eventName,
	eventDate,
	grouptype,
	custtype

)
VALUES 
(
	@eventName,
	@eventDate,
	@grouptype,
	@custtype
)


SET @id= @@IDENTITY
 Return @id
/*DROP PROC dbo.sproc_InsertEvents_*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_InsertEvents_ConcertHall]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_InsertEvents_ConcertHall]
(
	@eventName nvarchar (MAX),
	@eventDate datetime,
	@totalOfPpl int,
	@ticketType nvarchar (MAX),
	@id  int OUTPUT
)

AS
INSERT INTO [Events_ConcertHall]
( 
	eventName,
	eventDate,
	totalOfPpl,
	ticketType

)
VALUES 
(
	@eventName,
	@eventDate,
	@totalOfPpl,
	@ticketType
)


SET @id= @@IDENTITY
 Return @id
/*DROP PROC dbo.sproc_InsertEvents_ConcertHall*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_InsertEvents_Customergroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_InsertEvents_Customergroup]
(
	@eventName nvarchar (MAX),
	@groupName nvarchar (MAX),
	@groupId int,
	@ticketId int,
	@id  int OUTPUT
)

AS
INSERT INTO [Events_Customergroup]
( 
	eventName,
	groupName,
	groupId,
	ticketId

)
VALUES 
(
	@eventName,
	@groupName,
	@groupId,
	@ticketId
)


SET @id= @@IDENTITY
 Return @id
/*DROP PROC dbo.sproc_InsertEvents_Customergroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_InsertEventTickets_TicketsSold]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_InsertEventTickets_TicketsSold]
(
	@eventname nvarchar (MAX),
	@eventDate datetime,
	@groupId int,
	@ticketId int,
	@custtype nvarchar (MAX),
	@ticketType nvarchar (MAX),
	@id  int OUTPUT
)

AS
INSERT INTO [EventTickets_TicketsSold]
( 
	eventname,
	eventDate,
	groupId,
	ticketId,
	custtype,
	ticketType

)
VALUES 
(
	@eventname,
	@eventDate,
	@groupId,
	@ticketId,
	@custtype,
	@ticketType
)


SET @id= @@IDENTITY
 Return @id
/*DROP PROC dbo.sproc_InsertEventTickets_TicketsSold*/
GO

/* UPDATE */


USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_UpdateConcertHall]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_UpdateConcertHall]
(
	@id int,
	@name nvarchar (MAX),
	@ticketType nvarchar (MAX),
	@totalOfPpl int,
	@AddressId int
)

AS
UPDATE [ConcertHall] 
SET 
name = @name,
ticketType = @ticketType,
totalOfPpl = @totalOfPpl,
AddressId = @AddressId

WHERE
id = @id


/*DROP PROC dbo.sproc_UpdateConcertHall*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_UpdateCustomer]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_UpdateCustomer]
(
	@id int,
	@firstname nvarchar (MAX),
	@surname nvarchar (MAX),
	@age int,
	@mail nvarchar (MAX),
	@phone int,
	@customerGroupId int,
	@AddressId int
)

AS
UPDATE [Customer] 
SET 
firstname = @firstname,
surname = @surname,
age = @age,
mail = @mail,
phone = @phone,
customerGroupId = @customerGroupId,
AddressId = @AddressId

WHERE
id = @id


/*DROP PROC dbo.sproc_UpdateCustomer*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_UpdateCustomer_Customergroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_UpdateCustomer_Customergroup]
(
	@id int,
	@custId int,
	@custName nvarchar (MAX),
	@custMail nvarchar (MAX),
	@groupName nvarchar (MAX),
	@ticketId int
)

AS
UPDATE [Customer_Customergroup] 
SET 
custId = @custId,
custName = @custName,
custMail = @custMail,
groupName = @groupName,
ticketId = @ticketId

WHERE
id = @id


/*DROP PROC dbo.sproc_UpdateCustomer_Customergroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_UpdateCustomerAddres]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_UpdateCustomerAddres]
(
	@id int,
	@street nvarchar (MAX),
	@number int,
	@city nvarchar (MAX),
	@zip int
)

AS
UPDATE [CustomerAddress] 
SET 
street = @street,
number = @number,
city = @city,
zip = @zip

WHERE
id = @id


/*DROP PROC dbo.sproc_UpdateCustomerAddres*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_UpdateCustomerGroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_UpdateCustomerGroup]
(
	@id int,
	@name nvarchar (MAX),
	@grouptype nvarchar (MAX),
	@custtype nvarchar (MAX),
	@ticketId int
)

AS
UPDATE [CustomerGroup] 
SET 
name = @name,
grouptype = @grouptype,
custtype = @custtype,
ticketId = @ticketId

WHERE
id = @id


/*DROP PROC dbo.sproc_UpdateCustomerGroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_UpdateEvents_]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_UpdateEvents_]
(
	@id int,
	@eventName nvarchar (MAX),
	@eventDate datetime,
	@grouptype nvarchar (MAX),
	@custtype nvarchar (MAX)
)

AS
UPDATE [Events_] 
SET 
eventName = @eventName,
eventDate = @eventDate,
grouptype = @grouptype,
custtype = @custtype

WHERE
id = @id


/*DROP PROC dbo.sproc_UpdateEvents_*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_UpdateEvents_ConcertHall]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_UpdateEvents_ConcertHall]
(
	@id int,
	@eventName nvarchar (MAX),
	@eventDate datetime,
	@totalOfPpl int,
	@ticketType nvarchar (MAX)
)

AS
UPDATE [Events_ConcertHall] 
SET 
eventName = @eventName,
eventDate = @eventDate,
totalOfPpl = @totalOfPpl,
ticketType = @ticketType

WHERE
id = @id


/*DROP PROC dbo.sproc_UpdateEvents_ConcertHall*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_UpdateEvents_Customergroup]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_UpdateEvents_Customergroup]
(
	@id int,
	@eventName nvarchar (MAX),
	@groupName nvarchar (MAX),
	@groupId int,
	@ticketId int
)

AS
UPDATE [Events_Customergroup] 
SET 
eventName = @eventName,
groupName = @groupName,
groupId = @groupId,
ticketId = @ticketId

WHERE
id = @id


/*DROP PROC dbo.sproc_UpdateEvents_Customergroup*/
GO

USE [CoreApplication]
GO

/****** Object:  StoredProcedure [dbo].[sproc_UpdateEventTickets_TicketsSold]******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sproc_UpdateEventTickets_TicketsSold]
(
	@id int,
	@eventname nvarchar (MAX),
	@eventDate datetime,
	@groupId int,
	@ticketId int,
	@custtype nvarchar (MAX),
	@ticketType nvarchar (MAX)
)

AS
UPDATE [EventTickets_TicketsSold] 
SET 
eventname = @eventname,
eventDate = @eventDate,
groupId = @groupId,
ticketId = @ticketId,
custtype = @custtype,
ticketType = @ticketType

WHERE
id = @id


/*DROP PROC dbo.sproc_UpdateEventTickets_TicketsSold*/
GO

