<script lang="ts">
import { defineComponent, ref } from 'vue'
import PostUser from "../types/PostUser";
import PostObject from "../types/PostObject";

export default defineComponent({
    setup() {

    const mockUsers: PostUser[] = [
      {
        userId: 1, 
        name: "Fabioso", 
        handle: "SexyFishMan32",
        profilePicture: "FabiosoAvatar.png", 
        bannerPicture: ""},
      {2, "Legando", "SubparLock", "LegandoAvatar.png", ""},
      {3, "Troopcd", "GreyParser69", "TroopAvatar.png", ""}
    ];
    const mockPosts = ref<PostObject[]>([
        new PostObject(1, mockUsers[0], "","Me On a sunny morning!")
    ]);

        return {mockUsers, mockPosts}
    },
})
</script>
