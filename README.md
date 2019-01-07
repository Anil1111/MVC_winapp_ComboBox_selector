# MVC winapp ComboBox selector

### Project name : prjWin_MVC_ComboBox_selector_Rm

Fall-2018

## Description

Objective : Implementing Basic CRUD Functionality.

Building a CRUD (create, read, update, delete) code with the MVC (model, view, controller) philosophy in  C # .NET, focusing in the  ComboBox control.

### This project focus in the MVC philosophy.

![MVC](/img/MVCmodel.JPG "MVC")

### Prerequisites

 * Microsoft Visual Studio Community 2015 Version 14.0.25425.01 Update 3
 * Programming language : C#.
 * Object Oriented Programming.
 * SQL server Management Studio v17.9.
 * Programming language : SQL Server.
 * MVC Concepts.

 #### Videos
 
 * [Understanding MVC architecture](https://www.youtube.com/watch?v=eTdVkgF_Slo)
 * [SQL Server connection](https://www.youtube.com/watch?v=OdDkFPO_nto)
 * [CRUD with MVC](https://www.youtube.com/watch?v=_H8vswpMSOw&t=650s)
 * [Install Visual Studio](https://visualstudio.microsoft.com/)
 * [Install SQL Server](https://www.microsoft.com/en-ca/sql-server/sql-server-downloads)
 

## Installation

### Download and install. 

 * [Visual Studio](https://visualstudio.microsoft.com/)
 * [SQL Server](https://www.microsoft.com/en-ca/sql-server/sql-server-downloads)
 * [Dowland the MVC_ComboBox_selector project](https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector)

### Create the database with SQl server. 

1.- Create the data base : open SQL Server Management Studio, open a new query and run SqlServer/1_init_DataBase.sql

[MVC_winapp_ComboBox_selector/SqlServer/1_init_DataBase.sql](https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector/blob/master/SqlServer/1_init_DataBase.sql)

2.- Create the Stored Procedures : run SqlServer/2_create_StoredProcedures.sql

[MVC_winapp_ComboBox_selector/SqlServer/2_create_StoredProcedures.sql](https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector/blob/master/SqlServer/2_create_StoredProcedures.sql)

3.- Fill up the tables : run SqlServer/3_fill_Tables.sql

[MVC_winapp_ComboBox_selector/SqlServer/3_fill_Tables.sql](https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector/blob/master/SqlServer/3_fill_Tables.sql)

4.- Create Views : run SqlServer/4_create_Views.sql

[MVC_winapp_ComboBox_selector/SqlServer/4_create_Views.sql](https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector/blob/master/SqlServer/4_create_Views.sql)

5.- The class clsConnection connects the SQL Server and the Visual Studio

```
static private string stringConnection = "Data Source = .; DataBase = bd_combobox_crud; Integrated Security = true";
```

## Author

* **Ricardo Mendoza -  Programmer Analyst**

## Running the tests

Inteface loads the grid when it starts.

![INIT](/img/init.jpg "Init")

We can select a client by combo box Employee or combo box Agencies.

![Select by Employee or Agency](/img/select.jpg "Select by employee or agency")

We can select a row and loads the texts boxes then we can update a clietn.

![Select By Row](/img/byRow.jpg "Select by row")

Save and update are executed with the same button.


## Built With

* [Visual Studio](https://visualstudio.microsoft.com/)
* [SQL Server](https://www.microsoft.com/en-ca/sql-server/sql-server-downloads)

## Versions and source manager. 

This project uses GitHub.com as source manager in the following repository:

https://github.com/RicardoAMendoza/MVC_winapp_ComboBox_selector.git


## License

This project is licensed under the MIT License - see the [LICENSE.md](LICENSE.md) file for details

- Copyright Ricardo Mendoza
- the MIT License (MIT)

## Acknowledgments

* [Andy Del Risco](https://www.linkedin.com/in/andydelriscomanzanares/) - MENTOR, *Technicien Informatique Cl. Principale* [École des métiers de l’aérospatiale de Montréal](http://ecole-metiers-aerospatiale.csdm.ca/)
* [Fernand Tonye](https://www.linkedin.com/in/fernand-tonye-6a46532b/) - MENTOR, *Chief d'Equipe Informatique pour les enseignants* [Institut Teccart](http://www.teccart.qc.ca/)
* [Charles Vilaisak](https://www.linkedin.com/in/cvilaisak/) - MENTOR, *Registraire à l'École nationale de cirque* [École nationale de cirque](https://www.linkedin.com/school/-cole-nationale-de-cirque/)
* Jesvin Ciril Joachim - MVC
* RJ Code Advance - CRUD
* Derek Banas - SQL Server and Visual Studio Installation
* [Institut Teccart](http://www.teccart.qc.ca/)








