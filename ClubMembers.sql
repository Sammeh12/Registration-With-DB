CREATE TABLE [dbo].[ClubMembers]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [StudentId] BIGINT NULL, 
    [FirstName] VARCHAR(50) NULL, 
    [MiddleName] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Age] INT NULL, 
    [Gender] VARCHAR(50) NULL, 
    [Program] VARCHAR(50) NULL
)
