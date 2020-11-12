import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Persona} from '../models/persona.model';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {
  url="https://localhost:44300/api/persona";
  list : Persona[];
 

  constructor( private http:HttpClient) { 
    console.log("Persona service is running");
  }

  getPersonas(): Observable<Persona[]>{
    let header=new HttpHeaders().set('Content-Type','application/json');
    return this.http.get<Persona[]>(this.url);

  }

  onDeletePersona(id:number):Observable<number>{
    let header=new HttpHeaders().set('Content-Type','application/json');
    return this.http.delete<number>(this.url + "/" + id);
  }

  onCreatePersona(persona:Persona):Observable<Persona>{
    let header=new HttpHeaders().set('Content-Type','application/json');
    return this.http.post<Persona>(this.url, persona);
  }

  onUpdatePersona (persona:Persona): Observable<Persona>{
    let header=new HttpHeaders().set('Content-Type','application/json');
    return this.http.put<Persona>(this.url, persona);
  }
  
}
