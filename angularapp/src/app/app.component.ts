import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public tasklists?: todolist[];

  constructor(http: HttpClient) {
    http.get<todolist[]>('/TodoList').subscribe(result => {
      this.tasklists = result;
    }, error => console.error(error));
  }

  title = 'B3 Test';
}

interface todolist {
  description: string;
  duedate: string;
  situation: string;
}
