# BlissPollAPI

Hello.

This project was developed for Bliss Applications' .NET Back-End Developer selection process.

In order to run the project you must have Microsoft Visual Studio and Microsoft SQL Server installed.

When opening the project you must, if necessary, change the appsettings.json file. In the DefaultConnection section the server is set to "localhost". If necessary, upgrade to your instance host where SQL Server is installed from your local machine.

Migrations (Code First) was used to generate the "blisspolldb" database. Before running the project, open the Package Manager Console in Visual Studio, move to the BlissPollAPI project folder and type the command "dotnet ef database update -c DataContext" to create the database in the instance defined in appsettings.json. This database will not be populated at this time.
To populate the database you must run the "PopulateDB.sql" script in SQL Management Studio located in the "Data" folder in the project.

The Health Check feature of ASP.NET Core itself was used, which must be called through the url https://host:port/healthcheck or if you want to use the UI call the url https://host:port/healthchecks-ui.

The email sharing service was configured to use a fake email (https://ethereal.email/) during development.
This configuration must be changed in the appsettings.json as shown below in order to validate the sending and receiving of e-mails (it sends and receives in the same configured account):

"EmailHost": "smtp.ethereal.email",

"EmailUsername": "mput34ybhgpvgob7@ethereal.email",

"EmailPassword": "a871FZuhwB5NyMpYNm",


That way the project should run without major problems.
