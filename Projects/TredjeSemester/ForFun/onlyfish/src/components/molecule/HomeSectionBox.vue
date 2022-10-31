<template>
  <div className="bg-gray-dark border-gray border-2 rounded-b-xl mx-2">
    <div className="grid grid-cols-5 py-2 px-2">
      <div className="col-span-1">
        <HomeButton />
      </div>
      <div className="col-span-2"></div>
      <div className="col-span-2">
        <CreatePostButton @toggle-modal="toggleModal" />
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import CreatePostButton from "../atoms/CreatePostButton.vue";
import HomeButton from "../atoms/HomeButton.vue";

export default defineComponent({
  setup() {
    return {};
  },
  components: {
    CreatePostButton,
    HomeButton,
  },
  methods: {
    toggleModal() {
      this.$emit("toggleModal");
    },
  },
});
</script>
