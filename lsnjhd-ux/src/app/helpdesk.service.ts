import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class HelpdeskService {
  _hdaUrl = 'http://localhost:58356/api/v1/hda/';

  constructor(private _http: Http) {}

  getOpenTickets() {
    return this._http
      .get(this._hdaUrl + 'tickets?status=open')
      .pipe(map((_response: Response) => _response.json()));
  }
}
