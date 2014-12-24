USE [Test]
GO

/****** Object:  Table [dbo].[TestTable]    Script Date: 12/24/2014 21:42:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TestTable](
	[TestTableID] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[Field1] [int] NULL,
	[Field2] [datetime2](7) NULL,
	[Field3] [nvarchar](64) NULL,
 CONSTRAINT [PK_TestTable] PRIMARY KEY CLUSTERED 
(
	[TestTableID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[TestTable] ADD  CONSTRAINT [DF_TestTable_TestTableID]  DEFAULT (newid()) FOR [TestTableID]
GO


INSERT INTO [Test].[dbo].[TestTable]
           
           ([Field1]
           ,[Field2]
           ,[Field3])
       
     SELECT ROUND((99 * RAND()), 0), GETDATE(), 'Aloha' UNION ALL
     SELECT ROUND((99 * RAND()), 0), GETDATE(), 'Aloha2' UNION ALL  
     SELECT ROUND((99 * RAND()), 0), GETDATE(), 'Aloha'
GO


