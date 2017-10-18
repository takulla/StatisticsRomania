﻿import { Component, OnInit, Pipe, ViewChild, ElementRef } from '@angular/core';
import { Http } from '@angular/http';
import { CookieService } from 'ngx-cookie-service';

@Component({
    selector: 'performers',
    templateUrl: './performers.component.html',
})
export class PerformersComponent {
    public comparisonType: number;
    public indicators: Array<IndicatorPerformers>;

    private favouriteCountiesCookieKey: string;

    constructor(private http: Http, private cookieService: CookieService) {
        this.favouriteCountiesCookieKey = 'favouriteCounties';

        this.comparisonType = 2;

        this.LoadData();
    }

    LoadData() {
        this.http.get('/api/IndicatorPerformers/GetIndicatorPerformers' + (this.comparisonType == 2 ? 'ByYear' : '') + '?favouriteCounties=' + this.cookieService.get(this.favouriteCountiesCookieKey))
            .subscribe(result => {
                this.indicators = result.json();
                var selectedCounties = this.cookieService.get(this.favouriteCountiesCookieKey);
                this.indicators.forEach(indicator => indicator.performers.forEach(performer => performer.favourite = selectedCounties.indexOf(performer.county) > -1));
            });
    }

    ChangeComparisonType(comparisonType: number) {
        this.comparisonType = comparisonType;

        this.LoadData();
    }

    ToggleCounty(county: string) {
        var selectedCounties = this.cookieService.get(this.favouriteCountiesCookieKey);

        if (selectedCounties.indexOf(county) > -1) {
            selectedCounties = selectedCounties.replace(county + ' ', '');
        } else {
            selectedCounties += county + ' ';
        }

        this.indicators.forEach(indicator => indicator.performers.forEach(performer => performer.favourite = selectedCounties.indexOf(performer.county) > -1));

        this.cookieService.set(this.favouriteCountiesCookieKey, selectedCounties);

        this.LoadData();
    }
}

class IndicatorPerformers {
    name: string;
    comparisonPeriod: string;
    performers: Array<Performer>;
}

class Performer {
    position: number;
    county: string;
    oldValue: number;
    newValue: number;
    valueVariation: string;
    favourite: boolean;
}