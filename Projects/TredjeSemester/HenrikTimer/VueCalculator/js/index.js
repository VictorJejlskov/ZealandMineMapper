const app = Vue.createApp({
    data(){
        return{
            result: '',
            number1: '',
            number2: '',
            operation: '+'
        }
    },
    methods:{
        calculate(){
            console.log("Chosen operator: " + this.operation)
            switch(this.operation){
                case "*": 
                    this.result = this.number1 * this.number2
                break;
                case "+":
                    this.result = this.number1 + this.number2
                break;
                case "-":
                    this.result = this.number1 - this.number2
                break;
                case "/":
                    this.result = this.number1 / this.number2
                break;
            }

        }
    }
})