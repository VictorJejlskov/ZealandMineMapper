import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CalculationService {

  constructor() { }

  Add(number1: number, number2: number): number {return number1+number2}
  Sub(number1: number, number2: number): number {return number1-number2}
  Mul(number1: number, number2: number): number {return number1*number2}
  Div(number1: number, number2: number): number {return number1/number2}

}
