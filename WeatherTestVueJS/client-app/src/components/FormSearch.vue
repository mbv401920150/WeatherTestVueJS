<template>
  <Fragment>
    <form @submit.prevent="searchLocation">
      <section>
        <h3>Search a new location</h3>
        <label for="new-location" :class="{ highlight: showError }">
          Location{{ showError ? " (This field is required)" : "" }}:
        </label>
        <input
          id="new-location"
          list="list-locations"
          placeholder="Location - Format: (City, City code, Country)"
          v-model="newLocation"
          @keydown="removeError"
          @change="removeError"
        />
        <datalist id="list-locations">
          <option value="Marlboro,MA,US">Marlboro,MA,US</option>
          <option value="San Diego,CA,US">San Diego,CA,US</option>
          <option value="Cheyenne,WY,US">Cheyenne,WY,US</option>
          <option value="Anchorage,AK,US">Anchorage,AK,US</option>
          <option value="Austin,TX,US">Austin,TX,US</option>
          <option value="Orlando,FL,US">Orlando,FL,US</option>
          <option value="Seattle,WA,US">Seattle,WA,US</option>
          <option value="Cleveland,OH,US">Cleveland,OH,US</option>
          <option value="Portland,ME,US">Portland,ME,US</option>
          <option value="Honolulu,HI,US">Honolulu,HI,US</option>
        </datalist>

        <label for="zip-code">Zip code:</label>
        <input
          id="zip-code"
          placeholder="ZipCode (Optional)"
          v-model="zipCode"
        />

        <input type="submit" />
      </section>
    </form>
    <ListForecast v-if="forecast.length > 0" :ForecastList="forecast" />
  </Fragment>
</template>

<script>
import ForecastWeather from "@/services/ForecastWeather.js";
import ListForecast from "@/components/ListForecast.vue";

export default {
  name: "FormSearch",
  data: () => ({
    newLocation: "",
    zipCode: "",
    showError: false,
    forecast: [],
  }),
  computed: {},
  methods: {
    removeError() {
      if (this.newLocation !== "") this.showError = false;
    },
    searchLocation() {
      // Blank or null or undefined
      if (this.newLocation === "") {
        this.showError = true;
        document.querySelector("#new-location").focus();
        return;
      }

      ForecastWeather.get(this.newLocation).then(({ data }) =>
        this.forecast.push({ ...data })
      );

      this.newLocation = "";
    },
  },
  components: {
    ListForecast,
  },
};
</script>

<style scoped>
form {
  display: flex;
  justify-content: center;
}

section {
  border: 1px solid grey;
  border-radius: 3px;
  margin: 10px;
  padding: 10px;
  width: 500px;
}

h3 {
  border-bottom: 2px solid grey;
  border-radius: 3px;
}

section {
  display: grid;
  justify-content: center;
}

label {
  justify-self: left;
  margin-top: 10px;
  font-weight: 500;
}

datalist {
  font-size: 40px;
}

input {
  width: 400px;
  padding: 2px 5px;
}

.highlight {
  color: tomato;
}

input[type="submit"] {
  margin-top: 20px;
}
</style>
