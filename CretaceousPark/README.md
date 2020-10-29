<br>
<p align="center">
  <u><big>|| <b>Cretaceous Park API</b> ||</big></u>
</p>
<p align="center">
    <p align="center">
      ___________________________
    </p>
    <!-- GitHub Link -->
    <p align="center">
        <a href="https://github.com/jeffdinsmore">
            <strong>Jeff Dinsmore</strong>
        </a> |  
        <a href="https://github.com/janetkarpenske">
            <strong>Janet Karpenske</strong>
        </a> | 
         <a href="https://github.com/alleyesonme21">
            <strong>Johnny Duverseau</strong>
        </a> |
         <a href="https://github.com/chloehellberg">
            <strong>Chloe Hellberg</strong>
        </a>
    </p>
    <!-- Project Shields -->
    <p align="center">
        <a href="https://github.com/jeffdinsmore/CretaceousPark.Solution/graphs/contributors">
            <img src="https://img.shields.io/github/contributors/jeffdinsmore/CretaceousPark.Solution.svg?style=plastic">
        </a>
        ¨
        <a href="https://github.com/jeffdinsmore/CretaceousPark.Solution/stargazers">
            <img src="https://img.shields.io/github/stars/jeffdinsmore/CretaceousPark.Solution.svg?color=yellow&style=plastic">
        </a>
        ¨
        <a href="https://github.com/jeffdinsmore/CretaceousPark.Solution/issues">
            <img src="https://img.shields.io/github/issues/jeffdinsmore/CretaceousPark.Solution?style=plastic">
        </a>
        <!-- ¨ -->
        <!-- <a href="https://github.com/LondresRi/Best-ReadMe-Template/blob/master/LICENSE.txt">
            <img src="https://img.shields.io/github/license/LondresRi/CoffeeTrackerAPI.Solution-API-ReadMe-Example?color=orange&style=plastic">
        </a> -->
        <!-- ¨ -->
        <!-- <a href="https://linkedin.com/in/lunsfordsk">
            <img src="https://img.shields.io/badge/-LinkedIn-black.svg?style=plastic&logo=linkedin&colorB=2867B2">
        </a> -->
    </p>    
</p>

<p align="center">
  <small>Initiated October 26th, 2020. Updated October 29th, 2020.</small>
</p>

<!-- Project Links -->
<p align="center">
    <a href="https://github.com/jeffdinsmore/CretaceousPark.Solution"><big>Project Docs</big></a> ·
    <a href="https://github.com/jeffdinsmore/CretaceousPark.Solution/issues"><big>Report Bug</big></a> ·
    <a href="https://github.com/jeffdinsmore/CretaceousPark.Solution/issues"><big>Request Feature</big></a>
</p>

------------------------------
### <u>Table of Contents</u>
* <a href="#🌐-about-the-project">About the Project</a>
    * <a href="#📖-description">Description</a>
    * <a href="#🦠-known-bugs">Known Bugs</a>
    * <a href="#🛠-built-with">Built With</a>
    <!-- * <a href="#🔍-preview">Preview</a> -->
* <a href="#🏁-getting-started">Getting Started</a>
    * <a href="#⚙️-setup-and-use">Setup and Use</a>
* <a href="#🛰️-api-documentation">API Documentation</a>
    * <a href="#✉️-contact-and-support">Contact</a>
    * <a href="#⚖️-license">License</a>
    
------------------------------

## 🌐 About the Project

### 📖 Description
An API that functions as a Cretaceous era archive for various creatures. It utilizies the RESTful principles, pagination, Swagger and hs integrated authentication to keep the API Read-Only for all users excpet administrators. The user is able to see the in-use version of the API when using Postman. Currently v1.0.

### 🦠 Known Bugs

* Authoriziation not set up on client facing side of application, therefore it is not secure.

### 🛠 Built With
* VS Code
* C#
* ASP.NET Core MVC
* MySQL Workbench
* Entity Framework Core 2.2.0
* Swagger - Swashbuckle 5.6.2
* Postman

<!-- ### 🔍 Preview -->

------------------------------

## 🏁 Getting Started

### ⚙️ Setup and Use

  #### Cloning

  1) Navigate to the [Cretaceous Park repository here](https://github.com/jeffdinsmore/CretaceousPark.Solution).
  2) Click 'Clone or download' to reveal the HTTPS url ending with .git and the 'Download ZIP' option.
  3) Open up your system Terminal or GitBash, navigate to your desktop with the command: `cd Desktop`, or whichever location suits you best.
  4) Clone the repository to your desktop: `$ git clone https://github.com/jeffdinsmore/CretaceousPark.Solution`
  5) Run the command `cd CretaceousPark.Solution` to enter into the project directory.
  6) View or Edit:
      * Code Editor - Run the command `atom .` or `code .` to open the project in Atom or VisualStudio Code respectively for review and editing.
      * Text Editor - Open by double clicking on any of the files to open in a text editor.

  #### AppSettings

  1) Create a new file in the CretaceousPark.Solution/CretaceousPark directory named `appsettings.json`
  2) Add in the following code snippet to the new appsettings.json file:
  
  ```
{
    "Logging": {
        "LogLevel": {
        "Default": "Warning"
        }
    },
    "AllowedHosts": "*",
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=cretaceous_park;uid=root;pwd=YourPassword;"
    }
}
  ```
  3) Change the server, port, and user id as necessary. Replace 'YourPassword' with relevant MySQL password (set at installation of MySQL).

  #### Database
  1) Navigate to CretaceousPark.Solution/CretaceousPark directory using the MacOS Terminal or Windows Powershell.
  2) Run the command `dotnet ef database update` to generate the database through Entity Framework Core.
  3) (Optional) To update the database with any changes to the code, run the command `dotnet ef migrations add <MigrationsName>` which will use Entity Framework Core's code-first principle to generate a database update. After, run the previous command `dotnet ef database update` to update the database.

  #### Launch the API
  1) Navigate to CretaceousPark.Solution/CretaceousPark directory using the MacOS Terminal or Windows Powershell.
  2) Run the command `dotnet run` to have access to the API in Postman or browser.

------------------------------

## 🛰️ API Documentation
Explore the API endpoints in Postman or a browser. You will not be able to utilize authentication in a browser.

### Using Swagger Documentation 
To explore the Cretaceous Park API with NSwag, launch the project using `dotnet run` with the Terminal or Powershell, and input the following URL into your browser: `http://localhost:5000/swagger`

### Using the JSON Web Token
In order to be authorized to use the POST, PUT, DELETE functionality of the API, please authenticate yourself through Postman.
* Open Postman and create a POST request using the URL: `http://localhost:5000/api/users/authenticate`
* Add the following query to the request as raw data in the Body tab:
```
{
    "UserName": "test",
    "Password": "test"
}
```
* The token will be generated in the response. Copy and paste it as the Token paramenter in the Authorization tab.

### Note on Pagination
The Cretaceous Park API returns a default of 2 results per page at a time.

To modify this, use the query parameters `limit` and `start` to alter the response results displayed. The `limit` parameter will specify how many results will be displayed, and the `start` parameter will specify which element in the response the limit should start counting.

..........................................................................................

### Endpoints
Base URL: `https://localhost:5000`

### Animals
Access information about _real_ Cretaceous period animals.

#### HTTP Request
```
GET /api/Animals
POST /api/Animals
GET /api/Animals/{id}
PUT /api/Animals/{id}
DELETE /api/Animals/{id}
```

#### Path Parameters
| Parameter | Type | Default | Required | Description |
| :---: | :---: | :---: | :---: | --- |
| name | string | none | false | Return matches by name.
| ingredient | string | none | false | Return any recipe with a specific ingredient. |

#### Example Query
```
https://localhost:5000/api/recipe/?name=Matilda&species=dino
```

#### Sample JSON Response
```
{
    "Id": 1,
    "Name": "Matilda",
    "Species": "Dino",
    "Age": 8,
}
```
### ✉️ Contact and Support

If you have any feedback or concerns, please contact one of the contributors.

<p>
    <a href="https://github.com/jeffdinsmore/CretaceousPark.Solution/issues">Report Bug</a> ·
    <a href="https://github.com/jeffdinsmore/CretaceousPark.Solution/issues">Request Feature</a>
</p>

------------------------------

### ⚖️ License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT). Copyright (c) 2020 Jeff Dinsmore, Janet Karpenske, Johnny Duverseau, & Chloe Hellberg. All Rights Reserved.
```
MIT License

Copyright (c) 2020 Jeff Dinsmore, Janet Karpenske, Johnny Duverseau, & Chloe Hellberg.

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```
<center><a href="#">Return to Top</a></center>