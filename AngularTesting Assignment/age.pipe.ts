import { Pipe, PipeTransform } from '@angular/core';
import {TestBed,ComponentFixture} from '@angular/core/testing';

@Pipe({
  name: 'age'
})
export class AgePipe implements PipeTransform {

  transform(num1: number): string {
    return 'my age is' + num1;
  }
  

}
