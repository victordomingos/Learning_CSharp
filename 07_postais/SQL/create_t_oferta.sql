USE [victor_BD_testes_post]
GO

/****** Object:  Table [dbo].[oferta]    Script Date: 11/09/2019 12:03:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[oferta](
	[codigo] [int] NOT NULL,
	[data_hora] [nchar](10) NOT NULL,
	[oferecedor] [int] NOT NULL,
	[recetor] [int] NOT NULL,
	[postal] [int] NOT NULL,
 CONSTRAINT [PK_oferta] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[oferta]  WITH CHECK ADD  CONSTRAINT [FK_oferta_oferecedor] FOREIGN KEY([oferecedor])
REFERENCES [dbo].[oferecedor] ([codigo])
GO

ALTER TABLE [dbo].[oferta] CHECK CONSTRAINT [FK_oferta_oferecedor]
GO

ALTER TABLE [dbo].[oferta]  WITH CHECK ADD  CONSTRAINT [FK_oferta_recetor] FOREIGN KEY([recetor])
REFERENCES [dbo].[recetor] ([codigo])
GO

ALTER TABLE [dbo].[oferta] CHECK CONSTRAINT [FK_oferta_recetor]
GO

