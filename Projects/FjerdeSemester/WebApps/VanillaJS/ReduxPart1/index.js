//Action Creators
const turnRed = () => ({type: "RED"})
const turnBlue = () => ({type: "BLUE"})
const turnGreen = () => ({type: "GREEN"})

//Reducer
const colorReducer = (color = "", action) => {
    if (action.type === "RED") { return color = "ui label massive red" }
    if (action.type === "BLUE") { return color = "ui label massive blue" }
    if (action.type === "GREEN") { return color = "ui label massive green" }
    return "ui label massive black"
}

//Store
const store = Redux.createStore(colorReducer)

//Update HTML
function render(){
    document.getElementById("result").className = store.getState().toString()
}


//Subscribe on changes
store.subscribe(render)