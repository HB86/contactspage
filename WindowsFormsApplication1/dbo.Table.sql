CREATE TABLE [dbo].[Contacts] (
    [FirstName] NVARCHAR(50) NOT NULL,
    [LastName]  NVARCHAR(50) NULL,
    [Email]     NVARCHAR(50) NULL,
    [Phone]     INT           NULL,
    PRIMARY KEY CLUSTERED ([FirstName] ASC)
);

