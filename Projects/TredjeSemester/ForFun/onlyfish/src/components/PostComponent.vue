<template>
  <div className="pb-3">
    <!-- Profile info -->
    <div
      className="p-6 w-full bg-white rounded-t-xl shadow-md flex items-center space-x-4 relative">
      <!-- Profile Picture -->
      <div className="shrink-0">
        <img
          className="h-12 w-12 rounded-full"
          v-bind:src="`${postUser.profilePicture}`" />
      </div>
      <!-- Profile name & handle -->
      <div>
        <div className="text-xl font-medium text-black flex w-52">
          <div className="w-full">{{ postUser.name }}</div>
        </div>
        <div className="absolute top-2 right-5">{{ currentDate }}</div>
        <p className="text-slate-500 ">{{ postUser.handle }}</p>
      </div>
    </div>
    <!-- Dividing line -->
    <div class="relative py-1 bg-white">
      <div class="absolute inset-0 flex items-center">
        <div class="w-full border-b border-gray-300"></div>
      </div>
      <div class="relative flex justify-center">
        <span class="bg-white px-4 text-sm text-gray-500"></span>
      </div>
    </div>
    <div
      className="px-6 pb-6 w-full mx-auto bg-white rounded-b-xl shadow-md relative ">
      <!-- Post Description -->
      <div>
        {{ postDetails[1] }}
      </div>
      <!-- Post Picture -->
      <div className="w-full">
        <img
          v-bind:src="`${postDetails[0]}`"
          alt="./assets/imgs/PostPics/Defaultpic.png"
          className="w-[100%] max-h-min" />
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
    postDetails: {
      required: true,
      type: Array as PropType<string[]>,
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
