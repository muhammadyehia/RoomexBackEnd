## Prerequisites
* visual studio 2015 (May be you can use 2013 but i use 2015 in development)

* Sql Server installed on the same machine or you must edit Data Source in all connection strings in 

* Web.config in RoomexBackEndoject.Application project and 
* App.config in RoomexBackEnd.Infrastructure project and 
* app.config in RoomexBackEnd.IntegrationTest project

## First step

* From visual studio Rebuild then Run Get_GetAll_SetupedResult() test method in PlanetTest class in 
RoomexBa ckEnd.IntegrationTest project (to create the database and add the planet data to it)
OR
* Run Update-Database command in Tools –> Library Package Manager –> Package Manager Console 
choose RoomexBackEnd.Infrastructure project from the above dropdown list

## Second step

* Run the solution from the top bar click on Documentaion you will redirect to swagger documentaion click on planet 
 then click on /api/Planets then click on try it out button wait untill you see the result 
 **Copy Request URL you will use it in RoomexFrontEnd app replace it with the _url in RoomexFrontEnd/app/planet/planet.service.ts**
 
## Third step

* Run RoomexFrontEnd (Read the Read me instructions to run the app)
 **don't forget to replace  _url in RoomexFrontEnd/app/planet/planet.service.ts with your backend servise**

 
