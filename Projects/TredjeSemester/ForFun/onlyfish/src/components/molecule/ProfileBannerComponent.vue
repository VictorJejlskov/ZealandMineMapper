<template>
    <div>
        Molecule
        <ProfileBannerPictureComponent :bannerPicture="userObj.bannerPicture"/>
        <ProfileInfoComponent :userName="userObj.userName" :userHandle="userObj.userHandle"/>
        <ProfilePictureComponent :profilePicture="userObj.profilePicture"/>
    </div>
</template>
<script lang="ts">
import { defineComponent, PropType } from 'vue'
import ProfileBannerPictureComponent from '../atoms/ProfileBannerPictureComponent.vue'
import ProfilePictureComponent from '../atoms/ProfilePictureComponent.vue'
import ProfileInfoComponent from "../atoms/ProfileInfoComponent.vue"

import PostUser from "../../types/PostUser";

export default defineComponent({
    setup() {
        return{}
    },
    props:{
        userObject:{
            required: true,
            type: Object as PropType<PostUser>
        }
    },
    data(){
        return{
            userObj: this.userObject
        }
    },
    components:{
        ProfileBannerPictureComponent,
        ProfileInfoComponent,
        ProfilePictureComponent,

    }
})
</script>
