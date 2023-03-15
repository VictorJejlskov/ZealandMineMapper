import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react"

const apiKey = "8e522b94f81a2dabe7fb61299c3af277"
const moviesApi = createApi({
  reducerPath: "movies",
  baseQuery: fetchBaseQuery({
    baseUrl: "https://api.themoviedb.org/3/",
  }),
  endpoints(builder) {
    return {
      fetchPopularMovies: builder.query({
        query: () => {
          return {
            url: "discover/movie",
            params: {
              sort_by: "popularity.desc",
              api_key: apiKey,
            },
            method: "GET",
          }
        },
      }),
      fetchHighestRatedMovies: builder.query({
        query: () => {
          return {
            url: "movie/top_rated",
            params: {
              sort_by: "vote_average.desc",
              api_key: apiKey,
            },
            method: "GET",
          }
        },
      }),
      fetchSearchMovie: builder.query({
        query: (searchTerm) => {
          return {
            url: "search/movie",
            params: {
              api_key: apiKey,
              query: searchTerm,
            },
            method: "GET",
          }
        },
      }),
      fetchUpcomingMovies: builder.query({
        query: () => {
          return {
            url: "movie/upcoming",
            params: {
              api_key: apiKey,
            },
            method: "GET",
          }
        },
      }),
      fetchMovieTrailer: builder.query({
        query: (movieId) => {
          console.log("Fetch Movie Trailer: " + movieId)
          return {
            url: `movie/${movieId}/videos`,
            params: {
              api_key: apiKey,
              language: "en-US",
            },
            method: "GET",
          }
        },
      }),
    }
  },
})

export const {
  useFetchPopularMoviesQuery,
  useFetchHighestRatedMoviesQuery,
  useFetchSearchMovieQuery,
  useFetchUpcomingMoviesQuery,
  useFetchMovieTrailerQuery
} = moviesApi
export { moviesApi }
