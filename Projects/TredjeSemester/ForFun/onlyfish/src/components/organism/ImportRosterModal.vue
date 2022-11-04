<template>
  <div
    id="getRosterModal"
    tabindex="-1"
    aria-hidden="true"
    @click.self="toggleModal"
    class="overflow-y-auto overflow-x-hidden z-40 w-full md:inset-0 h-modal md:h-full justify-center bg-grayBackdrop backdrop-blur-sm flex modal fade"
    v-if="showGetRoster">
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
                Guild Name
              </label>
              <div className="flex items-center">
                <div class="relative w-full">
                  <input
                    v-model="guildName"
                    placeholder="Guild Name"
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
                <div
                  className="w-full">
                  <AutoCompleteSelect ref="autoCompleteSelect" :data="this.realmNames" @submit-realm="getRealm"/>
                </div>
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
            
            @click="submitRequest">
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
    <div
    id="selectPlayersModal"
    tabindex="-1"
    aria-hidden="true"
    @click.self="toggleModal"
    class="overflow-y-auto overflow-x-hidden z-40 w-full md:inset-0 h-modal md:h-full justify-center bg-grayBackdrop backdrop-blur-sm flex modal fade"
    v-if="showSelectPlayers">
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
                PLAYERLIST HERE
              </label>
              <div className="flex items-center">
                <div class="relative w-full">
                  <input
                    v-model="guildName"
                    placeholder="Guild Name"
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
                <div
                  className="w-full">
                  <AutoCompleteSelect ref="autoCompleteSelect" :data="this.realmNames" @submit-realm="getRealm"/>
                </div>
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
            
            @click="$refs.autoCompleteSelect.submitRealm()">
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
import { defineComponent, PropType } from "vue";
import PostUser from "../../types/PostUser";
import { XMarkIcon } from "@heroicons/vue/24/solid";
import AutoCompleteSelect from "../molecule/AutoCompleteSelect.vue";
import axios from "axios";
import oauth from "axios-oauth-client";

const CLIENT_ID = "c5bb4327df624a9eb378f9377a0cd9ae";
const CLIENT_SECRET = "uUPWqvMD2XzD0H1WWF4TBytxFx3lq2Dh";

export default defineComponent({
  setup() {
    return {};
  },
  data() {
    return {
      realmNames: [] as string[],
      guildName: "",
      guildRealm: "",
      newToonObject: {} as PostUser,
      showGetRoster: true,
      showSelectPlayers: false
    };
  },
  async mounted() {
    if (this.realmNames.length === 0) await this.getRealmList();
  },
  methods: {
    toggleModal() {
      this.guildName = "";
      this.guildRealm = "";
      this.$emit("toggleModal");
    },
    async submitGuildRoster() {
      if (this.guildName && this.guildRealm) {
        const access_token = await this.getAccessToken();
        const url = `https://eu.api.blizzard.com/data/wow/guild/${this.guildRealm}/${this.guildName}/roster?namespace=profile-eu&locale=en_US&access_token=${access_token}`;
        const response = await axios.get(url);
        if (response.status === 200) {
          console.log("DO STUFF SUBMIT GUILDROSTER")
          this.$emit("SubmitUser", this.newToonObject);
          this.clearUserData();
        }
      }
    },
    async getRealm(realm: string){
      console.log(realm)
      await this.submitGuildRoster()
    },
    submitRequest(){
      this.showGetRoster = !this.showGetRoster;
      this.showSelectPlayers = !this.showSelectPlayers;
    },
    clearUserData() {
      this.newToonObject.name = "";
      this.newToonObject.realm = "";
      this.newToonObject.profilePicture = "";
      this.newToonObject.bannerPicture = "";
    },
    // async getRandomName(){
    //   const response = await axios.get("https://api.fungenerators.com/name/generate?category=dragon")
    //   const data = response.data["contents"]["names"][0]
    // },

    async getAccessToken() {
      const getClientCredentials = oauth.clientCredentials(
        axios.create(),
        "https://oauth.battle.net/token",
        CLIENT_ID,
        CLIENT_SECRET
      );
      const auth = await getClientCredentials();
      return auth["access_token"];
    },
    async getRealmList() {
      const access_token = await this.getAccessToken();
      const url = `https://eu.api.blizzard.com/data/wow/realm/index?namespace=dynamic-eu&locale=en_US&access_token=${access_token}`;
      const response = await axios.get(url);
      const realms = response.data["realms"];
      Object.keys(realms).forEach((key) => {
        this.realmNames.push(realms[key]["name"]);
      });
      this.realmNames.sort((obj1, obj2) => obj1.localeCompare(obj2));
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
    AutoCompleteSelect: AutoCompleteSelect,
  },
});
</script>
