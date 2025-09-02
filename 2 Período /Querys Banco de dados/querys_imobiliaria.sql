USE imobiliaria;

SELECT 
    *
FROM 
    imobiliaria.cliente
WHERE 
    telefone IS NULL;

USE imobiliaria;

SELECT 
    nome_cliente, rg
FROM 
    imobiliaria.cliente
WHERE
    bairro = 'Centro';

USE imobiliaria;

SELECT 
    nome_cliente, rua   
FROM 
    imobiliaria.cliente
WHERE   
    cidade = 'São Paulo'|| datanasc > '1990-01-01';

USE imobiliaria;

SELECT 
  codigo_cliente
FROM
    cliente
WHERE
    telefone IS NOT NULL and datanasc IS NULL; 

USE imobiliaria;

SELECT 
    codigo_imovel
FROM    
    imovel
WHERE    
    codigo_tipo IS NOT NULL;

USE imobiliaria;

SELECT  
    codigo_imovel, descricao
FROM
    imovel
WHERE
    cidade = 'Rio de Janeiro' || cidade = 'Petrópolis';