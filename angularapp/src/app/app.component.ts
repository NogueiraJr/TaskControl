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

  title = 'angularapp';
}

interface todolist {
  description: string;
  duedate: Date;
  situation: string;
}
