import { ICity } from "../city-model/city-model";

export interface IWeather {
  weatherID: number;
  date: Date;
  temperatureC: number;
  temperatureF: number;
  summary: string;
  cityId: string;
  city: ICity;
}

export class Weather implements IWeather {
  weatherID: number;
  date: Date;
  temperatureC: number;
  temperatureF: number;
  summary: string;
  cityId: string;
  city: ICity;

  constructor(
    weatherID: number,
    date: Date,
    temperatureC: number,
    temperatureF: number,
    summary: string,
    cityId: string,
    city: ICity) {
    this.weatherID = weatherID;
    this.date = date;
    this.temperatureC = temperatureC;
    this.temperatureF = temperatureF;
    this.summary = summary;
    this.cityId = cityId;
    this.city = city;
  }
}
