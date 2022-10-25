<template>
  <div>
    <!-- Create Post Section -->
    <div class="flex items-center justify-center p-2">
      <div class="mx-auto w-full max-w-[550px]">
        <div class="mb-2">
          <label
            for="name"
            class="mb-1 block text-base font-medium text-gray-dark">
            User
          </label>
          <select
            v-model="newPost.thisUser"
            class="w-full rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-gray-dark outline-none focus:border-[#6A64F1] focus:shadow-md">
            <option
              v-for="user in users"
              v-bind:key="user.userId"
              v-bind:value="user">
              {{ user.name }}
            </option>
          </select>
        </div>
        <div class="mb-2">
          <label class="mb-1 block text-base font-medium text-gray-dark">
            Image
          </label>
          <div className="flex items-center">
            <div class="relative w-full">
              <input
                v-model="newPost.picture"
                placeholder="Picture URL"
                class="w-full rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-gray-dark outline-none focus:border-[#6A64F1] focus:shadow-md" />
            </div>
            <button
              class="px-2 py-2 ml-2 text-sm font-medium bg-gray rounded-lg border border-purple hover:bg-blue focus:ring-4 focus:outline-none focus:ring-blue-300"
              @click="randomizePicture">
              <div className="w-5 text-white">
              <ArrowPathIcon />
              </div>

            </button>
          </div>
        </div>

        <div class="mb-2">
          <label
            for="message"
            class="mb-1 block text-base font-medium text-[#07074D]">
            Message
          </label>
          <div className="flex items-center">
            <div class="relative w-full">
              <textarea
                rows="4"
                v-model="newPost.description"
                placeholder="Post Description"
                class="w-full resize-none rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-[#6B7280] outline-none focus:border-[#6A64F1] focus:shadow-md" />
            </div>

            <button
              class="px-2 py-2 ml-2 text-sm font-medium bg-gray rounded-lg border border-purple hover:bg-blue focus:ring-4 focus:outline-none focus:ring-blue-300"
              @click="randomizeDescription">
              <div className="text-white w-5">
              <ArrowPathIcon />
              </div>
            </button>
          </div>
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
    <div className="p-2">
      <ul>
        <li v-for="post in posts" v-bind:key="post.postId">
          <PostComponent
            :postUser="post.thisUser"
            :postDetails="[post.picture, post.description]" />
        </li>
      </ul>
    </div>
    <ArrowPathIcon />
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType } from "vue";
import PostUser from "../types/PostUser";
import PostObject from "../types/PostObject";
import PostComponent from "./PostComponent.vue";
import { ArrowPathIcon } from "@heroicons/vue/24/solid";
import { LoremIpsum } from "lorem-ipsum";
import Axios from "axios";

export default defineComponent({
  props: {
    mockUsers: {
      required: true,
      type: Object as PropType<PostUser[]>,
    },
    mockPosts: {
      required: true,
      type: Object as PropType<PostObject[]>,
    },
  },
  setup() {
    return {};
  },
  data() {
    return {
      users: this.mockUsers,
      posts: this.mockPosts,
      newPost: {} as PostObject,
    };
  },
  components: {
    PostComponent,
    ArrowPathIcon,
  },
  methods: {
    createPost() {
      if (
        this.newPost.thisUser !== null &&
        this.newPost.picture !== "" &&
        this.newPost.description !== ""
      ) {
        this.newPost.postId = this.posts.length + 1;
        this.posts.push(Object.assign({}, this.newPost));
        this.posts.sort((obj1, obj2) => obj2.postId - obj1.postId);
        this.newPost.picture = "";
        this.newPost.description = "";
      } else {
        alert("Data sucks :)");
      }
    },
    async randomizePicture() {
      const response = await Axios.get("https://picsum.photos/800.jpg");
      const idResponse = response.headers["picsum-id"];
      const newResponse = await Axios.get(
        `https://picsum.photos/id/${idResponse}/info`
      );

      this.newPost.picture = newResponse.data["download_url"];
    },
    randomizeDescription() {
      const lorem = new LoremIpsum({
        sentencesPerParagraph: {
          max: 3,
          min: 1,
        },
        wordsPerSentence: {
          max: 10,
          min: 4,
        },
      });
      this.newPost.description = lorem.generateParagraphs(1);
    },
  },
  computed: {},
});
</script>
