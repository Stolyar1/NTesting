import { Component } from '@angular/core';
import { User } from '../models/user';
import { AuthService } from '../services/auth.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  userData: User;
  userDataSubscription: any;


  constructor() {
    //this.userDataSubscription = this.authService.currentUserValue.asObservable().subscribe(data => {
    //  this.userData = data;
    //});
  }


}


