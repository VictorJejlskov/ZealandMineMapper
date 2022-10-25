<template>
    <div>
        Atom
        <img src="" alt="">
    </div>
</template>
<script lang="ts">
import { defineComponent } from 'vue'

export default defineComponent({
    setup() {
        return{}
    },
    props:{
        userName: {
            required: true,
            type: String
        },
        userHandle: {
            required: true,
            type: String
        }
    }
})
</script>