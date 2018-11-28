import { HelpdeskService } from './helpdesk.service';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HomeComponent } from './home/home.component';
import { TicketsComponent } from './tickets/tickets.component';
import { ReportsComponent } from './reports/reports.component';
import { ConfigComponent } from './config/config.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    HomeComponent,
    TicketsComponent,
    ReportsComponent,
    ConfigComponent
  ],
  imports: [BrowserModule, AppRoutingModule],
  providers: [HelpdeskService],
  bootstrap: [AppComponent]
})
export class AppModule {}
