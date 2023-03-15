import { createApi, fetchBaseQuery } from "@reduxjs/toolkit/query/react"

const dbApi = createApi({
  reducerPath: "favourites",
  baseQuery: fetchBaseQuery({
    baseUrl: "http://localhost:3005",
  }),
  tagTypes: ["Favourites"],
  endpoints(builder) {
    return {
      addMovie: builder.mutation({
        invalidatesTags: ["Favourites"],
        query: (movie) => {
          return {
            url: "/favourites",
            method: "POST",
            body: movie,
          }
        },
      }),
      fetchFavouriteMovies: builder.query({
        providesTags: ["Favourites"],
        query: () => {
          return {
            url: "/favourites",
            method: "GET",
          }
        },
      }),
      removeMovie: builder.mutation({
        invalidatesTags: ["Favourites"],
        query: (movieId) => {
            return {
                url: `/favourites/${movieId}`,
                method: "DELETE"
            }
        }
      })
    }
  },
})
export const { useFetchFavouriteMoviesQuery, useAddMovieMutation, useRemoveMovieMutation } = dbApi
export { dbApi }
