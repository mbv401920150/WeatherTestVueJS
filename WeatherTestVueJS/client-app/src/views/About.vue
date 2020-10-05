<template>
  <div class="main">
    <header>
      <h1>
        <img src="@/assets/weather.svg" alt="about-logo" />
        About this WebSite
      </h1>
    </header>
    <main>
      <h4>Initial requirements</h4>
      <p>
        Using the API provided at
        <a href="#" @click.prevent="openWeatherMapApi"
          >http://openweathermap.org</a
        >, write a C# program that determines the average daily temperature (in
        Fahrenheit, rounded to 2 decimal places), for the next 5 days in each of
        the following locations:
      </p>

      <div class="locations">
        <ul>
          <li>Marlboro, MA</li>
          <li>San Diego, CA</li>
          <li>Cheyenne, WY</li>
          <li>Anchorage, AK</li>
          <li>Austin, TX</li>
        </ul>
        <ul>
          <li>Orlando, FL</li>
          <li>Seattle, WA</li>
          <li>Cleveland, OH</li>
          <li>Portland, ME</li>
          <li>Honolulu, HI</li>
        </ul>
      </div>

      <p>
        Additionally, indicate if there is any chance of precipitation on a
        given day by adding an '*' next to the date.
      </p>

      <h4>Results</h4>
      <h5>Main features of the application</h5>

      <ul>
        <li>
          <div>The WebApp has a picklist with the default locations.</div>
          <div>Also allows to include other locations if it's required.</div>
        </li>
        <li>
          Allows to search a forecast by location or zip code (Or a
          combination).
        </li>
        <li>Allows change the temperature metric (C, F, K).</li>
        <li>Was implemented a validation to avoid duplicates.</li>
        <li>
          When the request is incorrect, a popup will show up to the user with a
          detail explanation about the error.
        </li>
        <li>The user is able to delete the previous forecasts.</li>
        <li>Was implemented a menu to navigate between two interfaces.</li>
      </ul>

      <h5>Technical features</h5>
      <ul>
        <li>
          <div>
            The initial version was created in a single file of C# posted on
            .Net Fiddle.
          </div>
          <div>
            Was created in a <code>C# console</code>. Link
            <a href="#" @click.prevent="openDotNetFiddle">here</a>.
          </div>
        </li>
        <li>
          <div>
            After the version 2 and above, the project was migrated to a full
            solution using <code>C# .Net Core 3.1</code>,
            <code>MVC Model</code>, <code>REST Api service</code>,
            <code>Vue JS interface</code>.
          </div>
          <div>
            Additional was implemented the <code>MediatR</code> library to split
            even better each request of the backend.
          </div>
        </li>
        <li>
          The solution is hosted in GitHub, link
          <a href="#" @click.prevent="openGitHub">here</a>.
        </li>
        <li>
          Was implemented the Vue frontend with <code>Node JS</code>,
          <code>Webpack</code> and <code>CLI Vue</code>.
        </li>
        <li>
          Also was implemented other <code>NPM</code> packages like
          <code>vue-router</code>, <code>vuex</code>,
          <code>sass loader</code> to implement the most common standards wide
          the Vue Development Community.
        </li>
      </ul>
    </main>
  </div>
</template>

<script>
export default {
  name: "About",
  methods: {
    openWeatherMapApi() {
      window.open("https://openweathermap.org/api", "_blank");
    },
    openDotNetFiddle() {
      window.open("https://dotnetfiddle.net/3N4NgL", "_blank");
    },
    openGitHub() {
      window.open("https://github.com/mbv401920150/WeatherTestVueJS", "_blank");
    },
  },
};
</script>

<style lang='scss' scoped>
header {
  display: flex;
  justify-content: center;

  h1 {
    font-size: 28px;
    padding: 10px;
    border-bottom: 1px solid #c7c7c7;
    width: 500px;
    text-align: center;
  }

  img {
    width: 48px;
    height: 48px;
  }
}

h5 {
  padding-left: 10px;
}

.main {
  width: 700px;
  border: 5px solid #5d5d5d;
  border-radius: 15px;
  box-shadow: 0px 0px 20px 5px #a3b6ff3b;
  min-height: 95vh;
  background: white;
  padding: 0 20px 10px 20px;
}

p {
  text-align: justify;
  text-justify: inter-word;
}

.locations {
  display: flex;
  justify-content: space-around;
}

code {
  border: 1px solid #8f8066;
  padding: 2px 4px;
  border-radius: 8px;
  white-space: nowrap;
  margin: 0 2px;
  background-color: wheat;
  color: black;
}
</style>