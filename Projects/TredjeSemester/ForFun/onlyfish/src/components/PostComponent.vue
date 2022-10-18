<template>
  <div className="pb-3">
    <div
      className="p-6 max-w-sm mx-auto bg-white rounded-xl shadow-md flex items-center space-x-4 relative">
      <div className="shrink-0">
        <img
          className="h-12 w-12 rounded-full"
          v-bind:src="`./assets/imgs/ProfilePics/${postUser.profilepicture}`" />
      </div>
      <div>
        <div className="text-xl font-medium text-black flex w-52">
          <div className="w-full">{{ postUser.name }}</div>
        </div>
        <div className="absolute top-2 right-5">{{ currentDate }}</div>
        <p className="text-slate-500">{{ postUser.handle }}</p>
      </div>
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent, PropType } from "vue";
import PostUser from "../types/PostUser";

export default defineComponent({
  props: {
    postUser: {
      required: true,
      type: Object as PropType<PostUser>,
    },
  },
  setup() {
    const date = new Date();
    const currentDate =
      date.getDate() + "-" + date.getMonth() + "-" + date.getFullYear();

    return { currentDate };
  },

  methods: {},
});
</script>
