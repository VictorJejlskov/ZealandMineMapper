<template>
  <div>
    <img v-bind:src="`${bannerPicture}`" className="w-full outline outline-2 outline-blue"/>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  setup() {
    return {};
  },
  props: {
    bannerPicture: {
      required: true,
      type: String,
    },
  },
//   mounted: function () {
//     console.log("Banner atom string: " + this.bannerPicture);
//   },
});
</script>
