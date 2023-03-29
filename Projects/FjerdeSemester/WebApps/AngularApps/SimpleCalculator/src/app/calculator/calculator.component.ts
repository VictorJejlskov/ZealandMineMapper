import { Component } from '@angular/core';
import { CalculationService } from '../calculation.service';

@Component({
  selector: 'app-calculator',
  templateUrl: './calculator.component.html',
  styleUrls: ['./calculator.component.css']
})
export class CalculatorComponent {
  number1: number;
  number2: number;
  result: number

  constructor(private calculation: CalculationService){
    this.number1 = 0;
    this.number2 = 0;
    this.result = 0
  }

  Add() {this.result = this.calculation.Add(this.number1, this.number2)}
  Sub() {this.result = this.calculation.Sub(this.number1, this.number2)}
  Mul() {this.result = this.calculation.Mul(this.number1, this.number2)}
  Div() {this.result = this.calculation.Div(this.number1, this.number2)}
}
