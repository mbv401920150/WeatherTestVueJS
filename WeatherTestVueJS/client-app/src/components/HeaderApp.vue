<template>
  <header>
    <h1>
      <img src="@/assets/weather.svg" alt="forecast-logo" />
      Weather Forecast App
    </h1>
  </header>
</template>

<script>
export default {
  name: "HeaderApp",
};
</script>

<style lang='scss' scoped>
header {
  display: flex;
  justify-content: center;

  h1 {
    font-size: 28px;
    padding: 10px;
    border-bottom: 1px solid #c7c7c7;
    width: 500px;
    text-align: center;
  }

  img {
    width: 48px;
    height: 48px;
  }
}
</style>
