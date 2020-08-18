import { Component } from "@angular/core";
import { Http } from "@angular/http";
import { WeatherService } from "./weather.service";
import { WeatherModelByCity } from "./WeatherModelByCity";

@Component({
  selector: 'weather',
  templateUrl: './weather.component.html'
})

export class WeatherComponent {
  private weatherDetails: WeatherModelByCity[];
 // private cityList: string;
  private weatherUrl: string;
    constructor( private weatherService : WeatherService) {
  }

  getWeatherByCityName(chosenCity : string) {
    this.weatherUrl = "/api/Weather/Get/city=";
    
    this.weatherService.getWeather(chosenCity, this.weatherUrl).subscribe((weather: WeatherModelByCity[]) => {
      this.weatherDetails = weather;
      console.log(this.weatherDetails);
    })
  }

  }
