<template>
  <div>
    <h2>Forecast list</h2>
    <Forecast
      v-for="(locationForecast, $index) in forecastList"
      :key="$index"
      :forecast="locationForecast"
    />
  </div>
</template>

<script>
import Forecast from "@/components/Forecast";

export default {
  name: "ListForecast",
  computed: {
    forecastList() {
      const sortedValues = [...this.$store.state.forecasts];

      return sortedValues.sort((a, b) => {
        var nameA = a.location.toUpperCase();
        var nameB = b.location.toUpperCase();

        if (nameA < nameB) return -1;
        if (nameA > nameB) return 1;

        // names must be equal
        return 0;
      });
    },
  },
  components: { Forecast },
};
</script>

<style scoped>
.table {
  padding: 0 5px;
  border: 1px solid #d8d8d8;
  border-radius: 2px;
}

div {
  display: inline-block;
  width: 500px;
}
</style>