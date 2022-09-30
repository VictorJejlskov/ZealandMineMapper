const baseUrl = "https://anbo-restbookquerystring.azurewebsites.net/api/Books";
// const baseUrl = "http://localhost:5099/FootballPlayers";

const app = Vue.createApp({
    data(){
        return{
            objects: [],
            object: null,
            newObject: null,
            searchId : undefined,
            isEditing : false,
            isAddingNew: false,
            updateMessage: ""

        }
    },
    methods: {
        getAllResults(){
            this.helperGetAndShow(baseUrl)
            this.searchId = undefined;
        },
        selectObject(id){
            this.searchId = id;
            this.getById(this.searchId);
        },
        editObject(){
            this.isEditing = true;
        },
        async createNew(){
            try
            {
                const response = await axios.get(baseUrl)
                this.objects = await response.data
                this.newObject = this.objects[0];
                Object.keys(this.newObject).forEach(key => {
                    this.newObject[key] = null;
                });
                this.objects = []
                this.isAddingNew = true;
            }
            catch (ex)
            {
                alert(ex.message)
            }
        },
        async postObject(){
            try
            {
                Object.keys(this.newObject).forEach(key => {
                    if(!isNaN(parseInt(this.newObject[key]))) this.newObject[key] = parseInt(this.newObject[key])
                })
                const response = await axios.post(baseUrl, this.newObject)
                this.newObject = await response.data
                this.objects = []
                this.updateMessage = "response " + response.status + " " + response.statusText
                this.getAllResults();
                
            }
            catch (ex)
            {
                alert(ex.message)
            }
        },
        async getById(id){
            const url = baseUrl + "/" + id
            try
            {
                const response = await axios.get(url)
                this.object = await response.data
                this.objects = []
            }
            catch (ex)
            {
                alert(ex.message)
            }
            
        },
        async helperGetAndShow(url){
            try
            {
                const response = await axios.get(url)
                this.objects = await response.data
                this.object = null;
                this.isEditing = false;
                this.isAddingNew = false;
                this.newObject = null;
            }
            catch (ex)
            {
                alert(ex.message)
            }
        },
        async deleteById(id){
            const url = baseUrl + "/" + id
            try
            {
                const response = await axios.delete(url)
                this.searchId = undefined
                this.helperGetAndShow(baseUrl)
            }
            catch (ex)
            {
                alert(ex.message)
            }
        },
        async putById(id){
            const url = baseUrl + "/" + id
            try
            {
                const response = await axios.put(url, this.object)
                this.object = await response.data
                this.objects = []
                this.isEditing = false;
            }
            catch (ex)
            {
                alert(ex.message)
            }
        }
        

    }
})