<template>
  <div>
    <!-- Create Post Section -->
    <div className="sticky top-0 z-10">
      <CreatePostButton @toggle-modal="toggleModal" />
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
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType } from "vue"
import PostUser from "../types/PostUser"
import PostObject from "../types/PostObject"
import PostComponent from "./PostComponent.vue"
import CreatePostButton from "./atoms/CreatePostButton.vue"

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
    return {}
  },
  data() {
    return {
      users: this.mockUsers,
      posts: this.mockPosts,
      newPost: {} as PostObject,
    }
  },
  components: {
    PostComponent,
    CreatePostButton,
  },
  methods: {
    toggleModal() {
      this.$emit("toggleModal")
    },
  },
  computed: {
    myUsers() {
      return this.mockUsers
    },
    myPosts() {
      return this.mockPosts
    },
  },
})
</script>
