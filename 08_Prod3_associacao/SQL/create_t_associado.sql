USE [Xvictor]
GO

/****** Object:  Table [dbo].[associado]    Script Date: 17/09/2019 09:42:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[associado](
	[cod] [int] IDENTITY(1,1) NOT NULL,
	[nome] [varchar](50) NOT NULL,
	[ano_nasc] [int] NULL,
	[sexo] [char](1) NOT NULL,
	[quota] [bit] NOT NULL,
	[atividade_cod] [int] NULL,
 CONSTRAINT [PK_associado] PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[associado]  WITH CHECK ADD  CONSTRAINT [FK_associado_atividade] FOREIGN KEY([atividade_cod])
REFERENCES [dbo].[atividade] ([cod])
GO

ALTER TABLE [dbo].[associado] CHECK CONSTRAINT [FK_associado_atividade]
GO

