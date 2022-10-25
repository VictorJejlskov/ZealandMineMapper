<template>
  <div>
    <ul>
      <li v-for="user in users" v-bind:key="user.userId">
        <ProfileBannerComponent :userObject="user" />
      </li>
    </ul>
  </div>
</template>
<script lang="ts">
import { defineComponent, PropType } from "vue"
import PostUser from "../../types/PostUser"
import ProfileBannerComponent from "../molecule/ProfileBannerComponent.vue"

export default defineComponent({
  setup() {
    return {}
  },
  data(){
    return{
        users: this.userList,
    }
  },
  props: {
    userList: {
      required: true,
      type: Object as PropType<PostUser[]>,
    },
  },
  components: {
    ProfileBannerComponent,
  },
  //   mounted: function () {
  //   console.log("Organism list length: " + this.userList.length)
  // },
})
</script>
