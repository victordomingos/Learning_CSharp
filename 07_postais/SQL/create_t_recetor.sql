USE [victor_BD_testes_post]
GO

/****** Object:  Table [dbo].[recetor]    Script Date: 11/09/2019 12:03:40 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[recetor](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[morada] [varchar](50) NOT NULL,
	[contacto] [varchar](50) NULL,
 CONSTRAINT [PK_recetor] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

