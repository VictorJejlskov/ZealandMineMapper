<template>
  <div class="app">
    <div>
      <div className="grid grid-cols-8">
        <div className="col-span-2"></div>
        <div className="col-span-1">
          <MenuComponent className=" h-full " />
        </div>
        <div className="col-span-2">
          <PostSectionComponent
            :mockUsers="users"
            :mockPosts="posts"
            @toggle-modal="toggleModal" />
        </div>
        <div className="col-span-1">
          <suggestionsBoxComponent
            :userList="users"
            @toggle-user-modal="toggleUserModal" />
          <!-- <SuggestionsComponent :mockUsers="users" :mockPosts="posts"/> -->
        </div>
        <div className="col-span-2"></div>
      </div>
      <div
        className="fixed top-0 left-0 right-0 bottom-0 z-50 overscroll-auto"
        v-if="showCreateModal">
        <CreatePostModal
          :mockUsers="users"
          @create-post="submitEmittedPost"
          @toggle-modal="toggleModal" />
      </div>
      <div
        className="fixed top-0 left-0 right-0 bottom-0 z-50 overscroll-auto"
        v-if="showUserModal">
        <CreateUserModal
          :mockUsers="users"
          @submit-user="submitEmittedUser"
          @toggle-modal="toggleUserModal" />
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue"

import PostSectionComponent from "./components/PostSectionComponent.vue"
import MenuComponent from "./components/MenuComponent.vue"
import SuggestionsBoxComponent from "./components/template/SuggestionsBoxComponent.vue"
import CreatePostModal from "./components/organism/CreatePostModal.vue"
import CreateUserModal from "./components/organism/CreateUserModal.vue"

import PostObject from "./types/PostObject"
import PostUser from "./types/PostUser"
import moment from "moment"

const mockUsers: PostUser[] = [
  {
    userId: 1,
    name: "Fabioso",
    handle: "SexyFishMan32",
    profilePicture:
      "https://render.worldofwarcraft.com/eu/character/silvermoon/215/143824343-avatar.jpg",
    bannerPicture:
      "https://render.worldofwarcraft.com/eu/character/silvermoon/215/143824343-inset.jpg",
  },
  {
    userId: 2,
    name: "Legando",
    handle: "SubparLock",
    profilePicture:
      "https://render.worldofwarcraft.com/eu/character/silvermoon/77/192421709-avatar.jpg",
    bannerPicture:
      "https://render.worldofwarcraft.com/eu/character/silvermoon/77/192421709-inset.jpg",
  },
  {
    userId: 3,
    name: "Troopcd",
    handle: "GreyParser69",
    profilePicture:
      "https://render.worldofwarcraft.com/eu/character/silvermoon/136/108575368-avatar.jpg",
    bannerPicture:
      "https://render.worldofwarcraft.com/eu/character/silvermoon/136/108575368-inset.jpg",
  },
]
const DATEFORMAT = "DD/MM/YYYY HH:mm:ss"
const mockPosts: PostObject[] = [
  {
    postId: 4,
    thisUser: mockUsers[0],
    picture: "./assets/imgs/PostPics/FabiFlex.png",
    description: "Me on a sunny morning xoxo",
    postDate: moment().format(DATEFORMAT),
  },
  {
    postId: 3,
    thisUser: mockUsers[0],
    picture: "./assets/imgs/PostPics/UsLater.png",
    description: "NetFish n' chill?",
    postDate: moment().format(DATEFORMAT),
  },
  {
    postId: 2,
    thisUser: mockUsers[1],
    picture: "./assets/imgs/PostPics/Defaultpic.png",
    description: "No description added",
    postDate: moment().format(DATEFORMAT),
  },
  {
    postId: 1,
    thisUser: mockUsers[2],
    picture: "./assets/imgs/PostPics/Defaultpic.png",
    description: "No description added",
    postDate: moment().format(DATEFORMAT),
  },
]

export default defineComponent({
  name: "App",
  components: {
    // PostComponent,
    PostSectionComponent,
    MenuComponent,
    SuggestionsBoxComponent,
    CreatePostModal,
    CreateUserModal,

    // SuggestionsComponent
  },
  setup() {
    return {}
  },
  data() {
    return {
      users: mockUsers,
      posts: mockPosts,
      showCreateModal: false,
      showUserModal: false,
    }
  },
  methods: {
    submitEmittedPost(postObject: PostObject) {
      postObject.postId = this.posts.length + 1
      postObject.postDate = moment().format(DATEFORMAT)
      this.posts.push(Object.assign({}, postObject))
      this.posts.sort((obj1, obj2) => obj2.postId - obj1.postId)
      this.toggleModal()
    },
    submitEmittedUser(userObject: PostUser){
      userObject.userId = this.users.length + 1
      this.users.push(Object.assign({}, userObject))
      this.users.sort((obj1, obj2) => obj1.userId - obj2.userId)
      this.toggleUserModal()
      console.log(this.users)
    },
    toggleModal() {
      this.showCreateModal = !this.showCreateModal
    },
    toggleUserModal() {
      this.showUserModal = !this.showUserModal
    },
    testMethod() {
      console.log("test")
    },
  },
})
</script>

<style></style>
