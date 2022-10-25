<template>
    <div>
        Atom
        <img :src="profilePicture" alt="">
    </div>
</template>
<script lang="ts">
import { defineComponent } from 'vue'

export default defineComponent({
    setup() {
        return{}
    },
    props:{
        profilePicture:{
            required: true,
            type: String
        }
    }
})
</script>
