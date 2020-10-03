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

---

# Check average temp - Custom location vs Another Weather Forecast app:
The calculation of the WebApi match with external [Weather Forecast](https://weather.com/weather/tenday/l/Heredia+Heredia+Costa+Rica?canonicalCityId=f100ca8c60d480d1dad0edf84f5d37b2732e16ab7cbccebbf9b628559710fd63)
![double-check](https://i.imgur.com/OzyfUYe.png)

Full demo:
![demo-calculations](https://s3.us-west-2.amazonaws.com/secure.notion-static.com/d54fa229-f929-4505-88b6-65004cca987f/Demo_Calculations.gif?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAT73L2G45O3KS52Y5%2F20201003%2Fus-west-2%2Fs3%2Faws4_request&X-Amz-Date=20201003T221445Z&X-Amz-Expires=86400&X-Amz-Signature=cfe0fd5ef60d94921122872a362ef4c235fdf0acae296c9fd3c7cb988f206158&X-Amz-SignedHeaders=host&response-content-disposition=filename%20%3D%22Demo_Calculations.gif%22)
