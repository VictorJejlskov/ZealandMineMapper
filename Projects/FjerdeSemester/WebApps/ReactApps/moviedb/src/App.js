import PopularMoviesList from "./components/popularMovieList"
import HighestRatedMoviesList from "./components/highestRatedMoviesList"
import Home from "./components/home"
import { Route, Routes, Link } from "react-router-dom"
import SearchMovie from "./components/searchMovie"
import SearchedMoviesList from "./components/searchedMoviesList"
import UpcomingMoviesList from "./components/upcomingMoviesList"
import MovieTrailer from "./components/movieTrailer"
import FavouriteMoviesList from "./components/favouriteMoviesList"
import { ToastContainer } from "react-toastify"
import 'react-toastify/dist/ReactToastify.css';
function App() {
  return (
    <div>
      <div className="jumbotron pb-3 pt-3">
        <div className="">
          <nav className="navbar navbar-expand-lg">
            <div className="navbar-brand" href="#">
              Moviefinder
            </div>
            <Link to="/" className="nav-link">
              Home
            </Link>
            <Link to="/popular" className="nav-link">
              Popular
            </Link>
            <Link to="/highest-rated" className="nav-link">
              Highest Rated
            </Link>
            <Link to="/upcoming" className="nav-link">
              Upcoming
            </Link>
            <Link to="/favourites" className="nav-link">
              Favourites
            </Link>
            <div className="" style={{ position: "absolute", right: 40 }}>
              <SearchMovie />
            </div>
          </nav>
        </div>
        <ToastContainer/>
      </div>
      <Routes>
        <Route path="/" element={<Home />} />
        <Route path="/popular" element={<PopularMoviesList />} />
        <Route path="/highest-rated" element={<HighestRatedMoviesList />} />
        <Route path="/searched-movie" element={<SearchedMoviesList />} />
        <Route path="/upcoming" element={<UpcomingMoviesList />} />
        <Route path="/favourites" element={<FavouriteMoviesList />} />
        <Route path="/trailer/:id" element={<MovieTrailer />} />
      </Routes>
    </div>
  )
}
export default App
