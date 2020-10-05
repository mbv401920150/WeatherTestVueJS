<template>
  <div>
    <HeaderApp />
    <FormSearch />
    <ListForecast />
  </div>
</template>

<script>
import HeaderApp from "@/components/HeaderApp";
import FormSearch from "@/components/FormSearch";
import ListForecast from "@/components/ListForecast";

export default {
  name: "Home",
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