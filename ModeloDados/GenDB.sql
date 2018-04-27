
-- DROP TABLE [dbo].[tarefa];
-- DROP TABLE [dbo].[usuario];

CREATE TABLE [dbo].[usuario] (
    [id]            INT UNIQUE IDENTITY(1,1) NOT NULL,
    [nome]          VARCHAR(30) NULL,
    PRIMARY KEY(id),
);

CREATE TABLE [dbo].[tarefa] (
    [id]            INT UNIQUE IDENTITY(1,1) NOT NULL,
    [idusuario]     INT NOT NULL,
    [registro]      DATETIME2 NULL DEFAULT GETDATE(),
    [descricao]     VARCHAR(250) NULL,
    [ehimportante]  CHAR(1) NULL DEFAULT 'N',
    [prioridade]    INT NULL DEFAULT 0,
    [ehconcluida]   CHAR(1) NULL DEFAULT 'N',
    [conclusao]     DATETIME2 NULL DEFAULT GETDATE(),
    PRIMARY KEY(id),
	CONSTRAINT fk_idusuario_usuario FOREIGN KEY (idusuario) REFERENCES usuario (id)
	  ON DELETE NO ACTION    
      ON UPDATE NO ACTION
);
