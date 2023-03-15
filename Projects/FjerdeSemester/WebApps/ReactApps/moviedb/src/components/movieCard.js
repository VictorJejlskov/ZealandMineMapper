import PlayButton from "./PlayButton"
import FavouriteStar from "./favouriteStar"


const MovieCard = ({ movie }) => {
  const posterBasePath = "https://image.tmdb.org/t/p/w185_and_h278_bestv2"
  return (
    <div className="col-lg-2 mb-4 d-flex align-items-stretch">
      <div className="card">
        <img
          src={posterBasePath + movie.poster_path}
          className="card-img-top"
          alt="..."
        />
        <div className="card-body">
          <h5 className="card-title ">
            <span>
              {movie.title.length > 20
                ? movie.title.substring(0, 20).concat("...")
                : movie.title}
            </span>
          </h5>
          <FavouriteStar movieObj={movie}/>
          <p className="card-text">
            {movie.overview.substring(0, 100).concat("....")}
          </p>
          <div className="d-flex justify-content-between p-0">
            <span className="far fa-calendar" aria-hidden="true">
              {" "}
              {movie.release_date}
            </span>
            <PlayButton movieId={movie.id}/>
          </div>
        </div>
      </div>
    </div>
  )
}

export default MovieCard
