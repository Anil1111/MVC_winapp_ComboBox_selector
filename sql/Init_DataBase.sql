-- This project uses the following licenses:
-- MIT License
-- Copyright (c) 2018 Ricardo Mendoza 
-- Montréal Québec Canada

-- -----------------------------------------------------
-- 1. Data base bd_aspcrud_examen
-- -----------------------------------------------------
CREATE DATABASE bd_aspcrud_examen
Go

-- -----------------------------------------------------
-- 2. Table bd_aspcrud_examen.tagencies, bd_aspcrud_examen.temployee, bd_aspcrud_examen.tclient
-- -----------------------------------------------------

USE bd_aspcrud_examen
Go
-- -----------------------------------------------------
CREATE TABLE tagencies(
idagencies int identity(1,1) not null PRIMARY KEY,
agencyNumber varchar (45) null,
name varchar  (45) null,
address varchar (45) null,
idbank int not null,
idtdirectoragencie int null
)

CREATE TABLE temployee(
idemployee int identity(1,1) not null  PRIMARY KEY,
employeeNumber varchar (45) null,
name varchar (45) null,
lastName varchar (45) null,
email varchar (45) null,
img varchar (45) null,
hiringDate date null,
idagencies int not null,
sexe varchar (1)
)

CREATE TABLE tclient(
idclient int identity(1,1) not null PRIMARY KEY,
clientNumber varchar (45) null,
name varchar (45) null,
lastName varchar (45) null,
email varchar (45) null,
img varchar (45) null,
address varchar (45) null,
cardNumber varchar (45) null,
nip varchar (45) null,
idagencies int not null,
idemployee int not null,
salary decimal(100,10),
sexe varchar (1)

--- REFERNCES
CONSTRAINT RELATION_A_tagencies FOREIGN KEY (idagencies) REFERENCES tagencies(idagencies),
CONSTRAINT RELATION_A_temployee FOREIGN KEY (idemployee) REFERENCES temployee(idemployee)
)

-- -----------------------------------------------------
-- 3. PROCEDURE spserver_save_agencies
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------                
CREATE PROCEDURE spserver_save_agencies
@aidagencies int = null,
@aagencyNumber varchar (45) = null,
@aname varchar (45) = null,
@aaddress varchar (45) = null,
@aidbank int = null,
@aidtdirectorAgencie int = null
AS
BEGIN
IF @aidagencies=0
INSERT INTO tagencies (agencyNumber,name, address, idbank,idtdirectoragencie)
VALUES (@aagencyNumber,@aname, @aaddress, @aidbank, @aidtdirectorAgencie);
ELSE
UPDATE tagencies
SET agencyNumber=@aagencyNumber, name = @aname, address= @aaddress, idbank=@aidbank, idtdirectoragencie=@aidtdirectorAgencie
WHERE idagencies=@aidagencies
END
GO
-- ----------------------------------------------------- 
DROP PROC spserver_save_agencies
SELECT * FROM tagencies

-- -----------------------------------------------------
-- 4. PROCEDURE spserver_save_employee
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------
CREATE PROCEDURE [dbo].[spserver_save_employee]
@aidemployee int = null,
@aemployeeNumber varchar (45) = null,
@aname varchar (45) = null,
@alastName varchar (45) = null,
@aemail varchar (45) = null,
@aimg varchar (45) = null,
@ahiringDate date = null,
@aidagencies int = null,
@asalary decimal(12,5) = null,
@asexe varchar (1) = null
AS
BEGIN
IF @aidemployee = 0
INSERT INTO temployee (employeeNumber, name, lastName, email, img, hiringDate, idagencies,salary,sexe)
VALUES (@aemployeeNumber, @aname, @alastName, @aemail, @aimg, @ahiringDate, @aidagencies,@asalary,@asexe);
ELSE
UPDATE temployee 
SET employeeNumber=@aemployeeNumber,name=@aname,lastName=@alastName,email=@aemail,img=@aimg,hiringDate=@ahiringDate,idagencies=@aidagencies,salary =@asalary,sexe=@asexe
WHERE idemployee = @aidemployee;
END 
GO

DROP PROC spserver_save_employee
SELECT * FROM temployee

-- -----------------------------------------------------
-- 5. PROCEDURE spserver_save_client
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------
CREATE PROCEDURE spserver_save_client
@aidclient int = null,
@aclientNumber varchar (45) = null,
@aname varchar (45) = null,
@alastName varchar (45) = null,
@aemail varchar (45) = null,
@aimg varchar (45) =null,
@aaddress varchar (45) = null,
@acardNumber varchar (45) = null,
@anip varchar (45) = null,
@aidagencies int = null,
@aidemployee int = null,
@asexe varchar (1) = null
AS
BEGIN
IF @aidclient= 0
INSERT INTO tclient
(clientNumber,name,lastName,email,img,address,cardNumber,nip,idagencies,idemployee,sexe)
VALUES
(@aclientNumber,@aname,@alastName,@aimg,@aimg,@aaddress,@acardNumber,@anip,@aidagencies,@aidemployee,@asexe);
ELSE
UPDATE tclient
SET clientNumber=@aclientNumber,name=@aname,lastName=@alastName,
img=@aimg,address=@aaddress,cardNumber=@acardNumber,nip=@anip,
idagencies=@aidagencies,idemployee=@aidemployee,sexe=@asexe
WHERE idclient=@aidclient
END
GO
-- -----------------------------------------------------
EXEC spserver_save_client
DROP PROC spserver_save_client
SELECT * FROM tclient


-- -----------------------------------------------------
-- 6. Select employees
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------
CREATE PROC selectEmployee
AS
BEGIN
select 
a.idemployee as idemployee,
a.employeeNumber as 'Employee'
from temployee a order by employeeNumber
END
GO
-- -----------------------------------------------------
DROP PROC selectEmployee
EXEC selectEmployee

-- -----------------------------------------------------
-- 7. Select Agencies
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------
CREATE PROC selectAgencies
AS
BEGIN
SELECT
b.idagencies as idagencies,
b.name as 'Agency'
FROM tagencies b ORDER BY name
END
GO
-- -----------------------------------------------------
DROP PROC selectAgencies
EXEC selectAgencies

-- -----------------------------------------------------
-- 8. qclient (view)
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------
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
DROP VIEW qclient
SELECT * FROM qclient

-- -----------------------------------------------------
-- 9. Select qclient (view)
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------
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
-- -----------------------------------------------------
EXEC selectqclient
DROP PROC selectqclient

-- -----------------------------------------------------
-- 10. PROCEDURE deleteTclientByid
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------
CREATE PROC deleteTclientByid
@aidclient int = null
As
Begin
DELETE tclient WHERE idclient = @aidclient
END
GO
-- -----------------------------------------------------
SELECT * FROM tclient
EXEC deleteTclientByid @aidclient = 44

-- -----------------------------------------------------
-- 11. PROCEDURE selectqclientByAgency
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------
CREATE PROC selectqclientByAgency
@aAgency varchar (45) = null
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
WHERE b.name = @aAgency
END
GO
-- -----------------------------------------------------
DROP PROC selectqclientByAgency

exec selectqclientByAgency @aAgency = 'MontRoyal NB'
exec selectqclientByAgency @aAgency ='Rosemont NB'
exec selectqclientByAgency @aAgency ='247 Beaubien'
exec selectqclientByAgency @aAgency ='Alexander NB'

-- -----------------------------------------------------
-- 12. PROCEDURE selectqclientByemployeeNumber
-- -----------------------------------------------------

USE bd_aspcrud_examen
GO
-- -----------------------------------------------------
CREATE PROC selectqclientByemployeeNumber
@aemployeeNummber varchar (45) = null
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
WHERE c.employeeNumber = @aemployeeNummber
END
GO
-- -----------------------------------------------------
DROP PROC selectqclientByemployeeNumber

exec selectqclientByemployeeNumber @aemployeeNummber = 'E1E1'
exec selectqclientByemployeeNumber @aemployeeNummber ='E3E3'
exec selectqclientByemployeeNumber @aemployeeNummber ='E8E8'
exec selectqclientByemployeeNumber @aemployeeNummber ='E11E11'







