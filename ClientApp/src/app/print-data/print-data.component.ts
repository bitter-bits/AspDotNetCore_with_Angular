import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-print-data',
  templateUrl: './print-data.component.html'
})
export class PrintDataComponent {
  public print_data_value = "hello print DATA";
}
