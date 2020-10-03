<template>
  <div>
    <h2>Forecast list</h2>
    <Forecast
      v-for="(locationForecast, $index) in ForecastList"
      :key="$index"
      :forecast="locationForecast"
    />
  </div>
</template>

<script>
import Forecast from "@/components/Forecast";

export default {
  name: "ListForecast",
  components: { Forecast },
  props: ["ForecastList"],
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