<template>
  <div className="bg-beige fixed w-full max-w-[350px]">
    <div className="pt-1 px-3 text-grey"></div>
    <div className="px-3">
      <div>
        <div>
          <CreateUserButton @toggle-user-modal="toggleUserModal" />
          <GetRosterPlayersButton @toggle-get-roster-modal="toggleUserModal" />

        </div>
        <ProfileBannerListComponent :userList="users" />
      </div>
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent, PropType } from "vue";
import ProfileBannerListComponent from "../organism/ProfileBannerListComponent.vue";
import PostUser from "../../types/PostUser";
import CreateUserButton from "../atoms/CreateUserButton.vue";
import GetRosterPlayersButton from "../atoms/GetRosterPlayersButton.vue";

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
    CreateUserButton,
    GetRosterPlayersButton
  },
  methods: {
    toggleUserModal() {
      this.$emit("toggleUserModal");
    },
  },
});
</script>
