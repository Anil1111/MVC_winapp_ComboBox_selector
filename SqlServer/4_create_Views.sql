-- -----------------------------------------------------
-- 1. qclient (view)
-- -----------------------------------------------------
USE bd_combobox_crud
GO

CREATE VIEW qclient AS
SELECT
a.idclient,
a.clientNumber,
case
when a.sexe ='M' THEN 'Monsieur'
WHEN a.sexe ='F' THEN 'Madame'
END AS 'Genre',
a.name,
a.lastName,
a.email,
b.name as 'Agency',
c.employeeNumber as 'Employee',
concat(c.lastName,' ',c.name) As 'Employee name',
a.img,
a.address,
a.cardNumber,
a.nip,
a.idagencies,
a.idemployee,
a.sexe
FROM
tclient	 a inner join tagencies b on a.idagencies=b.idagencies
inner join temployee c on a.idemployee=c.idemployee

-- -----------------------------------------------------
-- 2. Select qclient (view)
-- -----------------------------------------------------
USE bd_combobox_crud
GO

CREATE PROCEDURE selectqclient
AS
BEGIN
SELECT
a.idclient,
a.clientNumber,
case
when a.sexe ='M' THEN 'Monsieur'
WHEN a.sexe ='F' THEN 'Madame'
END AS 'Genre',
a.name,
a.lastName,
a.email,
b.name as 'Agency',
c.employeeNumber as 'Employee',
concat(c.lastName,' ',c.name) As 'Employee name',
a.img,
a.address,
a.cardNumber,
a.nip,
a.idagencies,
a.idemployee,
a.sexe
FROM
tclient	 a inner join tagencies b on a.idagencies=b.idagencies
inner join temployee c on a.idemployee=c.idemployee
END
GO