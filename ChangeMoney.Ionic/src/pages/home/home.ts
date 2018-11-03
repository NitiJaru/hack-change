import { Component } from '@angular/core';
import { NavController } from 'ionic-angular';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'page-home',
  templateUrl: 'home.html'
})
export class HomePage {

  private amount: number;
  private pay: number;
  private data: any = null;

  constructor(public navCtrl: NavController, private http: HttpClient) {

  }

  calculate() {
    if (this.pay > this.amount) {
      alert("Pay's value must have more than Amount'value.");
      return;
    }
    let parameter = this.amount + "/" + this.pay;
    this.http.get("https://localhost:5001/api/values/" + parameter)
      .subscribe((data: any) => {
        this.data = data;
        console.log(JSON.stringify(this.data));
      }, error => {
        alert("Something error, please check connection.")
      });
  }

}
