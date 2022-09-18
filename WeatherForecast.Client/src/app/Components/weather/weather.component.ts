import { Component, OnInit } from '@angular/core';
import { Weather } from 'src/app/Models/weather-model/weather.model';
import { WeatherService } from 'src/app/Services/weather-service.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.scss']
})
export class WeatherComponent implements OnInit{
  public weatherList!: Weather[];
  constructor(private weatherService: WeatherService) { 
  
  }

  ngOnInit(): void {
    this.weatherService.getCurrentWeather().subscribe(
      responce => {
        this.weatherList = responce;
        console.log(this.weatherList);
      }
    );
  }
}
