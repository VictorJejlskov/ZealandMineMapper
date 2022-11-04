const url = "https://localhost:7193/api/duathletes"
// const url = "https://restduathlon20221104120104.azurewebsites.net/api/duathletes"
const app = Vue.createApp({
  data() {
    return {
        searchBip: undefined,
        athletes: [],
        newAthlete: {bip: 0, name: "", ageGroup: undefined, bike: undefined, run: undefined, total: 0},
        filterAgeValue: 1
    }
  },
  methods:{
    async getAthletes(){
        var response = await axios.get(url)
        this.athletes = response.data
    },
    async getByBip(){
        var response = await axios.get(url + "/" + this.searchBip)
        this.athletes = []
        this.athletes[0] = response.data
    },
    async deleteAthlete(bip){
        var response = await axios.delete(url + "/" + bip)
        var getResponse = await axios.get(url)
        this.athletes = getResponse.data
    },
    async addAthlete(){
        
        var response = await axios.post(url, this.newAthlete)
        console.log(response.status)
        var getResponse = await axios.get(url)
        
        this.athletes = getResponse.data
    },
    async filterByAgeGroup(){
        await this.getAthletes()
        this.athletes = this.athletes.filter(this.isInAgeGroup)
    },
    isInAgeGroup(obj){
        if(obj.ageGroup === this.filterAgeValue) return true;
    },
    sortByTotal(){
        let button = event.target;
        button.sortingDirection = !button.sortingDirection
        if(button.sortingDirection)this.athletes.sort((obj1, obj2) => obj1.total - obj2.total)
        else this.athletes.sort((obj1, obj2) => obj2.total - obj1.total)
    }
  }
})
