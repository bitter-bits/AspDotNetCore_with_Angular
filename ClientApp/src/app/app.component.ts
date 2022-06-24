import { Component } from '@angular/core';
import { time_slot_table_init } from './time_slot_table_init';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';
  time_slot_table = time_slot_table_init
}
