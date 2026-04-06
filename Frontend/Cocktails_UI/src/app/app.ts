import { Component, signal, ViewChild } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { Cocktail } from './components/cocktail/cocktail';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Cocktail, HttpClientModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  @ViewChild(Cocktail) cocktailComponent!: Cocktail;

  onSearchClick() {
    document.querySelector('.cocktail-explorer')?.scrollIntoView({ behavior: 'smooth' });
  }

  onSurpriseClick() {
    this.cocktailComponent?.getCocktail();
    document.querySelector('.cocktail-explorer')?.scrollIntoView({ behavior: 'smooth' });
  }
}
