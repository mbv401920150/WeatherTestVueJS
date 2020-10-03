<template>
  <Fragment>
    <div class="title">
      {{ forecast.location }} ({{ forecast.id }})
      <button class="btnDelete" @click="removeElement()">X</button>
    </div>
    <div class="flex-grid tableHeader">
      <div>Date</div>
      <div>Avg Temp (F)</div>
    </div>
    <div
      class="flex-grid"
      v-for="(date, $index) in forecast.weatherStats"
      :key="$index"
    >
      <div>{{ date.date }} {{ date.chanceOfPrecipitation ? "*" : " " }}</div>
      <div>{{ date.averageTemp }}°</div>
    </div>
  </Fragment>
</template>

<script>
export default {
  name: "Forecast",
  props: ["forecast"],
  methods: {
    removeElement() {
      this.$store.commit("removeForecast", this.forecast.location);
    },
  },
};
</script>

<style scoped>
.tableHeader {
  font-weight: bold;
}

.title {
  display: flex;
  align-items: center;
  justify-content: space-between;
  border: 1px solid #cecece;
  border-left: 5px solid #5bc0de;
  border-radius: 4px;
  padding: 0 5px;
  margin-bottom: 5px;
}

.btnDelete {
  margin: 5px 0;
  background-color: #dc3545;
  border-color: #ca2939;
  color: white;
  font-weight: bold;
}

.btnDelete:hover {
  background-color: #d02a3a;
}

.flex-grid {
  display: flex;
}

.flex-grid div {
  flex: 1;
}
</style>