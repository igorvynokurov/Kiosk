﻿import { Component, OnInit, OnDestroy, Input } from '@angular/core';
import { Subscription } from 'rxjs/Subscription';
import { LoaderService } from '../../services/loader.service';
import { LoaderState } from './loader-state';

@Component({
    selector: 'loader',
    templateUrl: 'loader.component.html',
    styleUrls: ['loader.component.scss']
})
export class LoaderComponent implements OnInit {
    @Input() show: boolean = false;
    //private subscription: Subscription;
    constructor(
          private loaderService: LoaderService
          ) { 
    }

    ngOnInit() {
       /* this.subscription = this.loaderService.loaderState
            .subscribe((state: LoaderState) => {
                this.show = state.show;
            });*/
    }

    ngOnDestroy() {
        //this.subscription.unsubscribe();
    }
}