USE GestaoProjetosDB;
GO

-- Cria uma procedure que recebe um ID de projeto e retorna quem trabalha nele
CREATE PROCEDURE sp_BuscarColaboradoresPorProjeto
    @ProjetoId INT
AS
BEGIN
    SELECT 
        C.Id, 
        C.Nome, 
        C.Cargo, 
        C.Salario, 
        C.ProjetoId,
        P.Nome as NomeProjeto
    FROM Colaboradores C
    INNER JOIN Projetos P ON C.ProjetoId = P.Id
    WHERE P.Id = @ProjetoId;
END
GO