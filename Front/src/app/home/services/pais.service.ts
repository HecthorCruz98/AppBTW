import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Country } from '../interfaces/pais.interface';


@Injectable({
  providedIn: 'root'
})
export class PaisService {

  private apiUrl: string='https://restcountries.eu/rest/v2';

  get httpParams(){
    return new HttpParams()
    .set('fields','name;capital;alpha2Code;flag;population');
  }


  constructor( private http: HttpClient) { }

  buscarPais(termino: string): Observable<Country[]>
  {
    const url= `${this.apiUrl}/name/${termino}`;
    return this.http.get<Country[]>(url,{params:this.httpParams});
  }

  buscarCapital(termino: string): Observable<Country[]>
  {
    const url= `${this.apiUrl}/capital/${termino}`;
    return this.http.get<Country[]>(url,{params:this.httpParams});
  }

  buscarRegion(termino: string): Observable<Country[]>
  {
   

    const url= `${this.apiUrl}/region/${termino}?`;
    return this.http.get<Country[]>(url,{params:this.httpParams});
  }

  getPaisPorAlpha(termino: string): Observable<Country>
  {
    const url= `${this.apiUrl}/alpha/${termino}`;
    return this.http.get<Country>(url);
  }

  
}
