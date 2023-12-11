﻿CREATE TABLE [kanif].[VenderDetails]
(
	[VenderId] INT NOT NULL PRIMARY KEY, 
    [FirstName] VARCHAR(25) NOT NULL, 
    [MiddleName] VARCHAR(25) NOT NULL,
    [LastName] VARCHAR(25) NOT NULL, 
    [Address] VARCHAR(30) NOT NULL, 
    [CityId] INT NOT NULL,
    [PhoneNo] TEXT NOT NULL, 
    [VendorTypeId] INT NOT NULL, 
)
