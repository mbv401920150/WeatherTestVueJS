const path = require("path");

const VueLoaderPlugin = require("vue-loader/lib/plugin");

module.exports = {
  mode: "development",
  entry: { main: "./wwwroot/main.js" },
  output: {
    path: path.join(__dirname, "wwwroot/dist"),
    filename: "bundle.js",
    publicPath: "/dist/",
  },
  module: {
    rules: [{ test: /\.vue$/, loader: "vue-loader" }],
  },
  plugins: [new VueLoaderPlugin()],
};
