import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  constructor(private http: HttpClient) { }

  title = 'app';
  userResponse:any = {}

  ngOnInit() {
    this.http.get('http://localhost:51285/api/auth', { withCredentials: true }).subscribe((resp: any) => {
      console.log(resp)
      this.userResponse = resp
    });
  }
}
