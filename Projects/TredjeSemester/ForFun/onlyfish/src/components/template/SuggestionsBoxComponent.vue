<template>
    <div>
        Template
        <ProfileBannerListComponent :userList="users"/>
    </div>
</template>
<script lang="ts">
import { defineComponent, PropType } from 'vue'
import ProfileBannerListComponent from "../organism/ProfileBannerListComponent.vue"
import PostUser from "../../types/PostUser";

export default defineComponent({
    setup() {
        return{}
    },
    props:{
        userList:{
            required: true,
            type: Object as PropType<PostUser[]>,
        }
    },
    data(){
        return{
            users: this.userList
        }
    },
    components:{
        ProfileBannerListComponent
    },
    mounted: function () {
    console.log(this.users)
  },
})
</script>
