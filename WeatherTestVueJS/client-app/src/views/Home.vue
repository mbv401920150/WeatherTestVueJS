<template>
  <fragment>
    <HeaderApp />
    <FormSearch />
    <ListForecast />
  </fragment>
</template>

<script>
import HeaderApp from "@/components/HeaderApp.vue";
import FormSearch from "@/components/FormSearch.vue";
import ListForecast from "@/components/ListForecast.vue";

export default {
  components: { HeaderApp, FormSearch, ListForecast },
};
</script>
