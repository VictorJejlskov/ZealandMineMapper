<template>
  <button>
    <div className="w-12">
      <ArrowSmallLeftIcon />
    </div>
  </button>
</template>
<script lang="ts">
import { defineComponent } from "vue"
import { ArrowSmallLeftIcon } from "@heroicons/vue/24/solid"

export default defineComponent({
  setup() {
    return {}
  },
  components: {
    ArrowSmallLeftIcon,
  },
})
</script>
