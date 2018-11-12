-- This project uses the following licenses:
-- MIT License
-- Copyright (c) 2018 Ricardo Mendoza 
-- Montréal Québec Canada

-- -----------------------------------------------------
-- 1.  CREATE VIEW qclient_leftjoin
-- -----------------------------------------------------

CREATE VIEW qclient_leftjoin AS
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
tclient	 a left join tagencies b on a.idagencies=b.idagencies
left join temployee c on a.idemployee=c.idemployee

-- -----------------------------------------------------
-- 2. CREATE VIEW qclient_select
-- -----------------------------------------------------

CREATE VIEW qclient_select AS
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
(select b.name from tagencies b where a.idagencies=b.idagencies) as 'Agency',
(select c.employeeNumber from temployee c where a.idemployee=c.idemployee) as 'Employee',
(select concat(c.lastName,' ',c.name) from temployee c where a.idemployee=c.idemployee) As 'Employee name',
a.img,
a.address,
a.cardNumber,
a.nip,
a.idagencies,
a.idemployee,
a.sexe
FROM
tclient a 

-- -----------------------------------------------------
-- 3. CREATE VIEW qclient_nojoins
-- -----------------------------------------------------

CREATE VIEW qclient_nojoins AS
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
(select b.name from tagencies b where a.idagencies=b.idagencies) as 'Agency',
(select c.employeeNumber from temployee c where a.idemployee=c.idemployee ) as 'Employee',
(select concat(c.lastName,' ',c.name) from temployee c where a.idemployee=c.idemployee ) As 'Employee name',
a.img,
a.address,
a.cardNumber,
a.nip,
a.idagencies,
a.idemployee,
a.sexe
FROM 
-- 1.-
--tclient a, tagencies b
--where a.idagencies = b.idagencies and b.active ='1'
tclient a 
-- 2.-
-- where a.idagencies in (select idagencies from tagencies b) --where b.active !='1')
-- 3.-
where a.idagencies in (1,2,3,4) --where b.active !='1')

