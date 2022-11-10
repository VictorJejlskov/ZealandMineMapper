const url = "https://localhost:7182/api/MusicRecords"
const app = Vue.createApp({
  data() {
    return {
      test: "This is a test",
      searchId: 0,
      newRecord: {
        id: 0,
        recordName: "",
        artistName: "",
        duration: undefined,
        publicationYear: undefined,
      },
      records: [
        {
          id: 1,
          recordName: "The Next Episode",
          artistName: "Snoop doggy dog",
          duration: 161,
          publicationYear: 2001,
        },
        {
          id: 2,
          recordName: "Drop it like it's hot",
          artistName: "Snoop doggy dog",
          duration: 266,
          publicationYear: 2004,
        },
        {
          id: 3,
          recordName: "Happy",
          artistName: "Pharrell Williams",
          duration: 232,
          publicationYear: 2014,
        },
      ],
      searchRecordName: "",
      searchArtistName: "",
      searchYear: undefined,
      updateId: undefined,
      idToBeDeleted: undefined,
      updateValue: {
        id: 0,
        recordName: "",
        artistName: "",
        duration: undefined,
        publicationYear: undefined
      },
    }
  },
  async mounted() {
    const response = await axios.get(url)
    this.records = response.data
  },
  methods: {
    async getAll() {
      const response = await axios.get(url)
      this.records = response.data
    },
    async getById(id) {
      const newUrl = url + "/" + id
      const response = await axios.get(newUrl)
      this.records = response.data
    },
    async add() {
      const response = await axios.post(url, this.newRecord)
      this.newRecord.Id = response.data["id"]
      this.records.push(Object.assign({}, this.newRecord))
    },
    async getFiltered() {
      let searchString = ""
      if (this.searchRecordName) {
        if (!searchString)
          searchString += `?recordName=${this.searchRecordName}`
        else searchString += `&recordName=${this.searchRecordName}`
      }
      if (this.searchArtistName) {
        if (!searchString)
          searchString += `?artistName=${this.searchArtistName}`
        else searchString += `&artistName=${this.searchArtistName}`
      }
      if (this.searchYear && this.searchYear !== undefined) {
        if (!searchString) searchString += `?year=${this.searchYear}`
        else searchString += `&year=${this.searchYear}`
      }
      const response = await axios.get(url + searchString)
      this.records = response.data
    },
    async update() {
      const response = await axios.put(
        url + "/" + this.updateId,
        this.updateValue
      )
      this.getAll()
    },
    async deleteRecord() {
      const response = await axios.delete(url + "/" + this.idToBeDeleted)
      this.getAll()
    },
  },
})
