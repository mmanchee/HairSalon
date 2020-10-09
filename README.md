# _Hair Salon_

#### _Week 3 C# ASP.NET MCV w/ MySQL Project for Epicodus, October 9th, 2020_

#### By _**Mike Manchee**_

## Description

It's A Salon. Tasked to build an employee/client database so that the owner (Eau Claire) can view, organize, and add new employees and clients to the salon.
<!-- Brainstorming
View a list of stylists
details of Stylists
client list for stylists
add new stylists
add clients and assign to specific stylists
Don't add clients if no stylist exists
Database Name: first_last
Export .sql file, place in top level
********** Further **************
Add search for stylists
add search for clients
Appointments
check appointments don't overlap
Stylists earnings
styling to page

 -->
### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
|  1.  Create Stylist and Client Classes | ... | ... |
|  2.  Build Stylists Controllers for Index, Create, Details, Edit, and Search | ... | ... |
|  3.  Build Clients Controllers for Create, Details, Search, and Edit | ... | ... |
|  4.  Build Home Controllers for Index | ... | ... |
|  5.  Build Home Views for Index | ... | ... |
|  6.  Build Stylist Views for Index, Create, Details, Edit, and Search | ... | ... |
|  7.  Build Language Views for Index, Create, Details, Edit, and Search | ... | ... |
|  8.  Create Appointments Class and HTML | ... | ... |
|  9.  Build Appointment Controllers for Index, Create, Delete, Details, Search, and Edit | ... | ... |
|  10.  Build Appointment Views for Index, Create, Delete, Details, Search, and Edit | ... | ... |
|  11.  Add CSS and Styling | ... | ... |


## Setup/Installation Requirements

### Project from GitHub
* Download option
  * Download files from GitHub repository by click Code and Download Zip
  * Extract files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Have fun with HairSalon <!-- TITLE HERE -->

* Cloning options
  * For cloning please use the following GitHub [tutorial](https://docs.github.com/en/enterprise/2.16/user/github/creating-cloning-and-archiving-repositories/cloning-a-repository)
  * Place files into a single directory 
  * Run GitBASH in directory
  * Type "dotnet restore" to get bin and obj files
  * Type "dotnet run" in GitBash to run the program
  * Add database per the instructions below.
  * Have fun with HairSalon <!-- TITLE HERE -->

### Database Setup
* Setup with SQL statements 
  * Enter the following code into your SQL database and run.
  ``` SQL
  
  ```
  * Go to appsettings.json and change the password if needed.

* Setup with SQL Import
  * MySQL
    * In the Navigator > Administration window, select Data Import/Restore.
    * In Import Options select Import from Self-Contained File.
    * Navigate to mike_manchee.sql.
    * Under Default Schema to be Imported To, select the New button.
      * Enter 'mike_manchee' as the name of your database.
      * Click Ok.
    * Click Start Import.
  * Go to appsettings.json and change the password if needed.

## Known Bugs

No Known Bugs

## Technologies Used

Main Programs
* MySQL
* C# / ASP.NET Core 
* MVC
* MSTest
* CSS
  * Bootstrap


### Other Links
[GitHub](https://blog.agood.cloud/img/common/github.png)
[Mike's GitHub](https://github.com/mmanchee)

### License

Copyright (c) 2020 **_{Mike Manchee}_**
Licensed under MIT