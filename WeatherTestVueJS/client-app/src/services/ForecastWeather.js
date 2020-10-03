import Service from "./Service.js";

const apiPath = "weatherforecast";

export default {
  get(location) {
    return Service.get(`${apiPath}?location=${location}`);
  },
};
