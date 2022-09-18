import { Weather } from "../weather-model/weather.model";

export interface ICity {
    CityID: number;
    Name: Date;
    PostCode: number;
    Forecast: Weather[];
  }
export class City implements ICity{
    CityID: number;
    Name: Date;
    PostCode: number;
    Forecast: Weather[];

    constructor(
        CityID: number,
        Name: Date,
        PostCode: number,
        Forecast: Weather[]
      ) {
        this.CityID = CityID;
        this.Name = Name;
        this.PostCode = PostCode;
        this.Forecast = Forecast;
      }
}

