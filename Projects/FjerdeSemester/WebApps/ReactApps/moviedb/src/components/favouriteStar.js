import {
  useAddMovieMutation,
  useFetchFavouriteMoviesQuery,
  useRemoveMovieMutation,
} from "../store"

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
    addMovie(movie)
  }
  const removeFavourite = (movie) => {
    removeMovie(movie.id)
  }
  const { data, error, isFetching } = useFetchFavouriteMoviesQuery()
  let content
  if (isFetching) {
    content = <div>Loading</div>
  } else if (error) {
    content = <div>Error loading movies</div>
  } else {
    if (MatchMovie(movieObj, data)) {
      content = (
        <>
          <span
            className="fas fa-star"
            onClick={() => {
              removeFavourite(movieObj)
            }}></span>
          <span className="ml-1">{movieObj.vote_average}</span>
        </>
      )
    } else {
      content = (
        <>
          <span
            className="far fa-star"
            onClick={() => {
              handleFavourite(movieObj)
            }}></span>
          <span className="ml-1">{movieObj.vote_average}</span>
        </>
      )
    }
  }
  return <div>{content}</div>
}
export default FavouriteStar
