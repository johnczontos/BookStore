CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ISBN] BIGINT NULL, 
    [Title] NVARCHAR(250) NULL, 
    [Author] NVARCHAR(50) NULL, 
    [Year] INT NULL, 
    [Status] NVARCHAR(50) NULL
)

GO

CREATE INDEX [IX_Table_Column] ON [dbo].[Table] (ISBN)
