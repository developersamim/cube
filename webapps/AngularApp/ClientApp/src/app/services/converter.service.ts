import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ConverterService {
  apiEndpoint: string;
  readonly controllerUrl = 'converters/';
  readonly centigradeToFahrenheitAction = 'centigradetofahrenheit/';
  readonly centigradeToKelvinAction = 'centigradetokelvin/';
  readonly fahrenheitToCentigradeAction = 'fahrenheittoCentigrade/';
  readonly fahrenheitToKelvinAction = 'fahrenheittokelvin/';
  readonly kelvinToCentigradeAction = 'kelvintocentigrade/';
  readonly kelvinToFahrenheitAction = 'kelvintofahrenheit/';

  constructor(
    private httpClient: HttpClient
  ) {
    this.apiEndpoint = environment.apiEndpoint;
  }

  centigradeToFahrenheit = (request: number) => {
    return this.httpClient.get(this.apiEndpoint + this.controllerUrl + this.centigradeToFahrenheitAction + request);
  }

  centigradeToKelvin = (request: number) => {
    return this.httpClient.get(this.apiEndpoint + this.controllerUrl + this.centigradeToKelvinAction + request);
  }

  fahrenheitToCentigrade = (request: number) => {
    return this.httpClient.get(this.apiEndpoint + this.controllerUrl + this.fahrenheitToCentigradeAction + request);
  }

  fahrenheitToKelvin = (request: number) => {
    return this.httpClient.get(this.apiEndpoint + this.controllerUrl + this.fahrenheitToKelvinAction + request);
  }

  kelvinToCentigrade = (request: number) => {
    return this.httpClient.get(this.apiEndpoint + this.controllerUrl + this.kelvinToCentigradeAction + request);
  }

  kelvinToFahrenheit = (request: number) => {
    return this.httpClient.get(this.apiEndpoint + this.controllerUrl + this.kelvinToFahrenheitAction + request);
  }
}
