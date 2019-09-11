USE [victor_BD_testes_post]
GO

/****** Object:  Table [dbo].[postal]    Script Date: 11/09/2019 12:03:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[postal](
	[codigo] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [int] NOT NULL,
	[ano] [varchar](50) NULL,
 CONSTRAINT [PK_postal] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[postal]  WITH CHECK ADD  CONSTRAINT [FK_postal_tipo] FOREIGN KEY([tipo])
REFERENCES [dbo].[tipo] ([codigo])
GO

ALTER TABLE [dbo].[postal] CHECK CONSTRAINT [FK_postal_tipo]
GO

