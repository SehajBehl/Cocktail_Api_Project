import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Drink } from '../../models/drink';
import { CocktailService } from '../../services/cocktail';

@Component({
  selector: 'app-cocktail',
  imports: [CommonModule],
  templateUrl: './cocktail.html',
  styleUrl: './cocktail.css',
})
export class Cocktail {
  cocktail: Drink | null = null;
  loading = false;
  errorMessage = '';

  constructor(private cocktailService: CocktailService) {}

  getCocktail(): void {
    this.loading = true;
    this.errorMessage = '';

    this.cocktailService.getRandomCocktail().subscribe({
      next: (data) => {
        this.cocktail = data[0];
        this.loading = false;
      },
      error: (error) => {
        console.error(error);
        this.errorMessage = 'Failed to load cocktail.';
        this.loading = false;
      }
    });
  }
}
