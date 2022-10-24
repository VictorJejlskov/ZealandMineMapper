<template>
  <div>
    <!-- Create Post Section -->
    <div>
      <input v-model="newPost.description" placeholder="Post Description" />
      <input v-model="newPost.picture" placeholder="Picture URL" />
      <select v-model="newPost.thisUser">
        <option
          v-for="user in users"
          v-bind:key="user.userId"
          v-bind:value="user">
          {{ user.name }}
        </option>
      </select>
      <button @click="createPost" className="rounded-full bg-blue py-2 px-4">
        Click me!
      </button>
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
import { defineComponent } from "vue"
import PostUser from "../types/PostUser"
import PostObject from "../types/PostObject"
import PostComponent from "./PostComponent.vue"

const mockUsers: PostUser[] = [
  {
    userId: 1,
    name: "Fabioso",
    handle: "SexyFishMan32",
    profilePicture: "FabiosoAvatar.png",
    bannerPicture: "",
  },
  {
    userId: 2,
    name: "Legando",
    handle: "SubparLock",
    profilePicture: "LegandoAvatar.png",
    bannerPicture: "",
  },
  {
    userId: 3,
    name: "Troopcd",
    handle: "GreyParser69",
    profilePicture: "TroopAvatar.png",
    bannerPicture: "",
  },
]
const mockPosts: PostObject[] = [
  {
    postId: 1,
    thisUser: mockUsers[0],
    picture: "./assets/imgs/PostPics/FabiFlex.png",
    description: "Me on a sunny morning xoxo",
  },
  {
    postId: 2,
    thisUser: mockUsers[0],
    picture: "./assets/imgs/PostPics/UsLater.png",
    description: "NetFish n' chill?",
  },
  {
    postId: 3,
    thisUser: mockUsers[1],
    picture: "./assets/imgs/PostPics/Defaultpic.png",
    description: "No description added",
  },
  {
    postId: 4,
    thisUser: mockUsers[2],
    picture: "./assets/imgs/PostPics/Defaultpic.png",
    description: "No description added",
  },
]
const newPostData: PostObject = {
  postId: mockPosts.length + 1,
  thisUser: mockUsers[0],
  picture: "",
  description: "",
}
export default defineComponent({
  setup() {
    return {}
  },
  data() {
    return {
      users: mockUsers,
      posts: mockPosts,
      newPost: newPostData,
    }
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
        console.log("I pushed")

        this.posts.push(this.newPost)
      } else {
        alert("Data sucks :)")
      }
      console.log("Length: " + mockPosts.length)
      console.log(mockPosts[mockPosts.length - 1])
    },
  },
  computed: {},
})
</script>
