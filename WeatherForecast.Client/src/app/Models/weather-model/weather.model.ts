export interface IWeather {
  WeatherID: number;
  Date: Date;
  TemperatureC: number;
  TemperatureF: number;
  Summary: string;
}

export class Weather implements IWeather {
  WeatherID: number;
  Date: Date;
  TemperatureC: number;
  TemperatureF: number;
  Summary: string;

  constructor(
    WeatherID: number,
    Date: Date,
    TemperatureC: number,
    TemperatureF: number,
    Summary: string
  ) {
    this.WeatherID = WeatherID;
    this.Date = Date;
    this.TemperatureC = TemperatureC;
    this.TemperatureF = TemperatureF;
    this.Summary = Summary;
  }
}
