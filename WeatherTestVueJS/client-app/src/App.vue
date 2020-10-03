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
  margin-top: 10px;
}
</style>
