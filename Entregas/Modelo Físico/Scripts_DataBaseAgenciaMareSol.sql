USE [AGMareSol]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 20/12/2021 23:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contatos]    Script Date: 20/12/2021 23:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contatos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](50) NOT NULL,
	[Sobrenome] [nvarchar](50) NOT NULL,
	[CPF] [nvarchar](15) NOT NULL,
	[Email] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Contatos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Destinos]    Script Date: 20/12/2021 23:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Destinos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cidade] [nvarchar](20) NOT NULL,
	[Estado] [nvarchar](2) NOT NULL,
	[Preco] [float] NOT NULL,
 CONSTRAINT [PK_Destinos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passagens]    Script Date: 20/12/2021 23:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passagens](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [nvarchar](15) NOT NULL,
	[ContatoId] [int] NULL,
	[PromocaoId] [int] NULL,
	[Contato_Id] [int] NOT NULL,
	[Promocao_Id] [int] NOT NULL,
 CONSTRAINT [PK_Passagens] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promoções]    Script Date: 20/12/2021 23:41:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promoções](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](40) NOT NULL,
	[DataViagem] [datetime2](7) NOT NULL,
	[DestinoId] [int] NULL,
	[Destino_Id] [int] NOT NULL,
 CONSTRAINT [PK_Promoções] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211220123843_InitialCreate', N'6.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211220221641_Foreignkeys', N'6.0.1')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211220225341_Reinitialyze', N'6.0.1')
GO
SET IDENTITY_INSERT [dbo].[Contatos] ON 

INSERT [dbo].[Contatos] ([Id], [Nome], [Sobrenome], [CPF], [Email]) VALUES (3, N'Armando de', N'moreira Bahia', N'49430933820', N'armando@yahoo.com')
INSERT [dbo].[Contatos] ([Id], [Nome], [Sobrenome], [CPF], [Email]) VALUES (4, N'Maria ', N'Aparecida de Souza', N'98907656825', N'maparecida@if.com.br')
INSERT [dbo].[Contatos] ([Id], [Nome], [Sobrenome], [CPF], [Email]) VALUES (5, N'Ricardo', N'Jesus Savoia', N'11937822736', N'rj@gmail.com')
INSERT [dbo].[Contatos] ([Id], [Nome], [Sobrenome], [CPF], [Email]) VALUES (6, N'Gerusa ', N'Vieira Lima', N'889278556378', N'gerusa@ig.com.br')
SET IDENTITY_INSERT [dbo].[Contatos] OFF
GO
SET IDENTITY_INSERT [dbo].[Destinos] ON 

INSERT [dbo].[Destinos] ([Id], [Cidade], [Estado], [Preco]) VALUES (1, N'Fortaleza', N'CE', 125.6)
SET IDENTITY_INSERT [dbo].[Destinos] OFF
GO
SET IDENTITY_INSERT [dbo].[Passagens] ON 

INSERT [dbo].[Passagens] ([Id], [Numero], [ContatoId], [PromocaoId], [Contato_Id], [Promocao_Id]) VALUES (2, N'1149830278', NULL, NULL, 2, 3)
INSERT [dbo].[Passagens] ([Id], [Numero], [ContatoId], [PromocaoId], [Contato_Id], [Promocao_Id]) VALUES (3, N'1143634278', NULL, NULL, 1, 2)
INSERT [dbo].[Passagens] ([Id], [Numero], [ContatoId], [PromocaoId], [Contato_Id], [Promocao_Id]) VALUES (4, N'49038945829', NULL, NULL, 4, 1)
SET IDENTITY_INSERT [dbo].[Passagens] OFF
GO
SET IDENTITY_INSERT [dbo].[Promoções] ON 

INSERT [dbo].[Promoções] ([Id], [Nome], [DataViagem], [DestinoId], [Destino_Id]) VALUES (1, N'Promoção Viajar Bem', CAST(N'2021-12-25T20:00:00.0000000' AS DateTime2), NULL, 0)
SET IDENTITY_INSERT [dbo].[Promoções] OFF
GO
ALTER TABLE [dbo].[Passagens] ADD  DEFAULT ((0)) FOR [Contato_Id]
GO
ALTER TABLE [dbo].[Passagens] ADD  DEFAULT ((0)) FOR [Promocao_Id]
GO
ALTER TABLE [dbo].[Promoções] ADD  DEFAULT (N'') FOR [Nome]
GO
ALTER TABLE [dbo].[Promoções] ADD  DEFAULT ((0)) FOR [Destino_Id]
GO
ALTER TABLE [dbo].[Passagens]  WITH CHECK ADD  CONSTRAINT [FK_Passagens_Contatos_ContatoId] FOREIGN KEY([ContatoId])
REFERENCES [dbo].[Contatos] ([Id])
GO
ALTER TABLE [dbo].[Passagens] CHECK CONSTRAINT [FK_Passagens_Contatos_ContatoId]
GO
ALTER TABLE [dbo].[Passagens]  WITH CHECK ADD  CONSTRAINT [FK_Passagens_Promoções_PromocaoId] FOREIGN KEY([PromocaoId])
REFERENCES [dbo].[Promoções] ([Id])
GO
ALTER TABLE [dbo].[Passagens] CHECK CONSTRAINT [FK_Passagens_Promoções_PromocaoId]
GO
ALTER TABLE [dbo].[Promoções]  WITH CHECK ADD  CONSTRAINT [FK_Promoções_Destinos_DestinoId] FOREIGN KEY([DestinoId])
REFERENCES [dbo].[Destinos] ([Id])
GO
ALTER TABLE [dbo].[Promoções] CHECK CONSTRAINT [FK_Promoções_Destinos_DestinoId]
GO
