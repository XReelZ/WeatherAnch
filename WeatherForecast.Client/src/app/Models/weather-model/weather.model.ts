export interface IWeather {
  Date: Date;
  TemperatureC: number;
  TemperatureF: number;
  Summary: string;
}

export class Weather implements IWeather {
  Date: Date;
  TemperatureC: number;
  TemperatureF: number;
  Summary: string;

  constructor(
    Date: Date,
    TemperatureC: number,
    TemperatureF: number,
    Summary: string
  ) {
    this.Date = Date;
    this.TemperatureC = TemperatureC;
    this.TemperatureF = TemperatureF;
    this.Summary = Summary;
  }
}
