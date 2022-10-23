<template>
  <div class="app">
    <div>
      <div className="grid grid-cols-8">
        <div className="col-span-2"></div>
        <div className="col-span-1">
          <MenuComponent className=" h-full " />
        </div>
        <div className="col-span-2">
          <ul>
            <li>
              <PostComponent
                :postUser="testUsers[0]"
                :postDetails="[
                  './assets/imgs/PostPics/FabiFlex.png',
                  'Me on a sunny morning xoxo',
                ]" />
            </li>
            <li>
              <PostComponent
                :postUser="testUsers[0]"
                :postDetails="[
                  './assets/imgs/PostPics/UsLater.png',
                  'NetFish n\' chill?',
                ]" />
            </li>
            <li>
              <PostComponent
                :postUser="testUsers[1]"
                :postDetails="[
                  './assets/imgs/PostPics/Defaultpic.png',
                  'No description added',
                ]" />
            </li>
            <li>
              <PostComponent
                :postUser="testUsers[2]"
                :postDetails="[
                  './assets/imgs/PostPics/Defaultpic.png',
                  'No description added',
                ]" />
            </li>
          </ul>
        </div>
        <div className="col-span-1"></div>
        <div className="col-span-2"></div>
      </div>
    </div>
  </div>
  <SlideBar />
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";

import PostComponent from "./components/PostComponent.vue";
import MenuComponent from "./components/MenuComponent.vue";
import SlideBar from "./components/SlideBar.vue";

import PostUser from "./types/PostUser";

export default defineComponent({
  name: "App",
  components: {
    PostComponent,
    SlideBar,
    MenuComponent,
  },
  setup() {
    // const testUsers = ref<PostUser[]>([
    //   {
    //     id: 1,
    //     name: "Fabioso",
    //     handle: "SexyFishMan32",
    //     profilepicture: "FabiosoAvatar.png",
    //     bannerpicture: "",
    //   },
    //   {
    //     id: 2,
    //     name: "Legando",
    //     handle: "SubparLock",
    //     profilepicture: "LegandoAvatar.png",
    //     bannerpicture: "",
    //   },
    //   {
    //     id: 3,
    //     name: "Troopcd",
    //     handle: "GreyParser69",
    //     profilepicture: "TroopAvatar.png",
    //     bannerpicture: "",
    //   },
    // ]);
    const testUsers = ref<PostUser[]>([
      new PostUser(1, "Fabioso", "SexyFishMan32", "FabiosoAvatar.png", ""),
      new PostUser(2, "Legando", "SubparLock", "LegandoAvatar.png", ""),
      new PostUser(3, "Troopcd", "GreyParser69", "TroopAvatar.png", ""),
    ]);
    return { testUsers };
  },
  methods: {},
});
</script>

<style></style>
