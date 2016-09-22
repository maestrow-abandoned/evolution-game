var path = require('path');

module.exports = {
  entry: './main.jsx',
  output: {
    path: __dirname,
    filename: 'index.js'
  },
  devServer: {
    inline: true,
    port: 3333
  },
  module: {
    loaders: [
      {
        test: /\.jsx$/,
        exclude: /node_modules/,
        loader: 'babel-loader',
        query: {
          presets: [
            // Решение проблемы Error: Couldn't find preset "es2015" relative to directory "\\evolution-game":
            // http://stackoverflow.com/questions/34574403/how-to-set-resolve-for-babel-loader-presets/
            require.resolve('babel-preset-es2015'),
            require.resolve('babel-preset-react')
          ]
        }
      }
    ]
  }
};