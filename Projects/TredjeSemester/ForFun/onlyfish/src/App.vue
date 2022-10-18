<template>
  <div class="app">
    <PostComponent :postUser="testUsers[0]" />
    <PostComponent :postUser="testUsers[1]" />
    <PostComponent :postUser="testUsers[2]" />
    <SlideBar />
  </div>
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";

import PostComponent from "./components/PostComponent.vue";
import SlideBar from "./components/SlideBar.vue";

import PostUser from "./types/PostUser";

export default defineComponent({
  name: "App",
  components: {
    PostComponent,
    SlideBar,
  },
  setup() {
    const testUsers = ref<PostUser[]>([
      {
        name: "Fabioso",
        handle: "SexyFishMan32",
        profilepicture: "FabiosoAvatar.png",
      },
      {
        name: "Legando",
        handle: "SubparLock",
        profilepicture: "LegandoAvatar.png",
      },
      {
        name: "Troopcd",
        handle: "GreyParser69",
        profilepicture: "TroopAvatar.png",
      },
    ]);

    const name = ref("Victor");
    const age = ref<number | string>(25);

    return { name, age, testUsers };
  },
  methods: {
    changeName(name: string) {
      this.name = name;
      return name;
    },
    changeAge(age: number | string) {
      this.age = age;
      return age;
    },
  },
});
</script>

<style></style>
