<template>
  <div id="app">
    <Home />
  </div>
</template>

<script>
import Home from "@/views/Home.vue";

export default {
  name: "App",
  components: {
    Home,
  },
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