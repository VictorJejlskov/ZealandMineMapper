const app = Vue.createApp({
    data(){
        return{
            objects: [],
            object: null,
            exampleObject: null,
            newObject: null,
            searchId : undefined,
            isEditing : false,
            isAddingNew: false,
            updateMessage: "",
            apiUrl: "https://anbo-restbookquerystring.azurewebsites.net/api/Books"
        }
    },
    methods: {
        getAllResults(){
            this.helperGetAndShow(this.apiUrl)
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
                const response = await axios.get(this.apiUrl)
                this.objects = await response.data
                this.newObject = this.objects[0]
                this.exampleObject = Object.assign({}, this.objects[0])
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
                const response = await axios.post(this.apiUrl, this.newObject)
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
            const url = `${this.apiUrl}/${id}`
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
            const url = `${this.apiUrl}/${id}`
            try
            {
                const response = await axios.delete(url)
                this.searchId = undefined
                this.helperGetAndShow(this.apiUrl)
            }
            catch (ex)
            {
                alert(ex.message)
            }
        },
        async putById(id){
            const url = `${this.apiUrl}/${id}`
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
        },
        clearUrl(){
            this.apiUrl = "";
        },

        sortBy(value, key, event){
            let button = event.target;
            button.sortingDirection = !button.sortingDirection
            if(!isNaN(parseInt(value))) 
            {
                if(button.sortingDirection)this.objects.sort((obj1, obj2) => obj1[key] - obj2[key])
                else this.objects.sort((obj1, obj2) => obj2[key] - obj1[key])
            }
            else if(value.toString().toLowerCase() === "true" || value.toString().toLowerCase() === "false")
            {
                if(button.sortingDirection)
                {
                    this.objects.sort((obj1, obj2) => obj1[key] === obj2[key] ? 0 : obj1[key]? -1 : 1)
                }
                else
                {
                    this.objects.sort((obj1, obj2) => obj1[key] === obj2[key] ? 0 : obj2[key]? -1 : 1)
                }
            }
            else
            {
                if(button.sortingDirection)this.objects.sort((obj1, obj2) => obj1[key].localeCompare(obj2[key]))
                else this.objects.sort((obj1, obj2) => obj2[key].localeCompare(obj1[key]))
            }
        },
        getTypeMessage(input){
            if (input == "number") return "Number"
            else if(input == "string") return "Text"
            else if(input == "boolean") return "True / False"
            return "Nothing"
        }
    },
    computed:{

    }
})