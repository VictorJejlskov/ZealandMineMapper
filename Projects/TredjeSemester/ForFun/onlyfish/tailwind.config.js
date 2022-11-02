/** @type {import('tailwindcss').Config} */
module.exports = {
  mode: "jit",
  content: ["./index.html", "./src/**/*.{vue,js,ts,jsx,tsx}"],
  theme: {
    screens: {
      sm: "480px",
      md: "768px",
      lg: "976px",
      xl: "1440px",

      tablet: "640px",
      laptop: "1024px",
      desktop: "1280px",
      
      
    },
    colors: {
      blue: "#00AFF0",
      "gray-dark": "#27272B",
      gray: "#8A96A3",
      purple: "#7e5bef",
      pink: "#ff49db",
      orange: "#ff7849",
      green: "#13ce66",
      yellow: "#ffc82c",
      "gray-light": "#d3dce6",
      white: "#ffffff",
      beige: "#ECE6D9",
      grayBackground: "#8A96A370",
      grayBackdrop: "#27272B90",
    },
    fontFamily: {
      sans: ["Graphik", "sans-serif"],
      serif: ["Merriweather", "serif"],
    },
    extend: {
      spacing: {
        128: "32rem",
        144: "36rem",
      },
      borderRadius: {
        "4xl": "2rem",
      },
    },
  },
  plugins: [],
}
