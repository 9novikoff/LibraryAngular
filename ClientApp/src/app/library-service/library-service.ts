import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from '@angular/core';
import { Observable } from "rxjs";
import { AppModule } from "../app.module";
import { Book } from "../book/book";

@Injectable({ providedIn: 'root' })
export class LibraryService {
  baseUrl: string;

  constructor(private http: HttpClient, @Inject('BASE_URL') url: string) {
    this.baseUrl = url;
  }

  getAll() {
    return this.http.get<Book[]>(this.baseUrl + 'api/books');
  }

  getAllRecommended() {
    return this.http.get<Book[]>(this.baseUrl + 'api/recommended');
  }

  postBook(book: Book) {
    this.http.post<Book>(this.baseUrl + 'api/books/save', book)
  }
}
