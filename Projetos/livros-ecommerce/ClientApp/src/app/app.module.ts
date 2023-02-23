import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { HeaderComponent } from './components/shared/header/header.component';
import { FooterComponent } from './components/shared/footer/footer.component';
import { NavComponent } from './components/shared/nav/nav.component';
import { LivrosEcommerceComponent } from './components/livros-ecommerce/livros-ecommerce.component';
import { FiltersComponent } from './components/livros-ecommerce/filters/filters.component';
import { ProductListComponent } from './components/livros-ecommerce/product-list/product-list.component';
import { MaterialModule } from './components/material.module';
import { ProductItemComponent } from './components/livros-ecommerce/product-list/product-item/product-item.component';
import { BookService } from './components/livros-ecommerce/product-list/product-list.service';
import { AppRoutingModule } from './app-routing.module';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    NavComponent,
    LivrosEcommerceComponent,
    FiltersComponent,
    ProductListComponent,
    ProductItemComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    MaterialModule,
    AppRoutingModule
  ],
  providers: [BookService],
  bootstrap: [AppComponent]
})
export class AppModule { }
