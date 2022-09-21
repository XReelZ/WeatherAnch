import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IWeather } from '../Models/weather-model/weather.model';

@Injectable({
  providedIn: 'root',
})
export class WeatherService {
  private getWeatherEndpoint = '../api/GetWeatherForecast';

  private httpOptions = {
    headers: new Headers({
      contentType: 'application/json',
    }),
  };

  constructor(private http: HttpClient) {}

  public getCurrentWeather(cityId: number): Observable<IWeather[]> {
    return this.http.get<IWeather[]>(
      `${this.getWeatherEndpoint}?cityId=${cityId}`
    );
  }
}
