import { AgePipe } from './age.pipe';

describe('AgePipe', () => {
  it('create an instance', () => {
    const pipe = new AgePipe();
    expect(pipe).toBeTruthy();
  });
  it('should display if num1 is passed ',()=>{
    const pipe=new AgePipe();
    expect(pipe.transform(5)).toEqual('my age is5');
  }
  )
});


// npm install jasmine --save-dev
