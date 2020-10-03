<template>
  <section>
    <div v-if="totalItems > 0">
      <h2>Weather forecast ({{ totalItems }})</h2>
      <h3 class="tttt" title="Today date">{{ getToday }}</h3>
      <Forecast
        v-for="forecast in forecastList"
        :key="forecast.location"
        :forecast="forecast"
      />
    </div>
    <div v-show="totalItems === 0">
      <h2>No data loaded yet</h2>
      <img src="@/assets/searchImg.png" alt="No data loaded yet" />
    </div>
  </section>
</template>

<script>
import Forecast from "@/components/Forecast";
import { sortByName, getToday } from "@/helpers/functions";

export default {
  name: "ListForecast",
  computed: {
    getToday: () => getToday(),
    totalItems() {
      return this.$store.state.forecasts.length;
    },
    forecastList() {
      const sortedValues = [...this.$store.state.forecasts];

      return sortedValues.sort((a, b) => sortByName(a, b, "location"));
    },
  },
  components: { Forecast },
};
</script>

<style lang='scss' scoped>
.table {
  padding: 0 5px;
  border: 1px solid #d8d8d8;
  border-radius: 2px;
}

div {
  display: flex;
  justify-content: center;
  flex-direction: column;

  h2 {
    align-self: center;
  }
}

img {
  width: 100px;
  height: 100px;
  align-self: center;
}

.tttt {
  position: absolute;
  top: 10px;
  right: 10px;
  font-size: 1rem;
  border: 1px solid grey;
  border-radius: 5px;
  padding: 5px;
  cursor: help;
}
</style>