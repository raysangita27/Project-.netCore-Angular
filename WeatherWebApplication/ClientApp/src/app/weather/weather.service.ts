import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { WeatherModelByCity } from './WeatherModelByCity';
import 'rxjs/add/operator/map';


@Injectable()

export class WeatherService{
  //private weatherUrl = "/api/Weather/Get/city=";
  constructor(public http: HttpClient) {

  }
  getWeather(chosenCity: string, weatherUrl: string): Observable<WeatherModelByCity[]>{
    const urlWithParam = weatherUrl + chosenCity;
    return this.http.get<WeatherModelByCity[]>(urlWithParam);
  }

}
