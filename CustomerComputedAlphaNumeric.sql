USE [MyUserDatabase];
GO

/*
 Simple example of a computed column for customer identity as alpha-numneric
*/

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO
CREATE TABLE dbo.SampleComputed
(Id           NUMERIC(18, 0) IDENTITY(1, 1) NOT NULL, 
 ComputedIdentifier AS CASE
                           WHEN Id < 9999
                           THEN 'A' + RIGHT('000' + CONVERT(VARCHAR, Id, 10), 4)
                           ELSE 'A' + CONVERT(VARCHAR, Id, 10)
                       END PERSISTED, 
 CustomerName NVARCHAR(50) NULL, 
 CONSTRAINT PK_SampleComputed PRIMARY KEY CLUSTERED(Id ASC)
 WITH(PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
)
ON [PRIMARY];
GO