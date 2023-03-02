import { Route, Routes } from "react-router-dom"
import HomePage from "./HomePage"
import About from "./About"
import UnderConstruction from "./UnderConstruction"
import NavBar from "./NavBar"

const App = () => (
  <>
  <NavBar/>
    <Routes>
      <Route path="/" element={<HomePage />} />
      <Route path="/About" element={<About />} />
      <Route path="/Login" element={<UnderConstruction />} />
      <Route path="/Admin" element={<UnderConstruction />} />
      <Route path="/MovieDetails" element={<HomePage />} />
      <Route path="*" element={<HomePage />} />
    </Routes>
  </>
)
export default App
