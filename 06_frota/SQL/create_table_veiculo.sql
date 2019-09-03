USE [victor_BD_Frota]
GO

/****** Object:  Table [dbo].[veiculo]    Script Date: 03/09/2019 10:02:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[veiculo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[matricula] [nvarchar](50) NOT NULL,
	[marca] [nvarchar](50) NULL,
	[modelo] [nvarchar](50) NULL,
 CONSTRAINT [PK_veiculo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

