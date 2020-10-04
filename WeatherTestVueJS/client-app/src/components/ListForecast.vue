<template>
  <section>
    <div v-if="totalItems > 0">
      <h2>Weather forecast ({{ totalItems }})</h2>

      <Forecast
        v-for="forecast in forecastList"
        :key="forecast.id"
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
import { sortByName } from "@/helpers/functions";

export default {
  name: "ListForecast",
  computed: {
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
  margin-bottom: 10px;
}
</style>