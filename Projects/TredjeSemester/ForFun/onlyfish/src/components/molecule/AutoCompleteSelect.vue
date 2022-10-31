<template>
  <Combobox v-model="selectedRealm">
    <ComboboxInput @change="query = $event.target.value" />
    <ComboboxOptions>
      <ComboboxOption
        v-for="realm in filteredRealms"
        :key="realm"
        :value="realm">
        {{ realm }}
      </ComboboxOption>
    </ComboboxOptions>
  </Combobox>
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
      realms: this.data
    };
  },
  computed: {
    filteredRealms() {
      if (this.query === "") return this.realms;
      let result = Object.values(this.realms).filter((realm) => {
        realm.toLowerCase().includes(this.query.toLowerCase());
      });


      console.log(this.realms)
      console.log(this.query);
      console.log(result);
      console.log(Object.values(this.realms))
      console.log(this.realms.length)


      return result;
    },
  },
  methods: {
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
