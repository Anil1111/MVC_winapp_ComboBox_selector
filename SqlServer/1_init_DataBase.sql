-- This project uses the following licenses:
-- MIT License
-- Copyright (c) 2018 Ricardo Mendoza 
-- Montréal Québec Canada

-- -----------------------------------------------------
-- 1. Data base bd_combobox_crud
-- -----------------------------------------------------
CREATE DATABASE bd_combobox_crud
Go

-- -----------------------------------------------------
-- 2. Table bd_combobox_crud.tagencies, bd_combobox_crud.temployee, bd_combobox_crud.tclient
-- -----------------------------------------------------

USE bd_combobox_crud
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
salary decimal(38,10),
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
salary decimal(38,10),
sexe varchar (1)

--- REFERNCES
CONSTRAINT RELATION_A_tagencies FOREIGN KEY (idagencies) REFERENCES tagencies(idagencies),
CONSTRAINT RELATION_A_temployee FOREIGN KEY (idemployee) REFERENCES temployee(idemployee)
)