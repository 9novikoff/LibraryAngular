import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Book } from '../book/book';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public books: Book[] = [];
  public url: number;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Book[]>(baseUrl + 'api/books').subscribe(result => {
      this.books = result;
    }, error => console.error(error));
    this.url = this.books.length;
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
