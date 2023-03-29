import { Component, OnInit } from '@angular/core';
import { Movie } from '../Shared/Movie';
import { MovieService } from '../movie.service';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {
  movies : Movie[];
  //private selectedMovie : Movie|undefined;


  constructor(public movieService : MovieService) {
    this.movies=this.movieService.getMovies();
  }

  ngOnInit() { }

  //public onSelect(movie : Movie){ this.selectedMovie = movie; }

}
