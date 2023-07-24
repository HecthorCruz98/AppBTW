import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { THIS_EXPR } from '@angular/compiler/src/output/output_ast';
import { Injectable } from '@angular/core';
import { IAccpetTerms, terminosycondiciones } from './models/terminosycondiciones.interface';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { ConvertPdf, IConvertPdf } from './models/convertpdf.interface';
import { INotification } from './models/notification.interface';
import {SendFormService} from './pages/incapacidad/services/sendform.service'

const uriAccpetTerms = '/AccpetTerms';
//const uriAccpetTerms = environment.apiTerminosyCondiciones + '/AccpetTerms';



@Injectable({
  providedIn: 'root'
})

export class AccpetTermsService {

  acept: IAccpetTerms = { target: "" };

  constructor(private http: HttpClient) {
    this.load();
  }
  load() {

    return this.http.get<any>(uriAccpetTerms);

  }

  PostAcceptTerms(): Observable<terminosycondiciones> {
    return this.http.post<terminosycondiciones>(uriAccpetTerms, null,);
  }
}
