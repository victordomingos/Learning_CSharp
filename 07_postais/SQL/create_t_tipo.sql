USE [victor_BD_testes_post]
GO

/****** Object:  Table [dbo].[tipo]    Script Date: 11/09/2019 12:03:55 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tipo](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[designacao] [varchar](50) NULL,
	[preco_compra] [float] NULL,
 CONSTRAINT [PK_tipo] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

