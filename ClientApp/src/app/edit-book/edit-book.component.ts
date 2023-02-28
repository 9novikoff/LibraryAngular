import { Component, Input, SimpleChanges } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Book } from '../book/book';
import { LibraryService } from '../library-service/library-service';


@Component({
  selector: 'edit-book',
  templateUrl: './edit-book.component.html',
})
export class EditBookComponent {
  @Input() book: Book;
  bookForm: FormGroup;

  constructor(private libraryService: LibraryService) {
  }

  ngOnInit() {
    this.buildForm();
  }

  buildForm() {
    this.bookForm = new FormGroup({
      title: new FormControl(''),
      cover: new FormControl(''),
      author: new FormControl(''),
      genre: new FormControl(''),
      content: new FormControl(''),
    });
  }

  ngOnChanges(changes: SimpleChanges) {
    if (this.book !== undefined && this.bookForm !== undefined) {
      this.bookForm.get('title').setValue(this.book.title);
      this.bookForm.get('cover').setValue(this.book.cover);
      this.bookForm.get('author').setValue(this.book.author);
      this.bookForm.get('genre').setValue(this.book.genre);
      this.bookForm.get('content').setValue(this.book.content);
    }
  }

  public getFormBook() {
    if (this.book !== undefined) {
      this.libraryService.postBook(this.book);
      this.clearFormBook();
    }
  }

  public clearFormBook() {
    this.bookForm.get('title').setValue("");
    this.bookForm.get('cover').setValue("");
    this.bookForm.get('author').setValue("");
    this.bookForm.get('genre').setValue("");
    this.bookForm.get('content').setValue("");
  }
}
