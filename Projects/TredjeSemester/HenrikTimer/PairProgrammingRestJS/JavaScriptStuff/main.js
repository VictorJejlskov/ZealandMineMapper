const url = 'https://localhost:7182/api/MusicRecords'
const app = Vue.createApp({
  data() {
    return {
      test: "This is a test",
      searchId: 0,
      newRecord:{
        Id: 0,
        RecordName: "",
        ArtistName: "",
      },
      records: [
        {
          Id: 1,
          RecordName: "Smoke weed everyday",
          ArtistName: "Snoop doggy dog",
        },
        {
          Id: 2,
          RecordName: "Drop it like it's hot",
          ArtistName: "Snoop doggy dog",
        },
        {
          Id: 3,
          RecordName: "Happy",
          ArtistName: "Pharrell Williams",
        },
      ],
    }
  },
  methods:{
    async getAll(){
        const response = await axios.get(url)
        this.records = response.data
    },
    async getById(id){
        const newUrl = url + "/" + id
        const response = await axios.get(newUrl)
        this.records = response.data
    },
    async add(){
        const response = await axios.post(url, this.newRecord)
        this.newRecord.Id = response.data["id"]
        this.records.push(Object.assign({}, this.newRecord))
    }
  }

})
