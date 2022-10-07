const counterButtonComponent = Vue.createApp({})

counterButtonComponent.component('button-counter', {
    data(){
        return{
            counter : 0,
        }
    },
    props: ["title"],
    template:
    /*html*/
    `
    <h4>Simpel knap</h4>
    <button @click="counter++" class="btn btn-primary">{{title}}</button>{{counter}}<br>
    `
})
counterButtonComponent.component('button-counter-with-input', {
    data(){
        return{
            counter : 0,
            incrementer: 0,
            canParse : false,
        }
    },
    props: ["title"],
    template:
    /*html*/
    `
    <h4>Knap med inputfield</h4>
    <input v-model.number="incrementer"> <- Hvor meget skal den gå op med<br>
    <button @click="counter+=incrementer" class="btn btn-primary" :disabled="parseAble">{{title}}</button>{{counter}}<br>
    `,
    computed:{
        parseAble(){
            if(!isNaN(parseInt(this.incrementer))) return false
            return true
        }
    }
})
