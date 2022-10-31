<template>
  <div
    id="createUserModal"
    tabindex="-1"
    aria-hidden="true"
    @click.self="toggleModal"
    class="overflow-y-auto overflow-x-hidden z-40 w-full md:inset-0 h-modal md:h-full justify-center bg-grayBackdrop backdrop-blur-sm flex modal fade">
    <div class="relative p-4 mt-24 w-full max-w-2xl md:h-auto">
      <!-- Modal content -->
      <div class="relative bg-white rounded-lg shadow">
        <!-- Modal header -->
        <div class="flex justify-between items-start p-4 rounded-t border-b">
          <h3 class="text-xl font-semibold text-gray">New User</h3>
          <button
            type="button"
            class="text-gray bg-transparent hover:bg-gray hover:text-gray rounded-lg text-sm p-1.5 ml-auto inline-flex items-center"
            @click="toggleModal">
            <div className="w-6">
              <XMarkIcon />
            </div>
          </button>
        </div>
        <!-- Modal body -->
        <div class="flex items-center justify-center p-2">
          <div class="mx-auto w-full max-w-[550px]">
            <div class="mb-2">
              <label class="mb-1 block text-base font-medium text-gray-dark">
                Character Name
              </label>
              <div className="flex items-center">
                <div class="relative w-full">
                  <input
                    v-model="newToonName"
                    placeholder="Character Name"
                    class="w-full rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-gray-dark outline-none focus:border-[#6A64F1] focus:shadow-md" />
                </div>
              </div>
            </div>
            <div class="mb-2">
              <label
                for="message"
                class="mb-1 block text-base font-medium text-[#07074D]">
                Realm
              </label>
              <div className="flex items-center">
                <select
                  v-model="newToonRealm"
                  class="w-full rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-gray-dark outline-none focus:border-[#6A64F1] focus:shadow-md">
                  <option
                    v-for="realm in this.realmNames"
                    v-bind:key="realm"
                    v-bind:value="realm">
                    {{ realm }}
                  </option>
                </select>
              </div>
            </div>
          </div>
        </div>
        <!-- Modal footer -->
        <div
          class="grid grid-cols-6 p-6 rounded-b border-t border-gray dark:border-gray">
          <button
            type="button"
            class="text-white bg-green hover:bg-blue font-medium rounded-lg text-sm px-5 py-2.5 text-center"
            @click="submitUser">
            Submit
          </button>
          <div className="col-span-4"></div>
          <button
            type="button"
            class="text-white bg-gray-dark hover:bg-blue rounded-lg border border-gray-200 text-sm font-medium px-5 py-2.5 hover:text-gray focus:z-10"
            @click="toggleModal">
            Decline
          </button>
        </div>
      </div>
    </div>
  </div>
</template>
<script lang="ts">
import { defineComponent, PropType } from "vue"
import PostObject from "../../types/PostObject"
import PostUser from "../../types/PostUser"
import { XMarkIcon } from "@heroicons/vue/24/solid"

import { LoremIpsum } from "lorem-ipsum"
import axios from "axios"
import oauth from "axios-oauth-client"

const CLIENT_ID = "c5bb4327df624a9eb378f9377a0cd9ae"
const CLIENT_SECRET = "uUPWqvMD2XzD0H1WWF4TBytxFx3lq2Dh"

export default defineComponent({
  setup() {
    return {}
  },
  data() {
    return {
      newPost: {} as PostObject,
      realmNames: [] as string[],
      newToonName: "",
      newToonRealm: "",
      newToonObject: {} as PostUser,
    }
  },
  async mounted() {
    if (this.realmNames.length === 0) await this.getRealmList()
  },
  methods: {
    toggleModal() {
      this.newToonName = ""
      this.newToonRealm = ""
      this.$emit("toggleModal")
    },
    async submitUser() {
      if (this.newToonName && this.newToonRealm) {
        const access_token = await this.getAccessToken()
        const url = `https://eu.api.blizzard.com/profile/wow/character/${this.newToonRealm.toLowerCase()}/${this.newToonName.toLowerCase()}/character-media?namespace=profile-eu&locale=en_US&access_token=${access_token}`
        const response = await axios.get(url)
        if (response.status === 200) {
          this.newToonObject.name = response.data["character"]["name"]
          this.newToonObject.profilePicture = response.data["assets"][0].value
          this.newToonObject.bannerPicture = response.data["assets"][1].value
          this.newToonObject.handle = ""
          console.log("NewToonObject: " + this.newToonObject)
          this.$emit("SubmitUser", this.newToonObject)
          this.clearUserData()
        }
      }
    },
    clearUserData() {
      this.newToonObject.name = ""
      this.newToonObject.handle = ""
      this.newToonObject.profilePicture = ""
      this.newToonObject.bannerPicture = ""
    },
    // async getRandomName(){
    //   const response = await axios.get("https://api.fungenerators.com/name/generate?category=dragon")
    //   const data = response.data["contents"]["names"][0]
    // },
    async randomizePicture() {
      const response = await axios.get("https://picsum.photos/800.jpg")
      const idResponse = response.headers["picsum-id"]
      const newResponse = await axios.get(
        `https://picsum.photos/id/${idResponse}/info`
      )

      this.newPost.picture = newResponse.data["download_url"]
    },
    randomizeDescription() {
      const lorem = new LoremIpsum({
        sentencesPerParagraph: {
          max: 3,
          min: 1,
        },
        wordsPerSentence: {
          max: 10,
          min: 4,
        },
      })
      this.newPost.description = lorem.generateParagraphs(1)
    },
    async getAccessToken() {
      const getClientCredentials = oauth.clientCredentials(
        axios.create(),
        "https://oauth.battle.net/token",
        CLIENT_ID,
        CLIENT_SECRET
      )
      const auth = await getClientCredentials()
      return auth["access_token"]
    },
    async getRealmList() {
      const access_token = await this.getAccessToken()
      const url = `https://eu.api.blizzard.com/data/wow/realm/index?namespace=dynamic-eu&locale=en_US&access_token=${access_token}`
      const response = await axios.get(url)
      const realms = response.data["realms"]
      Object.keys(realms).forEach((key) => {
        this.realmNames.push(realms[key]["name"])
      })
      this.realmNames.sort((obj1, obj2) => obj1.localeCompare(obj2))
    },
  },
  props: {
    mockUsers: {
      required: true,
      type: Object as PropType<PostUser[]>,
    },
  },

  components: {
    XMarkIcon,
  },
})
</script>
