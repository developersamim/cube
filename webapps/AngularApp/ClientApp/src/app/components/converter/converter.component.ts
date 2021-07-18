import { Component, OnInit } from '@angular/core';
import { ControlValueAccessor, FormBuilder, FormControl, FormGroup } from '@angular/forms';

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

  constructor(
    private fb: FormBuilder
  ) {
    this.converterForm = this.fb.group({
      from: new FormControl(''),
      to: new FormControl(''),
      requestedValue: new FormControl(''),
      retrievedValue: new FormControl('')
    })

    this.options = this.getOptions();
    this.selectedFrom = this.options[0];
    this.selectedTo = this.options[2];
    this.converterForm.controls['from'].setValue(this.selectedFrom);
    this.converterForm.controls['to'].setValue(this.selectedTo);

    //this.converterForm.controls['retrievedValue'].setValue(5);
  }

  getOptions() {
    return [
      'Centigrade',
      'Fahrenheit',
      'Kelvin',
    ]
  }

  ngOnInit() {

  }

  onSubmit(){

  }

  onFromChange()
  {
    this.selectedFrom = this.converterForm.get('from')?.value;
  }

  onToChange()
  {
    this.selectedTo = this.converterForm.get('to')?.value;
  }
}
