<template>
  <div>
    <img v-bind:src="`${profilePicture}`" className="rounded-full outline outline-white outline-2 w-[80%] flex-shrink-0"/>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  setup() {
    return {};
  },
  props: {
    profilePicture: {
      required: true,
      type: String,
    },
  },
//   mounted: function () {
//     console.log("Picture Atom string: " + this.profilePicture);
//   },
});
</script>
