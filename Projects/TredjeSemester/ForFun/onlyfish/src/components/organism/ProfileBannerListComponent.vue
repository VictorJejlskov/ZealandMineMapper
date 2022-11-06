<template>
  <div>
    <ul>
      <li v-for="user in compUserList" v-bind:key="user.userId">
        <ProfileBannerComponent :userObject="user" />
      </li>
    </ul>
  </div>
  <div className="grid grid-cols-8">
    <div className="col-span-1">
      <LeftArrowButton @left-arrow-clicked="previousPage" />
    </div>
    <div className="col-span-6 text-center m-auto">
      {{ currentPage + 1 }} - {{ currentPage + compMaxSize }} | Total -
      {{ users.length }}
    </div>
    <div className="col-span-1">
      <RightArrowButton @right-arrow-clicked="nextPage" />
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
      currentPage: 0,
      takeSize: 3,
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
    RightArrowButton,
  },
  methods: {
    nextPage() {
      console.log("Takesize: " + this.takeSize)
      if (this.users.length > this.currentPage + this.takeSize) {
        this.currentPage += this.takeSize
      }
    },
    previousPage() {
      if (((this.currentPage+1) - this.takeSize) >= 1) {
        this.currentPage -= this.takeSize
      }
    },
  },
  computed: {
    compUserList() {
      console.log("Current Page: " + this.currentPage)
      console.log("Take Size: " + this.takeSize)
      console.log(this.users.slice(0, this.takeSize))
      return this.users.slice(this.currentPage, (this.currentPage+this.takeSize))
    },
    compMaxSize() {
      return this.compUserList.length
    },
  },
})
</script>
