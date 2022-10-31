<template>
    <div className="px-2">
      <button
        class="text-black bg-beige hover:bg-gray text-sm rounded-xl  px-5 py-3 w-full"
        type="button"
        @click="scrollTop">
        Home
      </button>
    </div>
</template>
<script lang="ts">
import { defineComponent } from 'vue'

export default defineComponent({
    setup() {
        return{}
    },
    methods:{
        scrollTop(){
            window.scrollTo(0,0);
        }
    }
})
</script>
