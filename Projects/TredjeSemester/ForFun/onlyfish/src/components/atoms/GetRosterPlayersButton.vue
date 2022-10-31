<template>
  <div>
    <button @click="toggleGetRosterModal">Roster</button>
  </div>
</template>
<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  setup() {
    return {};
  },
  methods: {
    toggleGetRosterModal() {
      this.$emit("toggleGetRosterModal");
    },
  },
});
</script>
