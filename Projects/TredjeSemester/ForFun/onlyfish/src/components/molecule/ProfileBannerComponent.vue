<template>
  <div class="my-2">
    <div class="relative mb-3 ">
      <ProfileBannerPictureComponent :bannerPicture="userObj.bannerPicture" />
      <div
        className="w-full text-center absolute bottom-[0%] bg-grayBackground h-[40%] ">
        <ProfileInfoComponent
          :userName="userObj.name"
          :userRealm="userObj.realm" />
      </div>
      <div className="absolute bottom-[50%] pl-2 ">
        <div>
          <ProfilePictureComponent :profilePicture="userObj.profilePicture" />
        </div>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType } from "vue";
import ProfileBannerPictureComponent from "../atoms/ProfileBannerPictureComponent.vue";
import ProfilePictureComponent from "../atoms/ProfilePictureComponent.vue";
import ProfileInfoComponent from "../atoms/ProfileInfoComponent.vue";

import PostUser from "../../types/PostUser";

export default defineComponent({
  setup() {
    return {};
  },
  props: {
    userObject: {
      required: true,
      type: Object as PropType<PostUser>,
    },
  },
  data() {
    return {
      userObj: this.userObject,
    };
  },
  components: {
    ProfileBannerPictureComponent,
    ProfileInfoComponent,
    ProfilePictureComponent,
  },
  methods:{

  }
});
</script>
