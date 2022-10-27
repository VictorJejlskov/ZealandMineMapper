<template>
  <div className="bg-beige fixed w-full max-w-[350px]">
    <div className="pt-1 px-3 text-grey"></div>
    <div className="px-3">
      <div>
        <ProfileBannerListComponent :userList="users" />
      </div>
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent, PropType } from "vue";
import ProfileBannerListComponent from "../organism/ProfileBannerListComponent.vue";
import PostUser from "../../types/PostUser";

export default defineComponent({
  setup() {
    return {};
  },
  props: {
    userList: {
      required: true,
      type: Object as PropType<PostUser[]>,
    },
  },
  data() {
    return {
      users: this.userList,
    };
  },
  components: {
    ProfileBannerListComponent,
  },
//   mounted: function () {
//     console.log("SuggestionBox Template length: " + this.userList.length);
//   },
});
</script>
