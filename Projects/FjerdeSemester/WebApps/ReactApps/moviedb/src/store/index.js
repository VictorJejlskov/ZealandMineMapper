import { configureStore } from "@reduxjs/toolkit"
import { setupListeners } from "@reduxjs/toolkit/dist/query"
import { dbApi } from "./apis/dbApi"
import { moviesApi } from "./apis/moviesApi"
import { searchReducer, changeSearchTerm } from "./slices/searchMovieSlice"

export const store = configureStore({
  reducer: {
    [moviesApi.reducerPath]: moviesApi.reducer,
    [dbApi.reducerPath]: dbApi.reducer,
    search: searchReducer,
  },
  middleware: (getDefaultMiddleware) => {
    return getDefaultMiddleware()
      .concat(moviesApi.middleware)
      .concat(dbApi.middleware)
  },
})

setupListeners(store.dispatch)

export {
  useFetchPopularMoviesQuery,
  useFetchHighestRatedMoviesQuery,
  useFetchSearchMovieQuery,
  useFetchUpcomingMoviesQuery,
  useFetchMovieTrailerQuery,
} from "./apis/moviesApi"
export { useAddMovieMutation, useFetchFavouriteMoviesQuery, useRemoveMovieMutation } from "./apis/dbApi"
export { searchReducer, changeSearchTerm }
