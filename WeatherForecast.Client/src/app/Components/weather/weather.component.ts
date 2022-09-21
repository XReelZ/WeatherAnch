import { Component, OnInit } from '@angular/core';
import { IWeather } from 'src/app/Models/weather-model/weather.model';
import { WeatherService } from 'src/app/Services/weather-service.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.scss'],
})
export class WeatherComponent implements OnInit {
  public weatherList: IWeather[];
  constructor(private weatherService: WeatherService) {
    this.weatherList = [];
  }

  ngOnInit(): void {
    this.weatherService.getCurrentWeather(1).subscribe((responce) => {
      this.weatherList = responce;
    });
  }
}
