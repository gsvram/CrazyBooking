# CrazyBooking

## Installing

1) Clone the repository 
2) Open Solution in  VS 2019
3) At the root directory, restore required packages by running:
    * dotnet restore
4) Open Package Manager Console
    * Select CrazyBooking.DL
5) Run the below commands in Package Manager Console
    * dotnet tool install --global dotnet-ef
    * dotnet tool update --global dotnet-ef
    
6) Before running update-database command. Check the "CrazyBooking" project as set as startup project
7) Run the update database in Package Manager Console
     * Update-database
8) Build the project and run. 
