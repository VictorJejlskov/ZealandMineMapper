let names = ["Henrik", "JAMshid", "AndERS", "EBBe", "pEr", "MicHAel", "PETEr"]

names.forEach((name, index, array) => {
  if (name.toLowerCase() === "henrik" || name.toLowerCase() === "per")
    name = name.toUpperCase()
  else name = name.toLowerCase()
  array[index] = name
})
console.log(names)

let cars = [
  { brand: "VW", model: "Passat", fuel: "diesel", owner_tax: 5550 },
  { brand: "VW", model: "Passat", fuel: "gasoline", owner_tax: 460 },
  { brand: "VW", model: "Passat", fuel: "hybrid", owner_tax: 150 },
  { brand: "BMW", model: "320i", fuel: "diesel", owner_tax: 4280 },
  { brand: "BMW", model: "320i", fuel: "gasoline", owner_tax: 430 },
  { brand: "BMW", model: "320i", fuel: "hybrid", owner_tax: 210 },
  { brand: "Tesla", model: "S", fuel: "electric", owner_tax: 0 },
]

var increaseOwnerTax = function (cars, fuel, taxPct) {
  cars.forEach((name, index, array) => {
    if (name.fuel === fuel) {
      name.owner_tax += taxPct
      array[index] = name
    }
  })
}

increaseOwnerTax(cars, "diesel", 50)
increaseOwnerTax(cars, "hybrid", 5)
console.log(cars)

let carModels = cars.map((car) => {
  return car.model
})

console.log(carModels)

let carBrands = cars.map((car) => {
  return { Mærke: car.brand }
})

console.log(carBrands)

let drivers = `[
    {
        "driverId": "grosjean",
        "permanentNumber": "8",
        "code": "GRO",
        "url": "http://en.wikipedia.org/wiki/Romain_Grosjean",
        "givenName": "Romain",
        "familyName": "Grosjean",
        "dateOfBirth": "1986-04-17",
        "nationality": "French"
        },
        {
        "driverId": "hamilton",
        "permanentNumber": "44",
        "code": "HAM",
        "url": "http://en.wikipedia.org/wiki/Lewis_Hamilton",
        "givenName": "Lewis",
        "familyName": "Hamilton",
        "dateOfBirth": "1985-01-07",
        "nationality": "British"
        },
        {
        "driverId": "hulkenberg",
        "permanentNumber": "27",
        "code": "HUL",
        "url": "http://en.wikipedia.org/wiki/Nico_H%C3%BClkenberg",
        "givenName": "Nico",
        "familyName": "Hülkenberg",
        "dateOfBirth": "1987-08-19",
        "nationality": "German"
        },
        {
        "driverId": "kevin_magnussen",
        "permanentNumber": "20",
        "code": "MAG",
        "url": "http://en.wikipedia.org/wiki/Kevin_Magnussen",
        "givenName": "Kevin",
        "familyName": "Magnussen",
        "dateOfBirth": "1992-10-05",
        "nationality": "Danish"
        }    
    ]`
let driverArray = JSON.parse(drivers)
let myDrivers = driverArray.map((driver) => {
  return {
    Kode: driver.code,
    Fornavn: driver.givenName,
    Efternavn: driver.familyName,
  }
})
console.log(myDrivers)

let cheapCars = cars.filter((car) => {
  if (car.owner_tax < 200 && car.fuel == "hybrid") return car
})
console.log(cheapCars)

var fuelCriterium = function (car, fuel) {
  if (car.fuel == fuel) return true
  return false
}

let gasolineCars = cars.filter((car) => fuelCriterium(car, "gasoline"))
console.log(gasolineCars)

let trips = [{ distance: 48 }, { distance: 12 }, { distance: 6 }]
var totalDistance = trips.reduce((sum, trip) => (sum += trip.distance), 0)

console.log(totalDistance)

let desk = [
  { type: "sitting" },
  { type: "standing" },
  { type: "sitting" },
  { type: "sitting" },
  { type: "standing" },
]
let deskTypes = desk.reduce(
  (acc, desk) => {
    if (desk.type == "sitting") acc.sitting++
    if (desk.type == "standing") acc.standing++
    return acc
  },
  { sitting: 0, standing: 0 }
)
console.log(deskTypes)

let numbers = [1, 1, 2, 3, 4, 4]
function unique(array) {
  return array.reduce((acc, num) => {
    if (!acc.find((item) => item === num)) acc.push(num)
    return acc
  }, [])
}
console.log(unique(numbers))

function balancedParens(string) {
  return !string.split("").reduce((acc, char) => {
    if (acc < 0) {
      return acc
    }
    if (char === "(") {
      return ++acc
    }
    if (char === ")") {
      return --acc
    }
    return acc
  }, 0)
}

console.log(balancedParens("()"))
console.log(balancedParens("()()"))
console.log(balancedParens("()(()"))
console.log(balancedParens("()(())))"))
console.log(balancedParens("))(("))
console.log(balancedParens("(())"))
console.log(balancedParens(""))

var personnel = [
  {
    id: 5,
    name: "Luke Skywalker",
    pilotingScore: 98,
    shootingScore: 56,
    isForceUser: true,
  },
  {
    id: 82,
    name: "Sabine Wren",
    pilotingScore: 73,
    shootingScore: 99,
    isForceUser: false,
  },
  {
    id: 22,
    name: "Zeb Orellios",
    pilotingScore: 20,
    shootingScore: 59,
    isForceUser: false,
  },
  {
    id: 15,
    name: "Ezra Bridger",
    pilotingScore: 43,
    shootingScore: 67,
    isForceUser: true,
  },
  {
    id: 11,
    name: "Caleb Dume",
    pilotingScore: 71,
    shootingScore: 85,
    isForceUser: true,
  },
]

let forceUsers = personnel.filter(person => person.isForceUser)
console.log("Force Users")
console.log(forceUsers)

let highForceUsers = forceUsers.filter(person => person.shootingScore > 60)
console.log("HighScores")
console.log(highForceUsers)


let shootingScores = highForceUsers.map(person => person.shootingScore)
console.log("Shooting Scores")
console.log(shootingScores)

let totalScore = shootingScores.reduce((acc, score) => {
    return acc + score
}, 0)

console.log(totalScore)


let resultEvery = personnel.every(person => person.pilotingScore >= 20)
console.log(resultEvery)

let resultSome = personnel.some(person => person.pilotingScore >= 80)
console.log(resultSome)