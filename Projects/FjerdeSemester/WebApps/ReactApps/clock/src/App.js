import React, { Component } from "react"
import Message from "./Message"

class App extends Component {
  render() {
    return (
      <div className="App">
        <Message messagetext="Local time:" />
      </div>
    )
  }
}

export default App
