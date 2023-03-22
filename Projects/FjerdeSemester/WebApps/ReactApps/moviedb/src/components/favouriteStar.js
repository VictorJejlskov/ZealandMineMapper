import {
  useAddMovieMutation,
  useFetchFavouriteMoviesQuery,
  useRemoveMovieMutation,
} from "../store"
import { showSnackbar } from "./snackbar"

let movies = []
const MatchMovie = (movieObj, data) => {
  const favourites = data.map((movie) => {
    return movie.id
  })
  if (favourites.includes(movieObj.id)) return true
  return false
}
const FavouriteStar = ({ movieObj }) => {
  const [addMovie] = useAddMovieMutation()
  const [removeMovie] = useRemoveMovieMutation()
  const handleFavourite = (movie) => {
    if (MatchMovie(movieObj, movies)) {
      removeMovie(movie.id)
      showSnackbar(`Removed ${movieObj.title} from favourites`)
    } else {
      addMovie(movie)
      showSnackbar(`Added ${movieObj.title} to favourites`)
    }
  }
  const { data, error, isFetching } = useFetchFavouriteMoviesQuery()
  if (!error && !isFetching) movies = data
  return (
    <div>
      <span
        className={MatchMovie(movieObj, movies) ? "fas fa-star" : "far fa-star"}
        onClick={() => {
          handleFavourite(movieObj)
        }}></span>
      <span className="ml-1">{movieObj.vote_average}</span>
    </div>
  )
}
export default FavouriteStar
