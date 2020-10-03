# Version History

### Version 4
NPM Packages: 
- `vuex`: Manage a global state

New features in the FrontEnd:
- Avoid duplicates entries
- Allow delete items from the list
- Sort forecast results

### Version 3
NPM Packages: 
- `axios`: AJAX Library to fetch data from localhost
- `vue-fragment`: React.Fragment reapplication for Vue (To avoid create elements innecesary in the DOM)

Create `services` folder to manage the queries to the Server (BackEnd C#)
- Service: Main configurator
- ForecastWeather: Implement the method GET to request data from the backend (`BaseUrl/api/weatherforecast?location=[CUSTOM LOCATION]`)

VueJS:
- Split the code in VueJS Components.
- Added the `views` folder to maintain the "pages" of the application
- Added: A vue with the home content
- Added: Header of the App
- Added: Search Form
- Added: List with the result of the forecasts
- Added: Component to display the API result

General:
- Change general Icon located in the Browser's tab.
- Include a header into the app with a logo.

### Version 2
- Implement NodeJS / NPM / WebPack to implement VueJS and split the FrontEnd in components

### Version 1
- Implement basic requirements
- Create BackEnd using C# .Net Core / EF
- Separate all classes into different files
- Implement MediatR
- Basic HTML implementation with `wwwroot` folder to inject VueJS. 

# WeatherMap - Requirements
Weather App - Created on C# API REST / Entity Framework / .Net Core

The display is using VueJS

Using the API provided at [http://openweathermap.org](http://openweathermap.org), write a C# program that determines the average daily temperature (in Fahrenheit, rounded to 2 decimal places), for the next 5 days in each of the following locations:

- Marlboro, MA
- San Diego, CA
- Cheyenne, WY
- Anchorage, AK
- Austin, TX
- Orlando, FL
- Seattle, WA
- Cleveland, OH
- Portland, ME
- Honolulu, HI

Additionally, indicate if there is any chance of precipitation on a given day by adding an '*' next to the date.

## Sample output:

_______________________
Marlboro, MA (01752)
_______________________
Date       Avg Temp(F)

3/8/2017   48.39 F

3/9/2017   40.03 F

3/10/2017  30.01 F

3/11/2017  16.64 F

3/12/2017* 11.71 F

# Interface evolution

## Version 4:
![ver4](https://i.imgur.com/YkrD0yC.gif)

## Version 3:
![ver3](https://i.imgur.com/EQKWPvb.gif)

## Version 2:
No interface changes

## Version 1:
![ver1](https://i.imgur.com/Z2DSwJL.gif)
