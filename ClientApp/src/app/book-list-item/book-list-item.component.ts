import { Component, Input, Output, EventEmitter } from '@angular/core';
import { empty } from 'rxjs';
import { Book } from '../book/book';
import { LibraryService } from '../library-service/library-service';

@Component({
  selector: 'book-list-item',
  templateUrl: './book-list-item.component.html',
})
export class BookListItemComponent {
  @Input() book: Book
  @Output() outBook: EventEmitter<any> = new EventEmitter();

  passBook() {
    this.outBook.emit(this.book);
  }
}
