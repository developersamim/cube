import { Component, OnInit } from '@angular/core';
import { ControlValueAccessor, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ConverterService } from 'src/app/services/converter.service';

@Component({
  selector: 'app-converter',
  templateUrl: './converter.component.html',
  styleUrls: ['./converter.component.scss']
})
export class ConverterComponent implements OnInit {
  converterForm: FormGroup;
  options: string[];
  selectedTo: string;
  selectedFrom: string;
  error: string = '';

  readonly centigrade = 'Celsius';
  readonly fahrenheit = 'Fahrenheit';
  readonly kelvin = 'Kelvin';

  constructor(
    private fb: FormBuilder,
    private converterService: ConverterService
  ) {
    this.converterForm = this.fb.group({
      from: new FormControl('', [Validators.required]),
      to: new FormControl('', [Validators.required]),
      request: new FormControl('', [Validators.required]),
      result: new FormControl({value: '', disabled: true})
    })

    this.options = this.getOptions();
    this.selectedFrom = this.options[0];
    this.selectedTo = this.options[2];
    this.converterForm.controls['from'].setValue(this.selectedFrom);
    this.converterForm.controls['to'].setValue(this.selectedTo);
  }

  getOptions() {
    return [
      this.centigrade,
      this.fahrenheit,
      this.kelvin,
    ]
  }

  ngOnInit() {

  }

  onSubmit(){
    var request = this.converterForm.get('request')?.value;

    if(this.selectedFrom == this.centigrade && this.selectedTo == this.fahrenheit){
      this.converterService.centigradeToFahrenheit(request).subscribe(
        (response) => {
          this.setResult(response);
        },
        error => {
          console.log(error.error);
          this.error = error.error.slice(38, 120);
        }
      )
    }
    else if(this.selectedFrom == this.centigrade && this.selectedTo == this.kelvin){
      this.converterService.centigradeToKelvin(request).subscribe(
        (response) => {
          this.setResult(response);
        },
        error => {
          console.log(error.error);
          this.error = error.error.slice(38, 120);
        }
      )
    }
    else if(this.selectedFrom == this.fahrenheit && this.selectedTo == this.centigrade){
      this.converterService.fahrenheitToCentigrade(request).subscribe(
        (response) => {
          this.setResult(response);
        },
        error => {
          console.log(error.error);
          this.error = error.error.slice(38, 120);
        }
      )
    }
    else if(this.selectedFrom == this.fahrenheit && this.selectedTo == this.kelvin){
      this.converterService.fahrenheitToKelvin(request).subscribe(
        (response) => {
          this.setResult(response);
        },
        error => {
          console.log(error.error);
          this.error = error.error.slice(38, 120);
        }
      )
    }
    else if(this.selectedFrom == this.kelvin && this.selectedTo == this.centigrade){
      this.converterService.kelvinToCentigrade(request).subscribe(
        (response) => {
          this.setResult(response);
        },
        error => {
          console.log(error.error);
          this.error = error.error.slice(38, 120);
        }
      )
    }
    else if(this.selectedFrom == this.kelvin && this.selectedTo == this.fahrenheit){
      this.converterService.kelvinToFahrenheit(request).subscribe(
        (response) => {
          this.setResult(response);
        },
        error => {
          console.log(error.error);
          this.error = error.error.slice(38, 120);
        }
      )
    }
    else {
      this.error = "unsupported request";
      console.log('unsupported type');
    }
  }

  onFromChange()
  {
    this.selectedFrom = this.converterForm.get('from')?.value;
    this.resetRequestAndResult();

    if(this.selectedFrom == this.selectedTo){
      this.options.forEach(element => {
        if(element != this.selectedTo){
          this.converterForm.controls['to'].setValue(element);
          this.selectedTo = element;
        }
      });
    }
  }

  onToChange()
  {
    this.selectedTo = this.converterForm.get('to')?.value;
    this.resetResult();

    if(this.selectedFrom == this.selectedTo){
      this.options.forEach(element => {
        if(element != this.selectedFrom){
          this.converterForm.controls['from'].setValue(element);
          this.selectedFrom = element;
        }
      });
    }
  }

  resetRequestAndResult()
  {
    this.converterForm.controls['request'].setValue('');
    this.converterForm.controls['result'].setValue('');
    this.error = '';
  }

  resetResult(){
    this.converterForm.controls['result'].setValue('');
    this.error = '';
  }

  setResult(result: any){
    this.converterForm.controls['result'].setValue(result);
  }

}
