<template>
  <div>
    <div className="text-white pt-2">
        <b>{{userName}} </b><br/>
        {{userRealm}}
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  setup() {
    return {};
  },
  props: {
    userName: {
      required: true,
      type: String,
    },
    userRealm: {
      required: true,
      type: String,
    },
  },
//   mounted: function () {
//     console.log("profile info atom (name + handle): " + this.userName + this.userHandle);
//   },
});
</script>
