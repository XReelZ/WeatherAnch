export interface IWeather {
  Date: Date;
  TemperatureC: number;
  TemperatureF: number;
  Summary: string;
}

export class Weather implements IWeather {
  ID: number;
  Date: Date;
  TemperatureC: number;
  TemperatureF: number;
  Summary: string;

  constructor(
    ID: number,
    Date: Date,
    TemperatureC: number,
    TemperatureF: number,
    Summary: string
  ) {
    this.ID = ID;
    this.Date = Date;
    this.TemperatureC = TemperatureC;
    this.TemperatureF = TemperatureF;
    this.Summary = Summary;
  }
}
