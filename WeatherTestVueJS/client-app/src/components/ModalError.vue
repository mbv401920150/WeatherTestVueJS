<template>
  <ModalBase ref="modalBase">
    <template v-slot:header>
      <h1><img src="@/assets/warning.png" alt="warningModal" />Watchout</h1>
    </template>

    <template v-slot:body>
      <span v-if="message == 'error'">
        <div>Some error happens with the request.</div>
        <br />
        <b>Recommendations:</b>
        <ul>
          <li>Use the country code with zip-code (Recommended).</li>
          <li>Use the location, state, with the country code.</li>
          <li>Use the location with the country code.</li>
          <li>Use a specific keyword like: <code>Madrid, Spain</code></li>
        </ul>
      </span>
      <span v-else-if="message == 'duplicate'">
        <div>The location's already requested.</div>
        <br />
        <b>Recommendations:</b>
        <ul>
          <li>Check the list of existed locations and try again.</li>
          <li>
            If the location exists and you want to change the temperature units,
            you must delete the previous entry first.
          </li>
        </ul>
      </span>
    </template>

    <template v-slot:footer>
      <footer>
        <button @click="$refs.modalBase.closeModal()">Ok</button>
      </footer>
    </template>
  </ModalBase>
</template>

<script>
import ModalBase from "@/components/ModalBase";

export default {
  name: "ModalError",
  components: {
    ModalBase,
  },
  props: ["message"],
  methods: {
    openModal() {
      this.$refs.modalBase.openModal();
    },
  },
};
</script>

<style lang='scss' scoped>
footer {
  display: flex;
  justify-content: flex-end;
}

button {
  color: #4d5155;
  border: 1px solid #d6d8db;
  background-color: #e2e3e5;
  padding: 5px 20px;
  border-radius: 5px;
}

span {
  margin: 5px 0;
  padding: 0 5px;
}

img {
  height: 48px;
  width: 48px;
}

h1 {
  display: flex;
  align-items: center;

  img {
    margin-right: 10px;
  }
}
</style>