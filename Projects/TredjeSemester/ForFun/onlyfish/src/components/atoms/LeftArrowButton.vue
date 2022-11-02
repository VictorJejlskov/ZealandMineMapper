<template>
  <button @click="leftArrowClicked">
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
  methods:{
    leftArrowClicked(){
      this.$emit("leftArrowClicked")
    }
  }
})
</script>
