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
          <h3 class="text-xl font-semibold text-gray">Guild Import</h3>
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
                <div className="w-full">
                  <AutoCompleteSelect
                    ref="autoCompleteSelect"
                    :data="this.realmNames"
                    @submit-realm="getRealm" />
                </div>
              </div>
            </div>
            <div class="mb-2">
              <label
                for="message"
                class="mb-1 block text-base font-medium text-[#07074D]">
                Ranks to include (default: 6)
              </label>
              <div className="flex items-center">
                <div className="w-full">
                  <input
                    type="number"
                    v-model="ranksToInclude"
                    class="w-full rounded-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-gray-dark outline-none focus:border-[#6A64F1] focus:shadow-md" />
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
          <h3 class="text-xl font-semibold text-gray">Guild Import</h3>
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
                {{ guildName }}-{{ guildRealm }} - Example Characters
              </label>
              <div className="flex items-center">
                <div class="relative w-full">
                  <ul
                    class="w-full text-sm font-medium text-gray bg-white rounded-lg border border-gray">
                    <li
                      class="w-full rounded-t-lg border-b border-gray"
                      v-for="player in exampleRoster"
                      :key="player">
                      <div class="flex items-center pl-3">
                        <input
                          id=""
                          type="checkbox"
                          value=""
                          v-model="player.include"
                          class="w-4 h-4 text-blue bg-gray rounded border-gray focus:ring-blue" />
                        <div
                          class="py-3 ml-2 w-full text-sm font-medium text-gray grid grid-cols-5">
                          <div className="col-span-2">{{ player.name }} - Rank: {{ player.rank }}</div>
                          <div className="col-span-2"></div>
                          <div>
                            {{ amountPerRank(player.rank) }} characters
                          </div>
                        </div>
                      </div>
                    </li>
                  </ul>
                </div>
              </div>
            </div>
            <div class="mb-2"></div>
          </div>
        </div>
        <!-- Modal footer -->
        <div
          class="grid grid-cols-6 p-6 rounded-b border-t border-gray dark:border-gray">
          <button
            type="button"
            class="text-white bg-green hover:bg-blue font-medium rounded-lg text-sm px-5 py-2.5 text-center"
            @click="filterRoster">
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

interface CharacterRealm {
name: string;
realm: string;
}
export default defineComponent({
  setup() {
    return {};
  },
  emits: {
    toggleModal: String,
    submitPlayers: String
  },
  data() {
    return {
      realmNames: [] as string[],
      guildName: "",
      guildRealm: "",
      newToonObject: {} as PostUser,
      showGetRoster: true,
      showSelectPlayers: false,
      totalRoster: [],
      exampleRoster: [{}] as [{ name: string; rank: number; include: boolean }],
      ranksToInclude: 6,
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
        const url = `https://eu.api.blizzard.com/data/wow/guild/${this.guildRealm.toLowerCase()}/${this.guildName.toLowerCase()}/roster?namespace=profile-eu&locale=en_US&access_token=${access_token}`;
        const response = await axios.get(url);
        console.log("Response Status: " + response.status);
        console.log(response.data["members"][0]);
        if (response.status === 200) {
          this.guildName = response.data["guild"]["name"];
          this.totalRoster = response.data["members"];
        }
        this.exampleRoster.splice(0, this.exampleRoster.length);
        for (let i = 0; i < this.ranksToInclude; i++) {
          this.exampleRoster.push(this.getExamplePlayer(i));
        }
      }
    },
    async getRealm(realm: string) {
      this.guildRealm = realm;
      await this.submitGuildRoster();
      console.log("guildname: " + this.guildName);
      console.log("guildrealm: " + this.guildRealm);
      this.showGetRoster = !this.showGetRoster;
      this.showSelectPlayers = !this.showSelectPlayers;
    },
    clearRealmData() {
      this.guildName = "";
      this.guildRealm = "";
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

    getExamplePlayer(num: number) {
      // eslint-disable-next-line
      const characterToReturn: any = this.totalRoster.find(function (r) {
        return r["rank"] == num;
      });
      console.log(characterToReturn["character"]["name"]);
      const characterObject = {
        name: characterToReturn["character"]["name"],
        rank: num,
        include: false,
      };
      return characterObject;
    },
    filterRoster() {
      // eslint-disable-next-line
      const rankArray = [] as any[];
      for (let i = 1; i < this.exampleRoster.length; i++) {
        if (this.exampleRoster[i - 1]["include"])
          rankArray.push(this.exampleRoster[i - 1]["rank"]);
      }
      // eslint-disable-next-line
      const result: any[] = this.totalRoster.filter((player) => {
        return rankArray.includes(player["rank"]);
      });
      console.log(result)
      const playerArray: CharacterRealm[] = [];
      result.forEach((player) => {
        playerArray.push({
          name: player["character"]["name"],
          realm: this.guildRealm,
        });
      });
      console.log(playerArray)
      this.$emit("submitPlayers", playerArray);
      this.toggleModal()
    },
    amountPerRank(num: number): number {
      const result = this.totalRoster.filter((player) => {
        return player["rank"] == num;
      });
      const occurrences = result.length;
      return occurrences;
    },
  },
  computed: {},
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
