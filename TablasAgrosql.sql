USE Proagro
drop table Estado
CREATE TABLE Estados(
	idEstado INT PRIMARY KEY IDENTITY,
	nombre VARCHAR(20) NOT NULL,
	clave VARCHAR(4) NOT NULL
)


CREATE TABLE Usuarios(
	idUsuario INT PRIMARY KEY IDENTITY,
	contraseña VARCHAR(20) NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	fechaCreacion DATETIME NOT NULL,
	rfc VARCHAR(20) NOT NULL
)

CREATE TABLE Georeferencias(
	idGeoreferencia INT PRIMARY KEY IDENTITY,
	idEstado INT NOT NULL,
	latitud FLOAT NOT NULL,
	longitud FLOAT NOT NULL,
	CONSTRAINT FK_EstadoGeo FOREIGN KEY (idEstado) REFERENCES Estados (idEstado)
)

CREATE TABLE Permisos(
	idUsuario INT NOT NULL,
	idEstado INT NOT NULL,
	CONSTRAINT FK_UsuariosPermisos FOREIGN KEY (idUsuario) REFERENCES Usuarios (idUsuario),
	CONSTRAINT FK_EstadoPermisos FOREIGN KEY (idEstado) REFERENCES Estados (idEstado)
	
)
