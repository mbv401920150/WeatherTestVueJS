<template>
  <h3>
    <header>Today</header>
    {{ getToday }}
  </h3>
</template>

<script>
import { getToday } from "@/helpers/functions";

export default {
  name: "TodayCard",
  computed: {
    getToday: () => getToday(),
  },
};
</script>

<style lang="scss" scoped>
header {
  text-align: center;
  text-decoration: underline;
  margin-bottom: 5px;
}

h3 {
  background: white;
  position: absolute;
  top: 10px;
  right: 10px;
  font-size: 1rem;
  border: 2px solid grey;
  border-radius: 5px;
  padding: 5px;
  cursor: help;
  box-shadow: 0 0 2px;
}
</style>