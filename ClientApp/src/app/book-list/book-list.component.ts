import { Component } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from '../book/book';
import { LibraryService } from '../library-service/library-service';

@Component({
  selector: 'book-list',
  templateUrl: './book-list.component.html',
  providers: [LibraryService]
})
export class BookListComponent {
  public books: Book[];
  public formBook : Book;
  constructor(private libraryService: LibraryService) {
    this.getAll();
  }

  public getAll() {
    this.libraryService.getAll().subscribe(result => this.books = result);
  }

  public getAllRecommended() {
    this.libraryService.getAllRecommended().subscribe(result => this.books = result);
  }

  public CheckAll(event : Event) {
    this.getAll();
  }

  public CheckRecommended(event: Event) {
    this.getAllRecommended();
  }

  public getBook(book: Book) {
    this.formBook = book;
  }

}
