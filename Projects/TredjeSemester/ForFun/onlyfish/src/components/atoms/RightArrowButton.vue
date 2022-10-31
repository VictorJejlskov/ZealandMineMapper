<template>
  <button>
    <div className="w-full">
      <ArrowSmallRightIcon />
    </div>
  </button>
</template>
<script lang="ts">
import { defineComponent } from 'vue'
import { ArrowSmallRightIcon} from "@heroicons/vue/24/solid"

export default defineComponent({
    setup() {
        return{}
    },
    components:{
        ArrowSmallRightIcon
    }
})
</script>
