<template>
  <div className="">
    <Combobox v-model="selectedRealm">
      <ComboboxInput
        @change="query = $event.target.value"
        className="w-full border-transparent focus:border-transparent focus:ring-0 rounded-md rounded-b-md border border-[#e0e0e0] bg-white py-3 px-6 text-base font-medium text-gray-dark outline-none focus:border-[#6A64F1] focus:shadow-md" 
        :placeholder="'Realm'"
        autocomplete='off'/>
      <ComboboxOptions className="">
        <ComboboxOption
          v-for="realm in filteredRealms"
          :key="realm"
          :value="realm"          
          className="text-base font-medium text-gray-dark border-x-2 border-y-1 border hover:bg-gray-light">
          {{ realm }}
        </ComboboxOption>
      </ComboboxOptions>
    </Combobox>
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType } from "vue";
import {
  Combobox,
  ComboboxInput,
  ComboboxOptions,
  ComboboxOption,
} from "@headlessui/vue";
export default defineComponent({
  data() {
    return {
      selectedRealm: "",
      query: "",
      realms: this.data,
    };
  },
  computed: {
    filteredRealms() {
      if (this.query === "") return [];
      let result = Object.values(this.realms);
      let newRestult = result.filter(realm => {
        return realm.toLowerCase().includes(this.query.toLowerCase());
      });
      let firstTen = newRestult.slice(0, 10)
      return firstTen;
    },
  },
  methods: {
    submitRealm() {
      console.log("SubmitRealm was called")
      this.$emit("submitRealm", this.selectedRealm);
    },
  },
  components: {
    Combobox,
    ComboboxInput,
    ComboboxOptions,
    ComboboxOption,
  },
  props: {
    data: {
      required: true,
      type: Array as PropType<string[]>,
    },
  },
});
</script>
