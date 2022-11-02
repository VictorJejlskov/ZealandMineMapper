<template>
  <div
    id="createPostModal"
    tabindex="-1"
    aria-hidden="true"
    @click.self="toggleModal"
    class="overflow-y-auto overflow-x-hidden z-40 w-full md:inset-0 h-modal md:h-full justify-center bg-grayBackdrop backdrop-blur-sm flex modal fade">
    <div class="relative p-4 mt-24 w-full max-w-2xl md:h-auto">
      <!-- Modal content -->
      <div class="relative bg-white rounded-lg shadow">
        <!-- Modal header -->
        <div class="flex justify-between items-start p-4 rounded-t border-b">
          <h3 class="text-xl font-semibold text-gray">New Post</h3>
          <button
            type="button"
            class="text-gray bg-transparent hover:bg-gray hover:text-gray rounded-lg text-sm p-1.5 ml-auto inline-flex items-center"
            @click="toggleModal">
            <div className="w-6">
              <XMarkIcon />
            </div>
          </button>
        </div>
        <!-- Modal body -->
        <div class="flex items-center justify-center p-2">
          <div class="mx-auto w-full max-w-[550px]">
            <div class="mb-2">
              <label
                for="name"
                class="mb-1 block text-base font-medium text-gray-dark">
                User
              </label>
              <div className="flex items-center">
                <select
                  v-model="newPost.thisUser"
                  class="w-full rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-gray-dark outline-none focus:border-[#6A64F1] focus:shadow-md">
                  <option
                    v-for="user in this.mockUsers"
                    v-bind:key="user.userId"
                    v-bind:value="user">
                    {{ user.name }}
                  </option>
                </select>
                <div class="px-2 ml-2">
                  <div className="w-5"></div>
                </div>
              </div>
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
                  class="px-2 py-2 ml-2 text-sm font-medium bg-gray rounded-lg border border-purple hover:bg-blue focus:ring-4 focus:outline-none focus:ring-blue"
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
          </div>
        </div>
        <!-- Modal footer -->
        <div
          class="grid grid-cols-6 p-6 rounded-b border-t border-gray dark:border-gray">
          <button
            type="button"
            class="text-white bg-green hover:bg-blue font-medium rounded-lg text-sm px-5 py-2.5 text-center"
            @click="submitPost">
            Submit
          </button>
          <div className="col-span-4"></div>
          <button
            type="button"
            class="text-white bg-gray-dark hover:bg-blue rounded-lg border border-gray-200 text-sm font-medium px-5 py-2.5 hover:text-gray focus:z-10"
            @click="toggleModal">
            Decline
          </button>
        </div>
      </div>
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent, PropType } from "vue"
import PostObject from "../../types/PostObject"
import PostUser from "../../types/PostUser"
import { XMarkIcon, ArrowPathIcon } from "@heroicons/vue/24/solid"

import { LoremIpsum } from "lorem-ipsum"
import Axios from "axios"

export default defineComponent({
  setup() {
    return {}
  },
  data() {
    return {
      newPost: {} as PostObject,
    }
  },

  methods: {
    toggleModal() {
      this.newPost.picture = ""
      this.newPost.description = ""
      this.newPost.thisUser = {
        userId: 0,
        name: "",
        realm: "",
        profilePicture: "",
        bannerPicture: "",
      }
      this.$emit("toggleModal")
    },
    submitPost() {
      if (
        this.newPost.thisUser &&
        this.newPost.picture &&
        this.newPost.description
      ) {
        this.$emit("createPost", this.newPost)
      } else {
        alert("Data Missing!")
      }
    },
    async randomizePicture() {
      const response = await Axios.get("https://picsum.photos/800.jpg")
      const idResponse = response.headers["picsum-id"]
      const newResponse = await Axios.get(
        `https://picsum.photos/id/${idResponse}/info`
      )

      this.newPost.picture = newResponse.data["download_url"]
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
      })
      this.newPost.description = lorem.generateParagraphs(1)
    },
    away(){
        console.log("yeet")
    }
  },
  props: {
    mockUsers: {
      required: true,
      type: Object as PropType<PostUser[]>,
    },
  },

  components: {
    XMarkIcon,
    ArrowPathIcon,
  },
})
</script>
