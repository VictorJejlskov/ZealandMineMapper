<template>
  <div class="app">
    <div>
      <div className="grid grid-cols-8">
        <div className="col-span-2"></div>
        <div className="col-span-1">
          <MenuComponent className=" h-full " />
        </div>
        <div className="col-span-2">
          <PostSectionComponent/>
          <!-- <ul>
            <li>
              <PostComponent
                :postUser="mockUsers[0]"
                :postDetails="[
                  './assets/imgs/PostPics/FabiFlex.png',
                  'Me on a sunny morning xoxo',
                ]" />
            </li>
            <li>
              <PostComponent
                :postUser="mockUsers[0]"
                :postDetails="[
                  './assets/imgs/PostPics/UsLater.png',
                  'NetFish n\' chill?',
                ]" />
            </li>
            <li>
              <PostComponent
                :postUser="mockUsers[1]"
                :postDetails="[
                  './assets/imgs/PostPics/Defaultpic.png',
                  'No description added',
                ]" />
            </li>
            <li>
              <PostComponent
                :postUser="mockUsers[2]"
                :postDetails="[
                  './assets/imgs/PostPics/Defaultpic.png',
                  'No description added',
                ]" />
            </li>
          </ul> -->
        </div>
        <div className="col-span-1"></div>
        <div className="col-span-2"></div>
      </div>
    </div>
  </div>
  <SlideBar />
</template>

<script lang="ts">
import { defineComponent } from "vue"

// import PostComponent from "./components/PostComponent.vue"
import PostSectionComponent from "./components/PostSectionComponent.vue"
import MenuComponent from "./components/MenuComponent.vue"
import SlideBar from "./components/SlideBar.vue"

export default defineComponent({
  name: "App",
  components: {
    // PostComponent,
    PostSectionComponent,
    SlideBar,
    MenuComponent,
  },
  setup() {
    return {}
  },
  data() {
    return { componentKey: 0 }
  },
  methods: {
    forceRerender() {
      this.componentKey += 1
    },
  },
})
</script>

<style></style>
