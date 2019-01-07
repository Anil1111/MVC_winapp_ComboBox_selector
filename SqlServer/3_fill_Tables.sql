-- This project uses the following licenses:
-- MIT License
-- Copyright (c) 2018 Ricardo Mendoza 
-- Montréal Québec Canada

-- -----------------------------------------------------
-- 1. spserver_save_agencies
-- -----------------------------------------------------
USE bd_combobox_crud
Go

EXEC [dbo].[spserver_save_agencies] 
@aidagencies = 0,
@aagencyNumber = 'A1A1',
@aname = 'Rosemont NB',
@aaddress = '2727 Rosemont',
@aidbank = 3,
@aidtdirectorAgencie = 1

EXEC [dbo].[spserver_save_agencies] 
@aidagencies = 0,
@aagencyNumber = 'A2A2',
@aname = 'MontRoyal NB',
@aaddress = '3131 MontRoyal',
@aidbank = 3,
@aidtdirectorAgencie = 2

EXEC [dbo].[spserver_save_agencies] 
@aidagencies = 0,
@aagencyNumber = 'A3A3',
@aname = 'Beaubien NB',
@aaddress = '247 Beaubien',
@aidbank = 3,
@aidtdirectorAgencie = 3

EXEC [dbo].[spserver_save_agencies] 
@aidagencies = 0,
@aagencyNumber = 'A4A4',
@aname = 'Alexander NB',
@aaddress = '456 Alexander',
@aidbank = 3,
@aidtdirectorAgencie = 2

-- -----------------------------------------------------
-- 2. spserver_save_employee
-- -----------------------------------------------------
USE bd_combobox_crud
Go

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E1E1',
@aname  = 'Juan',
@alastName = 'Zamanego',
@aemail  = 'zamanego@gamil.com',
@aimg  = 'zamanego.png',
@ahiringDate  = '2017-02-23',
@aidagencies  = 6,
@asalary = 150000.99,
@asexe = 'M'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E3E3',
@aname  = 'Cesar',
@alastName = 'Silva',
@aemail  = 'cesar@gmail.com',
@aimg  = 'silva.png',
@ahiringDate  = '2014-09-19',
@aidagencies  = 6,
@asalary = 150000.99,
@asexe = 'M'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E4E4',
@aname  = 'Ana',
@alastName = 'Fernandez',
@aemail  = 'fernandez@gmail.com',
@aimg  = 'fernandez.png',
@ahiringDate  = '2013-11-15',
@aidagencies  = 6,
@asalary = 150000.99,
@asexe = 'F'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E2E2',
@aname  = 'Rauoul',
@alastName = 'Nguiya',
@aemail  = 'raoul@gmail.com',
@aimg  = 'nguiya.png',
@ahiringDate  = '2013-03-23',
@aidagencies  = 7,
@asalary = 150000.99,
@asexe = 'M'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E5E5',
@aname  = 'Maria',
@alastName = 'Houda',
@aemail  = 'maria@google.com',
@aimg  = 'houda.png',
@ahiringDate  = '2012-01-01',
@aidagencies  = 7,
@asalary = 150000.99,
@asexe = 'F'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E6E6',
@aname  = 'Maria',
@alastName = 'Arteaga',
@aemail  = 'arteaga@gmail.com',
@aimg  = 'arteaga.png',
@ahiringDate  = '2011-02-03',
@aidagencies  = 7,
@asalary = 150000.99,
@asexe = 'F'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E7E7',
@aname  = 'Maria',
@alastName = 'Madany',
@aemail  = 'madany@google.com',
@aimg  = 'madany.png',
@ahiringDate  = '2015-08-10',
@aidagencies  = 8,
@asalary = 100000.99,
@asexe = 'F'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E8E8',
@aname  = 'Roseely',
@alastName = 'Brand',
@aemail  = 'brand@gmail.com',
@aimg  = 'brand.png',
@ahiringDate  = '2012-05-13',
@aidagencies  = 8,
@asalary = 150000.99,
@asexe = 'F'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E10E10',
@aname  = 'Esmeralda',
@alastName = 'Mafogue',
@aemail  = 'esmeralda@gmail.com',
@aimg  = 'mafogue.png',
@ahiringDate  = '2000-09-02',
@aidagencies  = 8,
@asalary = 150000.99,
@asexe = 'F'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E9E9',
@aname  = 'Silvayn',
@alastName = 'Trudeau',
@aemail  = 'trudeau@gmail.com',
@aimg  = 'trudeau.png',
@ahiringDate  = '2012-04-21',
@aidagencies  = 9,
@asalary = 150000.99,
@asexe = 'M'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E11E11',
@aname  = 'Brack',
@alastName = 'Obama',
@aemail  = 'obama@gamil.com',
@aimg  = 'brand.png',
@ahiringDate  = '1999-01-12',
@aidagencies  = 9,
@asalary = 150000.99,
@asexe = 'M'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E12E12',
@aname  = 'Benoit',
@alastName = 'Fracoise',
@aemail  = 'benoit@gmail.com',
@aimg  = 'francoise.png',
@ahiringDate  = '1998-04-03',
@aidagencies  = 9,
@asalary = 150000.99,
@asexe = 'M'

EXEC [dbo].[spserver_save_employee] 
@aidemployee  = 0,
@aemployeeNumber  = 'E13E13',
@aname  = 'Helena',
@alastName = 'Gonzalez',
@aemail  = 'gonzalez@google.com',
@aimg  = 'gonzalez.png',
@ahiringDate  = '2015-08-10',
@aidagencies  = 8,
@asalary = 150000.99,
@asexe = 'F'

-- -----------------------------------------------------
-- 3. spserver_save_client
-- -----------------------------------------------------
USE bd_combobox_crud
Go

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C1C1',
@aname  = 'Bill',
@alastName  = 'Gates',
@aemail  = 'gates@microsoft.com',
@aimg  = 'gates.png',
@aaddress  = '3540 Masson',
@acardNumber = '123456',
@anip  = 'windows',
@aidagencies  = 1,
@aidemployee = 2,
@asexe = 'M'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C2C2',
@aname  = 'Steve',
@alastName  = 'Jobs',
@aemail  = 'jobs@apple.com',
@aimg  = 'jobs.png',
@aaddress  = '148 Cousineau',
@acardNumber = '123457',
@anip  = 'windows',
@aidagencies  = 1,
@aidemployee = 3,
@asexe = 'M'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C3C3',
@aname  = 'Oprah',
@alastName  = 'Winfreh',
@aemail  = 'oprah@google.com',
@aimg  = 'winfreh.png',
@aaddress  = '3030 Hochelaga',
@acardNumber = '123458',
@anip  = 'own',
@aidagencies  = 1,
@aidemployee = 4,
@asexe = 'F'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C5C5',
@aname  = 'Salvador',
@alastName  = 'Dali',
@aemail  = 'dali@google.com',
@aimg  = 'dali.png',
@aaddress  = '1545 La Jounnesse',
@acardNumber = '123459',
@anip  = 'pintor',
@aidagencies  = 2,
@aidemployee = 5,
@asexe = 'M'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C4C4',
@aname  = 'Rosa',
@alastName  = 'Huerta',
@aemail  = 'huerta@google.com',
@aimg  = 'huerta.png',
@aaddress  = '227 Belanger',
@acardNumber = '123469',
@anip  = 'unix',
@aidagencies  = 2,
@aidemployee = 6,
@asexe = 'F'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C6C6',
@aname  = 'Wendy',
@alastName  = 'Savala',
@aemail  = 'savala@google.com',
@aimg  = 'savala.png',
@aaddress  = '3030 Hochelaga',
@acardNumber = '123479',
@anip  = 'cpp',
@aidagencies  = 2,
@aidemployee = 7,
@asexe = 'F'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C7C7',
@aname  = 'Mark',
@alastName  = 'Zurembek',
@aemail  = 'mark@facebook.com',
@aimg  = 'zurembek.png',
@aaddress  = '616 Place Brazeau',
@acardNumber = '123489',
@anip  = 'facebook',
@aidagencies  = 3,
@aidemployee = 8,
@asexe = 'M'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C8C8',
@aname  = 'Antonio',
@alastName  = 'Maya',
@aemail  = 'maya@facebook.com',
@aimg  = 'maya.png',
@aaddress  = '316 Chilpa',
@acardNumber = '123499',
@anip  = 'alfonso13',
@aidagencies  = 3,
@aidemployee = 9,
@asexe = 'M'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C9C9',
@aname  = 'Itzel',
@alastName  = 'Alvaro',
@aemail  = 'itzel@facebook.com',
@aimg  = 'alvaro.png',
@aaddress  = '527 Alexander',
@acardNumber = '123599',
@anip  = 'quimica',
@aidagencies  = 3,
@aidemployee = 10,
@asexe = 'F'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C10C10',
@aname  = 'Fanny',
@alastName  = 'Santos',
@aemail  = 'santos@facebook.com',
@aimg  = 'santos.png',
@aaddress  = '333 Saint-Croax',
@acardNumber = '123699',
@anip  = 'veracruz',
@aidagencies  = 4,
@aidemployee = 11,
@asexe = 'F'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C11C11',
@aname  = 'Manuel',
@alastName  = 'Brizuela',
@aemail  = 'brizuela@facebook.com',
@aimg  = 'brizuela.png',
@aaddress  = '148 Cousineau',
@acardNumber = '123799',
@anip  = 'construccion',
@aidagencies  = 4,
@aidemployee = 12,
@asexe = 'M'

exec spserver_save_client
@aidclient = 0,
@aclientNumber  = 'C12C12',
@aname  = 'Pedro',
@alastName  = 'Espana',
@aemail  = 'espana@facebook.com',
@aimg  = 'espana.png',
@aaddress  = '555 Tacherau',
@acardNumber = '123899',
@anip  = 'soldadura',
@aidagencies  = 4,
@aidemployee = 1,
@asexe = 'M'