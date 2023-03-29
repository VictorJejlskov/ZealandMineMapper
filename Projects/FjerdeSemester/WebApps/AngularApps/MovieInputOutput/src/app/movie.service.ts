import { Injectable } from '@angular/core';
import { Movie } from './Shared/Movie';
import { MOCK_MOVIES } from './Shared/MockMovies';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  public getMovies(): Movie[] { return MOCK_MOVIES; }
}




