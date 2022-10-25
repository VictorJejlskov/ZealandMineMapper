<template>
  <div>
    <!-- Create Post Section -->
    <div class="flex items-center justify-center p-2">
      <div class="mx-auto w-full max-w-[550px]">
          <div class="mb-2">
            <label
              for="name"
              class="mb-1 block text-base font-medium text-[#07074D]">
              User
            </label>
            <select
              v-model="newPost.thisUser"
              class="w-full rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-[#6B7280] outline-none focus:border-[#6A64F1] focus:shadow-md">
              <option
                v-for="user in users"
                v-bind:key="user.userId"
                v-bind:value="user">
                {{ user.name }}
              </option>
            </select>
          </div>
          <div class="mb-2">
            <label
              for="email"
              class="mb-1 block text-base font-medium text-[#07074D]">
              Image
            </label>
            <input
              v-model="newPost.picture"
              placeholder="Picture URL"
              class="w-full rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-[#6B7280] outline-none focus:border-[#6A64F1] focus:shadow-md" />
          </div>
          <div class="mb-2">
            <label
              for="message"
              class="mb-1 block text-base font-medium text-[#07074D]">
              Message
            </label>
            <textarea
              rows="4"
              v-model="newPost.description"
              placeholder="Post Description"
              class="w-full resize-none rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-[#6B7280] outline-none focus:border-[#6A64F1] focus:shadow-md" />
          </div>
          <div>
            <button
              @click="createPost"
              className="hover:shadow-form rounded-md bg-blue py-3 px-8 text-base font-semibold text-white outline-none">
              Submit
            </button>
          </div>
      </div>
    </div>

    <!-- List of posts section -->
    <div>
      <ul>
        <li v-for="post in posts" v-bind:key="post.postId">
          <PostComponent
            :postUser="post.thisUser"
            :postDetails="[post.picture, post.description]" />
        </li>
      </ul>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType } from "vue";
import PostUser from "../types/PostUser";
import PostObject from "../types/PostObject";
import PostComponent from "./PostComponent.vue";

export default defineComponent({
  props:{
      mockUsers:{
        required: true,
        type: Object as PropType<PostUser[]>
      },
      mockPosts:{
        required: true,
        type: Object as PropType<PostObject[]>
      }
  },
  setup() {
    return {};
  },
  data() {
    return {
      users: this.mockUsers,
      posts: this.mockPosts,
      newPost: {} as PostObject
    };
  },
  components: {
    PostComponent,
  },
  methods: {
    createPost() {
      if (
        this.newPost.thisUser !== null &&
        this.newPost.picture !== "" &&
        this.newPost.description !== ""
      ) {
        console.log("I pushed");

        this.posts.push(this.newPost);
      } else {
        alert("Data sucks :)");
      }
      console.log("Length: " + this.mockPosts.length);
      console.log(this.mockPosts[this.mockPosts.length - 1]);
    },
  },
  computed: {},
});
</script>
