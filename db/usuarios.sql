USE proyectoTaller;
CREATE TABLE [dbo].[usuarios]
(
  [Id] INT NOT NULL PRIMARY KEY,
  APELLIDO VARCHAR(255) NOT NULL,
  NOMBRE VARCHAR(255) NOT NULL,
  CORREO VARCHAR(255) NOT NULL,
  USERNAME VARCHAR(255) not null,
  password varchar(255) not null
)
