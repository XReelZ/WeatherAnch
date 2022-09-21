import { Weather } from "../weather-model/weather.model";

export interface ICity {
    cityID: number;
    name: Date;
    postCode: number;
    forecast: Weather[];
  }
export class City implements ICity{
    cityID: number;
    name: Date;
    postCode: number;
    forecast: Weather[];

    constructor(
        cityID: number,
        name: Date,
        postCode: number,
        forecast: Weather[]
      ) {
        this.cityID = cityID;
        this.name = name;
        this.postCode = postCode;
        this.forecast = forecast;
      }
}

