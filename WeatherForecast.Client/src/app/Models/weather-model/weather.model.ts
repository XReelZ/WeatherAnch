import { ICity } from "../city-model/city-model";

export interface IWeather {
  weatherID: number;
  date: Date;
  temperatureMin: number;
  temperatureMax: number;
  rainChancePerc: string;
  cityId: string;
  city: ICity;
}

export class Weather implements IWeather {
  weatherID: number;
  date: Date;
  temperatureMin: number;
  temperatureMax: number;
  rainChancePerc: string;
  cityId: string;
  city: ICity;

  constructor(
    weatherID: number,
    date: Date,
    temperatureMin: number,
    temperatureMax: number,
    rainChancePerc: string,
    cityId: string,
    city: ICity) {
    this.weatherID = weatherID;
    this.date = date;
    this.temperatureMin = temperatureMin;
    this.temperatureMax = temperatureMax;
    this.rainChancePerc = rainChancePerc;
    this.cityId = cityId;
    this.city = city;
  }
}
