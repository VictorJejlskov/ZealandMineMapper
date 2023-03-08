// import MovieImg from "../assets/movie_black2.jpg"
import MovieImg from "../assets/movie_black2-nobg.png"
const Home = () => {
  return (
    <div className="container">
      <span className="row jumbotron" style={{ padding: 20, fontSize: 100, fontFamily: "cursive" }}>
        <div className="m-auto">Moviefinder</div>
      </span>
      <span className="row">
        <img
          className="rounded movie_img m-auto"
          src={MovieImg}
          width="500"
          height="500"
          alt="..."
        />
      </span>

      <span className="row d-flex justify-content-between p-0">
        <div className="m-auto h4">
        This small App demonstrates React, Redux-Toolkit, RTK Query &
        React-Router
        </div>
      </span>
    </div>
  )
}
export default Home
