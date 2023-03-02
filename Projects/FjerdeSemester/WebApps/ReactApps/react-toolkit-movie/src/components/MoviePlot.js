import React from "react";
import { useSelector } from "react-redux";
import { clickedMovie } from "./MovieSlice";

export function MoviePlot(){
    const movie = useSelector(clickedMovie)
    if(movie){
        return(
            <div className="moviePlot">
                <h3>Plot: </h3>
                <div>{movie.plot}</div>
            </div>
        )
    }
}