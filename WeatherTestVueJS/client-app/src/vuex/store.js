import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    defaultLocations: [
      "Marlboro,MA,US",
      "San Diego,CA,US",
      "Cheyenne,WY,US",
      "Anchorage,AK,US",
      "Austin,TX,US",
      "Orlando,FL,US",
      "Seattle,WA,US",
      "Cleveland,OH,US",
      "Portland,ME,US",
      "Honolulu,HI,US",
    ],
    forecasts: [],
  },
  mutations: {
    addForecast(state, newEntry) {
      const { id } = newEntry;

      if (state.forecasts.findIndex((x) => x.id === id) >= 0) {
        alert("The element already exists");
        return;
      }

      state.forecasts.push(newEntry);
    },
    removeForecast(state, id) {
      const newForecasts = state.forecasts.filter((f) => f.id !== id);

      state.forecasts = newForecasts;
    },
  },
  actions: {},
});
