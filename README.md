![Picture of the back of a person with long lavendar hair in front of a pink background. Three hands surround the persons head holding various tools you would find in a hair salon.](https://img.rawpixel.com/s3fs-private/rawpixel_images/website_content/s93-td-2709_1.jpg?w=800&dpr=1&fit=default&crop=default&q=65&vib=3&con=3&usm=15&bg=F4F4F3&ixlib=js-2.2.1&s=07db618226b2888df19035246bfaf8bf)
# Eau Claire's Salon
#### An MVC web application to help Claire of Eau Claire's Salon manage her employees (stylists) and their clients.
#### By Suzanne Schuber

## Technologies Used

* ASP.NET Core MVC
* Entity Framework Core
* C# 
* MySQL Database
* HTML
* CSS
* Git
* Razor Views

## In this application you are able to add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. The stylists have specific specialties, so each client can only see (belong to) a single stylist. As the salon owner you can: 
* See a list of all stylists.
* Select a stylist, see their details, and see a list of all clients that belong to that stylist.
* Add new stylists to the system when they are hired.
* Add new clients to a specific stylist.

## Setup/Installation Requirements

1. Clone this repo.
2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's root directory called "HairSalon.Solutions"
3.Add the following dependencies.
   * dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
   * dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
4. Add a .gitignore file to root directory.
5. add obj, bin, and appsettings.json to .gitignore file.
6. Within the production directory "HairSalon", create a new file called appsettings.json.
7. Within appsettings.json, put in the following code, replacing the database, uid and pwd values with your own database name, username and password for MySQL.
<br> 
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
7. Within the production directory "HairSalon", run dotnet watch run in the command line to start the project in development mode with a watcher.

## Known Bugs
No known bugs

## License
MIT License

Copyright (c) 2023 Suzanne Schuber

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.