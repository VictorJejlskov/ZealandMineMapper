<template>
    <div>
        <button @click="toggleUserModal">+</button>
    </div>
</template>
<script lang="ts">
import { defineComponent } from 'vue'

export default defineComponent({
    setup() {
        return{}
    },
    methods:{
        toggleUserModal(){
            this.$emit("toggleUserModal")
        }
    }
})
</script>
