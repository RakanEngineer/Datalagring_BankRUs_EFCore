# Datalagring_BankRUs_EFCore

För att använda Entity Framework Core:
1-install-package Microsoft.EntityFrameworkCore.SqlServer
2- Skapa klass som ärver från DbContext (t.ex. BankRUsContext) och sätt connection string.

---------------
﻿CREATE DATABASE BankRUs;
GO
​
USE BankRUs
GO
​
CREATE TABLE Customer
(
    Id INT NOT NULL IDENTITY,
    FirstName NVARCHAR(50) NULL,
    LastName NVARCHAR(50) NULL,
    SocialSecurityNumber NVARCHAR(50) NULL,
    CONSTRAINT PK_Customer PRIMARY KEY (Id)
)
​
CREATE TABLE Address
(
    Id INT NOT NULL IDENTITY,
    Street NVARCHAR(50) NOT NULL,
    City NVARCHAR(50) NOT NULL,
    Postcode NVARCHAR(50) NOT NULL,
    CustomerId INT NOT NULL,
    CONSTRAINT PK_Address PRIMARY KEY (Id),
    CONSTRAINT FK_Address_Customer_Id FOREIGN KEY (CustomerId) 
        REFERENCES Customer (Id) ON DELETE CASCADE
);