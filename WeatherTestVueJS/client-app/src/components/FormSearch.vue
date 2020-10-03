<template>
  <fragment>
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
          <option v-for="loc in getDefaultLocations" :value="loc" :key="loc">
            {{ loc }}
          </option>
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
  </fragment>
</template>

<script>
import ForecastWeather from "@/services/ForecastWeather.js";

export default {
  name: "FormSearch",
  data: () => ({
    newLocation: "",
    zipCode: "",
    showError: false,
  }),
  computed: {
    getDefaultLocations() {
      return this.$store.state.defaultLocations;
    },
  },
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
        this.$store.commit("addForecast", { ...data })
      );

      this.newLocation = "";
    },
  },
};
</script>

<style lang="scss" scoped>
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

input {
  width: 400px;
  padding: 2px 5px;

  &[type="submit"] {
    margin-top: 20px;
  }
}

.highlight {
  color: tomato;
}
</style>
