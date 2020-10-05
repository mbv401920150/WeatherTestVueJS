<template>
  <header>
    <h6>Menu</h6>
    <RouterLink to="/"><div>Home</div></RouterLink>
    <RouterLink to="/about"><div>About</div></RouterLink>
  </header>
</template>

<script>
export default {
  name: "AboutCard",
  computed: {
    isAboutPage() {
      return this.$store.state.isAboutPage;
    },
  },
};
</script>

<style lang="scss" scoped>
header {
  background: white;
  position: absolute;
  top: 10px;
  width: 120px;
  right: 10px;
  border: 2px solid grey;
  border-radius: 5px;
  padding: 5px;
  box-shadow: 0 0 2px;
  text-align: center;
}

h6 {
  text-decoration: underline;
}
</style>