import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Router } from '@angular/router';
import { User } from '../models/user';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  //userData = new BehaviorSubject<User>(new User());
  private currentUserSubject: BehaviorSubject<User>;
  public currentUser: Observable<User>;

  constructor(private http: HttpClient, private router: Router) {
   if (localStorage.getItem('authToken') !==null) {
      
      let stringified = localStorage.getItem('authToken');
      console.log(String(stringified).toString());
      //this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(window.atob(localStorage.getItem('authToken').split('.')[1])));

      this.currentUserSubject = new BehaviorSubject<User>(JSON.parse(stringified).userDetails);//new BehaviorSubject<User>(JSON.parse(stringified));
     
      this.currentUser = this.currentUserSubject.asObservable();
    }   
  }

  public get currentUserValue(): User {
    if (this.currentUserSubject) {
      return this.currentUserSubject.value;

    }
    return null;
  }

  login(userDetails) { 
    return this.http.post<any>(`${environment.apiUrl}/api/login`, userDetails)
      .pipe(map(response => {
        localStorage.setItem('authToken', JSON.stringify(response));     
        response.userDetails.isLoggedIn = true;
        console.log(response.userDetails);
        console.log(this.currentUserSubject);
        this.currentUserSubject.next(response.userDetails);
        return response.userDetails;
      }));
  }

  //setUserDetails() {
  //  if (localStorage.getItem('authToken')) {
  //    const userDetails = new User();
  //    const decodeUserDetails = JSON.parse(window.atob(localStorage.getItem('authToken').split('.')[1]));

  //    userDetails.userName = decodeUserDetails.sub;
  //    userDetails.firstName = decodeUserDetails.firstName;
  //    userDetails.isLoggedIn = true;
  //    userDetails.role = decodeUserDetails.role;

  //    return userDetails;
  //  }
  //}

  logout() {
    localStorage.removeItem('authToken');
    this.router.navigate(['/login']);
    this.currentUserSubject.next(null);
  }
}
