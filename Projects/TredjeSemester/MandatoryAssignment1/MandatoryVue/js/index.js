const app = Vue.createApp({
    data(){
        return{
            inputWord: "",
            times: undefined,
            result: ""
        }
    },
    methods:{
        repeatWords(){
            this.result = ''
            if(this.times <= 0) alert("Times has to be a positive number")
            else{
                for(i = 0; i < this.times; i++){
                    this.result += this.inputWord
                }
                this.inputWord = '',
                this.times = undefined
            }
        }
    }
})