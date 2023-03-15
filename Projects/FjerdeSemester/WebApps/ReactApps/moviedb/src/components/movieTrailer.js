import { useParams } from "react-router-dom"
import { useFetchMovieTrailerQuery } from "../store"
import YoutubeEmbed from "./YoutubeEmbed"

const MovieTrailer = () => {
  const id = useParams().id
  const { data, error, isFetching } = useFetchMovieTrailerQuery(id)

  let content
  if (isFetching) {
    content = <div>Loading</div>
  } else if (error) {
    content = <div>Error loading movies</div>
  } else {
    if (data.results.length) {
      const trailerToShow = data.results.filter((movie) => {
        return movie.name.toLowerCase().includes("trailer")
      })
      if (trailerToShow.length) {
        content = (
          <>
            <h1 className="text-center">{trailerToShow[trailerToShow.length-1].name}</h1>
            <div className="embed-responsive embed-responsive-16by9">
              <YoutubeEmbed embedId={trailerToShow[trailerToShow.length-1].key} />
            </div>
          </>
        )
      }
      else{
        content = (
            <>
              <h1 className="text-center">{data.results[0].name}</h1>
              <div className="embed-responsive embed-responsive-16by9">
                <YoutubeEmbed embedId={data.results[0].key} />
              </div>
            </>
          )
      }
    } else {
      content = <>No Trailers found</>
    }
  }
  return <div className="container">{content}</div>
}
export default MovieTrailer
