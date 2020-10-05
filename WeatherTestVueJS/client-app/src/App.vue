<template>
  <div id="app">
    <AboutCard />
    <TodayCard />
    <RouterView />
  </div>
</template>

<script>
import AboutCard from "@/components/AboutCard.vue";
import TodayCard from "@/components/TodayCard.vue";

export default {
  name: "App",
  components: { TodayCard, AboutCard },
};
</script>

<style lang='scss' scoped>
#app {
  font-family: system-ui, "Open Sans", Avenir, Helvetica, Arial, sans-serif;
  color: #2c3e50;
  margin: 10px 0;
  display: flex;
  justify-content: center;
}
</style>

<style>
body {
  overflow-y: scroll;
}

body {
  background-image: radial-gradient(
      rgba(163, 163, 255, 0.5) 1px,
      transparent 1px
    ),
    radial-gradient(rgba(17, 66, 95, 0.5) 1px, transparent 1px);
  background-position: 0 0, 25px 25px;
  background-size: 50px 50px;
  background-color: white;
}
</style>