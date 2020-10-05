<template>
  <div>
    <HeaderApp />
    <FormSearch />
    <ListForecast />
  </div>
</template>

<script>
import HeaderApp from "@/components/HeaderApp.vue";
import FormSearch from "@/components/FormSearch.vue";
import ListForecast from "@/components/ListForecast.vue";

export default {
  components: { HeaderApp, FormSearch, ListForecast },
};
</script>

<style scoped>
div {
  width: 700px;
  border: 5px solid #5d5d5d;
  border-radius: 15px;
  box-shadow: 0px 0px 20px 5px #a3b6ff3b;
  min-height: 95vh;
  background: white;
}
</style>