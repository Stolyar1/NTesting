import { Component } from '@angular/core';
import { AuthService } from '../services/auth.service';
import { User } from '../models/user';
import { UserRole } from '../models/roles';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;
  userData: User;  
  userRole = UserRole;

  constructor(private authService: AuthService) {
    if (this.authService.currentUserValue) {

      this.authService.currentUser.subscribe(x => this.userData = x);
      //console.log('NavMenu' + this.userData)
    }
    else {
      this.userData = new User
      this.userData.IsLoggedIn = false;
    }
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  logout() {
    this.authService.logout();
  }
}
