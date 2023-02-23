import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { BookService } from './product-list.service';
import { Book } from './model/Book';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
  
  livros: Book[] = [];

  constructor(private bookService: BookService) {}
  
  ngOnInit(): void {
    
    this.bookService.getBook().subscribe((data: Book[]) => {
      this.livros = data;
      console.log(this.livros);
    });
  }
}
