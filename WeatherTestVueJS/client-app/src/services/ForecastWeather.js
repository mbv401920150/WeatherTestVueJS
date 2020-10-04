import Service from "./Service.js";

const apiPath = "weatherforecast";

export default {
  get({ location, zipCode, units }) {
    return Service.get(
      `${apiPath}?location=${location}&units=${units}&zipCode=${zipCode}`
    );
  },
};
