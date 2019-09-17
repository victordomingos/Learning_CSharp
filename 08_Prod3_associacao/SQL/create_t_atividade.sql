USE [Xvictor]
GO

/****** Object:  Table [dbo].[atividade]    Script Date: 17/09/2019 09:42:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[atividade](
	[cod] [int] IDENTITY(0,1) NOT NULL,
	[descritivo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_atividade] PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[atividade]  WITH CHECK ADD  CONSTRAINT [FK_atividade_atividade] FOREIGN KEY([cod])
REFERENCES [dbo].[atividade] ([cod])
GO

ALTER TABLE [dbo].[atividade] CHECK CONSTRAINT [FK_atividade_atividade]
GO

