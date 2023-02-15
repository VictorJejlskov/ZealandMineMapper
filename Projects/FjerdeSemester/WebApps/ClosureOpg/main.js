function buildFunctions() {
  let arr = []
  for (let i = 0; i < 100; i++) {
    arr.push(function () {
      console.log(i)
    })
  }
  return arr
}

var fs = buildFunctions()
fs[0]()
fs[1]()
fs[2]()
fs[8]()



function makeGreeting(language) {
  return function (firstname, lastname) {
    if (language === "en") {
      console.log("Hello " + firstname + " " + lastname)
    }
    if (language === "dk") {
      console.log("Hej " + firstname + " " + lastname)
    }
    if (language === "es") {
      console.log("Hola " + firstname + " " + lastname)
    }
  }
}

var greetEnglish = makeGreeting("en")
var greetDanish = makeGreeting("dk")
var greetSpanish = makeGreeting("es")

greetEnglish("John", "Doe")
greetDanish("Henrik", "Høltzer")
greetSpanish("Pablo", "Fuentes")

function makeAdder(x){
    return function (y){
        return x+y
    }
}
var add5 = makeAdder(5)
var add10 = makeAdder(10)
var addHello = makeAdder("Hello ")

console.log(add5(2)) // 7
console.log(add10(2)) // 12
console.log(addHello("Henrik")) // Hello Henrik

function tellMeWhenDone(callback) {
  // .... some work
  callback()
}

tellMeWhenDone(function () {
  console.log("Im' done!")
})
tellMeWhenDone(function () {
  console.log("All done!")
})
