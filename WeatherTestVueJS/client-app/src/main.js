import Vue from "vue";
import Fragment from "vue-fragment";
import App from "./App.vue";
import store from "@/vuex/store.js";

Vue.use(Fragment.Plugin);

Vue.config.productionTip = false;

new Vue({
  store,
  render: (h) => h(App),
}).$mount("#app");
