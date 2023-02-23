import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { Observable, throwError } from 'rxjs';
import { catchError, map, retry } from 'rxjs/operators';
import { Book } from "./model/Book";

// export const books: Book[] = [
//     { Id: 1, Nome: 'Book1' , Preco: 10, Quantidade: 1, Categoria: "Acao", Img:"img1"},
//     { Id: 2, Nome: 'Book2' , Preco: 10, Quantidade: 1, Categoria: "Acao", Img:"img2"},
//     { Id: 3, Nome: 'Book3' , Preco: 10, Quantidade: 1, Categoria: "Acao", Img:"img3"},

// ];

@Injectable({
    providedIn: 'root'
})

export class BookService {

    private url = environment.apiUrl;

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    }

    constructor(private http: HttpClient) { }
    
    // getBook() {
    //     return this.http.get(this.url)
    // }

    getBook(): Observable<Book[]> {
        return this.http.get<Book[]>(this.url)
          .pipe(
            retry(1)
          );
    }
 }