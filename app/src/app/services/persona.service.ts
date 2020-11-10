import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import {Persona} from '../models/persona.model';

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
    return this.http.get<Persona[]>(this.url, {headers:header});

  }

  onDeletePersona(id:number):Observable<number>{
    let header=new HttpHeaders().set('Content-Type','application/json');
    return this.http.delete<number>(this.url + "/" + id, {headers:header});
  }

  onCreatePersona(persona:Persona):Observable<Persona>{
    let header=new HttpHeaders().set('Content-Type','application/json');
    return this.http.post<Persona>(this.url, persona, {headers:header});
  }
  onUpdatePersona (persona:Persona): Observable<Persona>{
    let header=new HttpHeaders().set('Content-Type','application/json');
    return this.http.put<Persona>(this.url, persona, {headers:header});
  }
}
