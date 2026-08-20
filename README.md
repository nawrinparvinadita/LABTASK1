Lab Task 1 – Login, Registration & Logout System

About the Project

This is a C# Windows Forms application for user registration, login, and logout. For this lab, I changed the database connection from Microsoft Access to SQL Server.

Database Setup

First, run the database.sql file in SQL Server. It creates the db_users database and tbl_users table.

A test account is also included:

* Username: admin
* Password: admin123

How to Run

1. Run database.sql in SQL Server.
2. Open the project in Visual Studio.
3. Check the connection string in App.config.
4. If the SQL Server name is different, change the Data Source value in App.config.
5. Build and run the application.
6. Test the login using admin / admin123.

Changes I Made

App.config

I added the SQL Server connection string to App.config. This allows the database connection information to be managed from one place.

Program.cs

I changed the startup form so that the application starts with the Login form.

frmLogin.cs

I replaced the old Microsoft Access/OleDb connection with SQL Server using SqlConnection and SqlCommand. I also used @username and @password parameters to make the SQL query safer and help prevent SQL injection.

frmRegister.cs

I changed the registration code to use SQL Server. The program checks whether the username already exists and then inserts the new user’s information into tbl_users.

frmDashboard.cs

I changed the Logout button so that it returns the user to the Login screen instead of closing the whole application.

database.sql

I created the SQL Server database and tbl_users table and added a test account for checking the login system.

Technologies Used

* C#
* Windows Forms
* SQL Server
* ADO.NET
* Visual Studio

Test Account

Username: admin
Password: admin123
