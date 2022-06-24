import { Component } from '@angular/core';
import { TimeBoxComponent } from '../time-box/time-box.component';
import { DOCUMENT } from '@angular/common';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css', '../pattern.min.css']
})
export class HomeComponent {
  title = 'Time-slot picker';

  myFunc(element: any, event: any){
    let mask_css = 'time-box-mask pattern-diagonal-stripes-ss'
    let non_mask_css = 'time-box'

    let elem = document.getElementById(event.target.id);

    if(!elem) return;

    console.log(elem.className);

    let isMask = elem.className == mask_css;
    if(isMask){
      elem.className = non_mask_css;
    }else{
      elem.className = mask_css;
    }
  }
}
