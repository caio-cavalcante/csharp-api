SELECT P.Nome as Projeto, C.Nome as Colaborador
FROM Projetos P
INNER JOIN Colaboradores C ON P.Id = C.ProjetoId;
-- inner join só traz os que tem relacionamento

SELECT P.Nome as Projeto, C.Nome as Colaborador
FROM Projetos P
LEFT JOIN Colaboradores C ON P.Id = C.ProjetoId;
-- left join traz tudo, mesmo que n tenha relacionamento