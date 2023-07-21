/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/**/*.{js,jsx,ts,tsx}",
  ],
  important: '#root',
  theme: {
    extend: {},
    colors: {
      'main': '#5669FF'
    }
  },
  plugins: [],
  corePlugins: {
    preflight: false // <== disable this!
  },
}