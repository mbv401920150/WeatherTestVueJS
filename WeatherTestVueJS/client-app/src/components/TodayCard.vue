<template>
  <header>
    <h3>Today</h3>
    {{ getToday }}
  </header>
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
  background: white;
  position: absolute;
  top: 110px;
  width: 120px;
  right: 10px;
  border: 2px solid grey;
  border-radius: 5px;
  padding: 5px;
  cursor: help;
  box-shadow: 0 0 2px;
  text-align: center;

  h3 {
    text-decoration: underline;
    margin-bottom: 5px;
    font-size: 1rem;
  }
}
</style>