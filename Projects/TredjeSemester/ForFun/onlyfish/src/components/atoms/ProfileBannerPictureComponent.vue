<template>
    <div>
        Atom
        <img :src="bannerPicture" alt="">
    </div>
</template>


<script lang="ts">
import { defineComponent } from 'vue'

export default defineComponent({
    setup() {
        return{}        
    },
    props:{
        bannerPicture: {
            required: true,
            type: String
        }
    }
})
</script>
