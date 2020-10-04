<template>
  <section>
    <div class="title">
      {{ forecast.location }}
      <div v-if="forecast.zipCode !== ''" class="zipCode">
        Zip code: {{ forecast.zipCode }}
      </div>
      <button class="btnDelete" @click="removeElement()">X</button>
    </div>
    <div class="flex-grid tableHeader">
      <div>Date</div>
      <div>Avg Temp ({{ forecast.units }})</div>
    </div>
    <div
      class="flex-grid"
      v-for="date in forecast.weatherStats"
      :key="date.date"
    >
      <div>{{ date.date }} {{ date.chanceOfPrecipitation ? "*" : " " }}</div>
      <div>{{ date.averageTemp }}°</div>
    </div>
  </section>
</template>

<script>
export default {
  name: "Forecast",
  props: ["forecast"],
  methods: {
    removeElement() {
      this.$store.commit("removeForecast", this.forecast.id);
    },
  },
};
</script>

<style lang='scss' scoped>
section {
  align-self: center;
  width: 500px;
  margin-bottom: 25px;
}

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
  font-weight: bold;
  background-color: #dc3545;
  border-color: #ca2939;
  border-radius: 10px;
  color: white;

  :hover {
    background-color: #d02a3a;
  }
}

.flex-grid {
  display: flex;

  div {
    flex: 1;
  }
}

.zipCode {
  border: 1px solid #c3e6cb;
  border-radius: 20px;
  font-size: 12px;
  color: #155724;
  background-color: #d4edda;
  padding: 5px 10px;
  font-family: monospace;
  box-shadow: 1px 1px 1px;
}
</style>