import PopularMoviesList from "./components/popularMovieList"
import HighestRatedMoviesList from "./components/highestRatedMoviesList"
import Home from "./components/home"
import { Route, Routes, Link } from "react-router-dom"
import SearchMovie from "./components/searchMovie"
import SearchedMoviesList from "./components/searchedMoviesList"
function App() {
  return (
    <div>
      <div className="jumbotron pb-3 pt-3">
        <div className="navbar navbar-expand-lg" style={{paddingLeft: 0}}>
          <nav className="nav navbar-nav">
            <Link to="/" className="nav-item nav-link">
              Home
            </Link>
            <Link to="/popular" className="nav-item nav-link">
              Popular
            </Link>
            <Link to="/highest-rated" className="nav-item nav-link">
              Highest Rated
            </Link>
            <SearchMovie/>
          </nav>
        </div>
      </div>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/popular" element={<PopularMoviesList />} />
        <Route path="/highest-rated" element={<HighestRatedMoviesList />} />
        <Route path="/searched-movie" element={<SearchedMoviesList />} />
      </Routes>
    </div>
  )
}
export default App
