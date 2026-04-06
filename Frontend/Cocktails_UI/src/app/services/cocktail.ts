import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Drink } from '../models/drink';

@Injectable({
  providedIn: 'root',
})
export class CocktailService {
  private apiUrl = 'https://localhost:7134/api/Cocktail/GetCocktails';

  constructor(private http: HttpClient){}

  getRandomCocktail(): Observable<Drink[]>{
    return this.http.get<Drink[]>(this.apiUrl);
  }
}
