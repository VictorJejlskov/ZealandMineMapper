import { configureStore } from "@reduxjs/toolkit";
import { setupListeners } from "@reduxjs/toolkit/dist/query";
import { moviesApi } from "./apis/moviesApi";
import { searchReducer, changeSearchTerm } from "./slices/searchMovieSlice";

export const store = configureStore({
    reducer: {
        [moviesApi.reducerPath]: moviesApi.reducer,
        search: searchReducer
    },
    middleware: (getDefaultMiddleware) => {
        return getDefaultMiddleware()
        .concat(moviesApi.middleware)
    }
})

setupListeners(store.dispatch)

export { useFetchPopularMoviesQuery, useFetchHighestRatedMoviesQuery, useFetchSearchMovieQuery } from "./apis/moviesApi"
export { searchReducer, changeSearchTerm}