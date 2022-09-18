import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Weather } from '../Models/weather-model/weather.model';

@Injectable({
  providedIn: 'root',
})
export class WeatherService {

    private getWeatherEndpoint = '../api/GetWeatherForecast';



  private httpOptions = {
    headers: new Headers({
      'Content-Type': 'application/json',
    }),
  };

  constructor(private http: HttpClient) {}

  public getCurrentWeather(): Observable<Weather[]>{
    return this.http.get<Weather[]>(this.getWeatherEndpoint);
  };
}
