# _Claire's Salon_

#### By _Daniel Lindsey_

#### _Admin interface for Claire's Salon that allows management of stylists and customers_

## Technologies Used

- _C#_
- _.NET Framework_
- _HTML_
- _CSS_
- _Javascript_
- _jQuery_
- _MySQL_

## Description

This is a C# web application for a salon. Once run, the site will allow the owner, Claire, to manage both stylists and customers. The application is written in C# and uses the .NET 5.0 web framework.

To view a live version of this project, please navigate to http://salon.dlinds.com:6001. If the site is offline, it is likely due to Dynamic DNS not having my current IP address at home. A script should update the DDNS entry every four hours, so please try again in a short while (or clone/run the project on your own). If it is still not up after four hours, please shoot me a message on Github and I will correct the issue!

<br>

# Setup/Installation Requirements

## Cloning the repository

To view this application, you must clone it to your computer. To do so,

1. First, you will need to access a terminal. The easiest way to do so on either OS X (Mac) or Windows is to install Visual Studio (VS) Code.
   - [Windows](https://code.visualstudio.com/docs/?dv=win64user)
   - [Mac](https://code.visualstudio.com/docs/?dv=osx)
2. Once VS Code and Node.js are installed, navigate back to [this project](https://github.com/dlinds/VendorAndOrder.Solution)
3. Locate and click the green Code button at the top of the page, and choose the option to _Download ZIP_.
4. Once downloaded, navigate to your Downloads folder and extract the contents to a location of your choosing.
5. Right click in the root directory of the folder, and choose _Open With Code_. This should open the repository in VS Code.

## Installing C# and .NET

Once the project is downloaded to your computer, you will need to download and install C# and the .NET SDK.

1. First, download and install the .NET 5 SDK

- [Mac](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-macos-x64-installer)
- [Windows](https://dotnet.microsoft.com/download/dotnet/thank-you/sdk-5.0.401-windows-x64-installer)

2. Once installed, open the project in VS Code (if it is not already open)
   and access a new terminal via the menu at top of VS Code.
3. Type the following command:
   - **_dotnet tool install -g dotnet-script_**
4. Next, configure your terminal environment with the following command

   - Mac: **_echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.zshrc_**
   - Windows: **_echo 'export PATH=$PATH:~/.dotnet/tools' >> ~/.bash_profile_**
     <br>
     <br>

## Setting up the database

Prior to running the application, you will need to install MySQL and MySQL Workbench.

- During install, take note of the password you set for MySQL.
  <br>

[Mac and Windows Download Link](https://dev.mysql.com/downloads/workbench/)

1. Once installed, open MySQL Workbench to import the database.
2. In the Navigator > Administration window, select Data Import/Restore.
3. In Import Options select Import from Self-Contained File.
4. Navigate to the root directory of the cloned project.
5. Under Default Schema to be Imported To, select the New button.
6. Enter a name for the database (ex: hair_salon)
7. Click Ok.
8. Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
9. After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. Your new database should now appear.

## Set up appsettings.json

Once the database is imported, you will need to tell the application how to access it.

1. In the HairSalon directory, create a file called appsettings.json
2. Paste the following into the file, editing both the database name and the password in the string.

   {
   "ConnectionStrings": {
   "DefaultConnection": "Server=localhost;Port=3306;database=(my-database-name-here);uid=root;pwd=(my-password-here);"
   }
   }

<br>
 
# Run the project
  Now that everything is installed and set up, you may run the project.

1. Open up a new terminal and navigate to the HairSalon Folder
2. Type in the following command: **_dotnet restore_**
3. Type in the following command: **_dotnet run_**
4. Open a web browser and navigate to http://localhost:5000

<br>

# Known Bugs

- _No known issues at this time_

<br>

# License

_MIT_

Copyright (c) _3-13-2022_ _Daniel Lindsey_
