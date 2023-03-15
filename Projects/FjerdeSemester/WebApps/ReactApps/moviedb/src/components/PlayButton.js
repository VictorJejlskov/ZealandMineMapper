import { Link } from "react-router-dom"
const PlayButton = ({movieId}) => {
  const path = "/trailer/" + movieId
  return (
    <Link to={path}>
      <span className="far fa-play-circle"></span>
    </Link>
  )
}
export default PlayButton
