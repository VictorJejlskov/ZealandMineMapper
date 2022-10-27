<template>
    <div className="px-2 pt-2 ">
      <button
        class="text-white bg-blue hover:bg-gray font-medium rounded-xl z-50 text-sm px-5 py-3 w-full"
        type="button"
        @click="toggleModal">
        New Post
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
        toggleModal(){
            this.$emit("toggleModal")
        }
    }
})
</script>
