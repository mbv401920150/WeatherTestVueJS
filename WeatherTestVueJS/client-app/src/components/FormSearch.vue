<template>
  <content>
    <form @submit.prevent="searchLocation">
      <section>
        <h3>Search a new location</h3>
        <div class="oneColumn">
          <label for="new-location" :class="{ highlight: showError }">
            Location:
          </label>
          <input
            id="new-location"
            list="list-locations"
            placeholder="Location (City, State, Country)"
            v-model="newLocation"
            @keydown="removeError"
            @change="removeError"
          />
          <datalist id="list-locations">
            <option v-for="loc in getDefaultLocations" :value="loc" :key="loc">
              {{ loc }}
            </option>
          </datalist>
        </div>

        <div class="twoColumns">
          <div>
            <label for="zip-code">Zip code:</label>
            <input
              id="zip-code"
              placeholder="ZipCode (Optional)"
              v-model="zipCode"
            />
          </div>

          <div>
            <label for="temp-metric">Metric:</label>
            <select id="temp-metric" v-model="tempUnits">
              <option value="F">F</option>
              <option value="C">C</option>
              <option value="K">K</option>
            </select>
          </div>
        </div>

        <input id="btnSubmit" type="submit" value="Search" />
      </section>
    </form>

    <ModalError ref="modalError" :message="errorType" />
  </content>
</template>

<script>
import ForecastWeather from "@/services/ForecastWeather.js";
import ModalError from "@/components/ModalError";

export default {
  name: "FormSearch",
  components: {
    ModalError,
  },
  data: () => ({
    newLocation: "",
    zipCode: "",
    tempUnits: "F",
    showError: false,
    errorType: "",
  }),
  computed: {
    getDefaultLocations() {
      return this.$store.state.defaultLocations;
    },
  },
  methods: {
    removeError() {
      if (this.newLocation !== "") this.showError = false;
    },
    searchLocation() {
      // Blank or null or undefined
      if (this.newLocation === "") {
        this.showError = true;
        document.querySelector("#new-location").focus();
        return;
      }

      const payload = {
        location: this.newLocation,
        zipCode: this.zipCode,
        units: this.tempUnits,
      };

      this.errorType = "";

      ForecastWeather.get(payload)
        .then(({ data }) => {
          try {
            this.$store.commit("addForecast", { ...data });
          } catch {
            this.errorType = "duplicate";
            this.$refs.modalError.openModal();
          }
        })
        .catch(() => {
          this.errorType = "error";
          this.$refs.modalError.openModal();
        });

      this.newLocation = "";
      this.zipCode = "";
    },
  },
};
</script>

<style lang="scss" scoped>
form {
  display: flex;
  justify-content: center;
}

section {
  border: 1px solid grey;
  border-radius: 3px;
  margin: 10px;
  padding: 10px;
  width: 500px;
  display: flex;
  flex-direction: column;
}

h3 {
  border-bottom: 2px solid grey;
  border-radius: 3px;
  text-align: center;
  margin-bottom: 15px;
}

label {
  margin-top: 10px;
  font-weight: 500;
}

input,
select {
  height: 35px;
  padding: 2px 5px;
}

.highlight {
  color: tomato;

  &::before {
    content: "*";
    position: absolute;
    transform: translate(-8px, -5px);
    font-weight: bold;
  }
}

.oneColumn {
  display: flex;
  align-self: center;
  align-items: baseline;

  input {
    margin-left: 10px;
    width: 274px;
  }
}

.twoColumns {
  display: flex;
  align-self: center;
  align-items: baseline;

  #zip-code {
    margin: 0 10px;
    width: 160px;
  }

  #temp-metric {
    margin-left: 10px;
  }
}

#btnSubmit {
  margin-top: 15px;
}
</style>
