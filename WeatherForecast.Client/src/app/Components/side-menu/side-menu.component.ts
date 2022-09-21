import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-side-menu',
  templateUrl: './side-menu.component.html',
  styleUrls: ['./side-menu.component.scss'],
})
export class SideMenuComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {
    var a = 0;
    // this.weatherService.getCurrentWeather(1).subscribe(
    //   responce => {
    //     this.weatherList = responce;
    //   }
    // );
  }
}
