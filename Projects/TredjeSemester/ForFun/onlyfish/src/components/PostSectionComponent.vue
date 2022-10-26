<template>
  <div>
    <!-- Create Post Section -->
    <CreatePostComponent @create-post="submitEmittedPost" :mockUsers="users"/>
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
import { defineComponent, PropType } from "vue"
import PostUser from "../types/PostUser"
import PostObject from "../types/PostObject"
import PostComponent from "./PostComponent.vue"
import CreatePostComponent from "./organism/CreatePostComponent.vue"


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
    CreatePostComponent,
  },
  methods: {
    createPost() {
      return ""
    },
    submitEmittedPost(postObject: PostObject) {
      postObject.postId = this.posts.length + 1
      this.posts.push(Object.assign({}, postObject))
      this.posts.sort((obj1, obj2) => obj2.postId - obj1.postId)
    },


  },
  computed: {},
})
</script>
