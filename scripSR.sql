
CREATE DATABASE [signalr];

USE [signalr]


CREATE TABLE [sala](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Imagen] [nvarchar](1000) NULL,
	[fechaAlta] [datetime] NULL,
 CONSTRAINT [PK_salas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
));

ALTER TABLE [dbo].[sala] ADD  DEFAULT (getdate()) FOR [fechaAlta];


INSERT [sala] (Nombre) VALUES ('General'), 
							        ('Amigos'), 
							        ('Admins')
