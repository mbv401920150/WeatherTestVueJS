import Vue from "vue";
import Fragment from "vue-fragment";
import App from "./App.vue";

Vue.use(Fragment.Plugin);

Vue.config.productionTip = false;

new Vue({
  render: (h) => h(App),
}).$mount("#app");
