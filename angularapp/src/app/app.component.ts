import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public forecasts?: todolist[];

  constructor(http: HttpClient) {
    http.get<todolist[]>('/todolist').subscribe(result => {
      this.forecasts = result;
    }, error => console.error(error));
  }

  title = 'angularapp';
}

interface todolist {
  date: string;
  valMin: number;
  valMax: number;
  summary: string;
}
