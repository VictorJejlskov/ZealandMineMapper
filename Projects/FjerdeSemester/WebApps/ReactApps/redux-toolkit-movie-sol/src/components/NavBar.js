import { Link } from "react-router-dom"
const NavBar = () => (
    <nav className="">
    <Link to="/">Home</Link>
    <Link to="/About">About</Link>
    <Link to="/Login">Login</Link>
    <Link to="/Admin">Admin</Link>
    <Link to="*">Home</Link>
  </nav>
)
export default NavBar