import { useFetchFavouriteMoviesQuery } from "../store"
import {useUser} from "./hooks/ProtectedRoute"
import MovieCard from "./movieCard"

const FavouriteMoviesList = () => {
  useUser()
  const { data, error, isFetching } = useFetchFavouriteMoviesQuery()
  let content
  if (isFetching) {
    content = <div>Loading</div>
  } else if (error) {
    content = <div>Error loading movies</div>
  } else {
    content = data.map((movie) => {
      return <MovieCard key={movie.id} movie={movie}></MovieCard>
    })
  }
  return <div className="row row-cols-3 row-cols-md-2 m-4">
    {content}
  </div>

}
export default FavouriteMoviesList
