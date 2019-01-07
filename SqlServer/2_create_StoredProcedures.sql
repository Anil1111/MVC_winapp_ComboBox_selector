-- -----------------------------------------------------
-- 1. PROCEDURE spserver_save_agencies
-- -----------------------------------------------------
USE bd_combobox_crud
GO
               
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
-- 2. PROCEDURE spserver_save_employee
-- -----------------------------------------------------
USE bd_combobox_crud
GO

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

-- -----------------------------------------------------
-- 3. PROCEDURE spserver_save_client
-- -----------------------------------------------------
USE bd_combobox_crud
GO

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
-- 4. Select employees
-- -----------------------------------------------------
USE bd_combobox_crud
GO

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
-- 5. Select Agencies
-- -----------------------------------------------------
USE bd_combobox_crud
GO

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
-- 6. PROCEDURE deleteTclientByid
-- -----------------------------------------------------
USE bd_combobox_crud
GO

CREATE PROC deleteTclientByid
@aidclient int = null
As
Begin
DELETE tclient WHERE idclient = @aidclient
END
GO

-- -----------------------------------------------------
-- 7. PROCEDURE selectqclientByAgency
-- -----------------------------------------------------
USE bd_combobox_crud
GO

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
-- 8. PROCEDURE selectqclientByemployeeNumber
-- -----------------------------------------------------
USE bd_combobox_crud
GO

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
