SELECT
    *
FROM
    hospital.paciente
WHERE
    bairro != 'Centro';


SELECT 
    *
FROM 
    hospital.paciente
WHERE 
    datanasc >'1990-01-01';

SELECT 
    *
FROM 
    hospital.medico
WHERE   
    rua = 'av. barao do rio branco';