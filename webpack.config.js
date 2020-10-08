const MiniCssExtractPlugin = require('mini-css-extract-plugin');
const FixStyleOnlyEntriesPlugin = require('webpack-fix-style-only-entries');

const outputFileName = 'codesanook-culture-switcher';
module.exports = {
    entry: {
        style: './src/style.scss',
    },
    module: {
        rules: [
            {
                test: /\.scss$/,
                use: [
                    MiniCssExtractPlugin.loader,
                    'css-loader',
                    {
                        loader: 'sass-loader', // compiles Sass to CSS, using Node Sass by default
                        options: { sourceMap: true }
                    }
                ]
            },
        ]
    },
    plugins: [
        new FixStyleOnlyEntriesPlugin(),
        new MiniCssExtractPlugin({
            filename: `./../styles/${outputFileName}.css`,
        }),
    ],
    // https://webpack.js.org/configuration/devtool/
    devtool: 'inline-source-map',
};
