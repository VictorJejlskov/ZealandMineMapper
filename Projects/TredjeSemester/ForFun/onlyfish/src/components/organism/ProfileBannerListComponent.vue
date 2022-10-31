<template>
  <div>
    <ul>
      <li v-for="user in users" v-bind:key="user.userId">
        <ProfileBannerComponent :userObject="user" />
      </li>
    </ul>
  </div>
  <div className="grid grid-cols-8">
    <div className="col-span-1">
      <LeftArrowButton />
    </div>
    <div className="col-span-6 text-center m-auto">
      # - # | Total = #
    </div>
    <div className="col-span-1">
      <RightArrowButton />
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent, PropType } from "vue"
import PostUser from "../../types/PostUser"
import ProfileBannerComponent from "../molecule/ProfileBannerComponent.vue"
import LeftArrowButton from "../atoms/LeftArrowButton.vue"
import RightArrowButton from "../atoms/RightArrowButton.vue"

export default defineComponent({
  setup() {
    return {}
  },
  data() {
    return {
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
    LeftArrowButton,
    RightArrowButton
  },
})
</script>
