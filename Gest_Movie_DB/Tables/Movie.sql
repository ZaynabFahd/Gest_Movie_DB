﻿CREATE TABLE [dbo].[Movie]
(
	[Id] INT NOT NULL IDENTITY, 
    [Nom] NVARCHAR(255) NOT NULL, 
    [Annee] INT NOT NULL, 
    [Realisateur] NVARCHAR(75) NULL,
    CONSTRAINT [PK_Movie] PRIMARY KEY ([Id])

)
