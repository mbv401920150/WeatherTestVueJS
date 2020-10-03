import Vue from "vue";
import Vuex from "vuex";

Vue.use(Vuex);

export default new Vuex.Store({
  state: {
    forecasts: [],
  },
  mutations: {
    addForecast(state, newEntry) {
      const { location } = newEntry;

      if (state.forecasts.findIndex((x) => x.location === location) >= 0) {
        alert("The element already exists");
        return;
      }

      state.forecasts.push(newEntry);
    },
    removeForecast(state, location) {
      const newForecasts = state.forecasts.filter(
        (f) => f.location !== location
      );

      state.forecasts = newForecasts;
    },
  },
  actions: {},
});
