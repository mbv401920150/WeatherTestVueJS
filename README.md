# Weather App - Intro (Requirements)

<details>
  
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

</details>

# Version History

## Version 7

<details>
  
New features
- Include the About section of the project
- Implement the Vue Router and a menu with two options to navigate.
- Several changes in the styles
- Several changes in the code to make it more easier to mantain

### Demo
![version6](https://raw.githubusercontent.com/mbv401920150/WeatherTestVueJS/master/WeatherTestVueJS/Demos/Version%207.gif)

</details>

## Version 6

<details>
  
New features
- Included multiples way to find a location:
	- Country + ZIP Code (The most accurate)
	- City + Country
	- Just a representative word like (England, Madrid, Heredia)

- The display name in the table will take the location from the API.
- If the user includes the Zip Code, then, will be included into the information.
- Includes the option to change the Temp Units (C, F, K)

Styles:
- The interface shows at center of the screen.
- Additional background pattern was included.
- Today card is display at top-right (Just to reference).
- Was changed the form interface to make smaller (To maximize the total size of the screen)
- Multiples changes in the Styles.

Fixes:
- In the backend, the ID uses the coords (Lat + Lon). Due to the API result doesn't has a real ID

Backend changes:
- Allow send Zip Code and the Temp Units.
- Multiples fixes and small other changes.

### Demo
![version6](https://raw.githubusercontent.com/mbv401920150/WeatherTestVueJS/master/WeatherTestVueJS/Demos/Version%206.gif)

</details>

## Version 5

<details>
  
NPM Packages: 
- `sass` and `sass-loader`: Used to implement SASS/SCSS into the style of the components

General:
- Improve styles, using only `display: flex` to arrange the items in the interface
- Added total items in the forecast search (In the header)
- Added a new message when the forecast list is blank

Fixes:
- Fix the `Fragment` warning, it's was required declare the Fragment element un lowercase => <fragment></fragment>

## Check average temp / custom location vs Weather WebSite
  
### Intro
The calculation of the WebApi match with external [Weather Forecast](https://weather.com/weather/tenday/l/Heredia+Heredia+Costa+Rica?canonicalCityId=f100ca8c60d480d1dad0edf84f5d37b2732e16ab7cbccebbf9b628559710fd63)

### Explanation
![double-check](https://github.com/mbv401920150/WeatherTestVueJS/blob/master/WeatherTestVueJS/Demos/Version%205%20Calculation.png?raw=true)

### Demo:

![demo-calculations](https://github.com/mbv401920150/WeatherTestVueJS/blob/master/WeatherTestVueJS/Demos/Version%205.gif?raw=true)

</details>

## Version 4

<details>
  
NPM Packages: 
- `vuex`: Manage a global state

New features in the FrontEnd:
- Avoid duplicates entries
- Allow delete items from the list
- Sort forecast results

### Demo:

![ver4](https://github.com/mbv401920150/WeatherTestVueJS/blob/master/WeatherTestVueJS/Demos/Version%204.gif?raw=true)

</details>

## Version 3

<details>
  
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

### Demo:

![ver3](https://github.com/mbv401920150/WeatherTestVueJS/blob/master/WeatherTestVueJS/Demos/Version%203.gif?raw=true)

</details>

## Version 2

<details>
  
- Implement NodeJS / NPM / WebPack to implement VueJS and split the FrontEnd in components

</details>

## Version 1

<details>
  
- Implement basic requirements
- Create BackEnd using C# .Net Core / EF
- Separate all classes into different files
- Implement MediatR
- Basic HTML implementation with `wwwroot` folder to inject VueJS. 

### Demo:

![ver1](https://github.com/mbv401920150/WeatherTestVueJS/blob/master/WeatherTestVueJS/Demos/Version%201.gif?raw=true)

</details>
