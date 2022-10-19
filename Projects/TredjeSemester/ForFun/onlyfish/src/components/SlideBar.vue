<template>
  <div className="w-1/4 pl-10 justify-center flex flex-col">
    <img
      v-bind:src="`${images[sliderState]}`"
      alt=""
      v-bind:className="`${getCss()}`"/>
    <input
      id="steps-range"
      type="range"
      min="0"
      max="6"
      step="1"
      v-model="sliderState"
      class="w-full h-2 bg-gray-200 rounded-lg appearance-none cursor-pointer dark:bg-gray-700" />

    <div>{{ sliderState }}</div>
  </div>
</template>
<script lang="ts">
import { defineComponent, ref } from "vue";

export default defineComponent({
  components: {},
  data() {
    return {
      sliderState: ref(3),
      images: ref([
        "./assets/imgs/sliderimages/ice_3d.png",
        "./assets/imgs/sliderimages/cold_face_3d.png",
        "./assets/imgs/sliderimages/anxious_face_with_sweat_3d.png",
        "./assets/imgs/sliderimages/smiling_face_3d.png",
        "./assets/imgs/sliderimages/smiling_face_with_sunglasses_3d.png",
        "./assets/imgs/sliderimages/hot_face_3d.png",
        "./assets/imgs/sliderimages/fire_3d.png",
      ]),
      bounceCss: false,
    };
  },
  methods:{
    getCss(){
        return this.bounceCss ? "animate-bounce" : ""
    },
  },
  watch: {
    sliderState: function(value) {
        this.bounceCss = true;
        setTimeout(() => {
            this.bounceCss = false;
        }, 1500);
        console.log(value);
        console.log(this.bounceCss);
    },
  },
});
</script>
