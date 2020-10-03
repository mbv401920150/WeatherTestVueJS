import axios from "axios";

const baseURL = "http://localhost:53465/api";

export default axios.create({
  baseURL,
});
