import { __decorate } from 'tslib';
import { EventEmitter, Input, Output, Component, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

let Bs4PaginationComponent = class Bs4PaginationComponent {
    constructor() {
        this.changePage = new EventEmitter();
    }
    ngOnInit() {
    }
    change(i) {
        this.changePage.emit(i);
    }
    ngOnChanges(changes) {
        this.mPaginate = changes.mPaginate.currentValue;
        console.log(this.mPaginate);
    }
    ceil(x) {
        return Math.ceil(x);
    }
    numberToArray(value) {
        const res = [];
        for (let i = 1; i <= value; i++) {
            res.push(i);
        }
        return res;
    }
};
__decorate([
    Input()
], Bs4PaginationComponent.prototype, "mPaginate", void 0);
__decorate([
    Output()
], Bs4PaginationComponent.prototype, "changePage", void 0);
Bs4PaginationComponent = __decorate([
    Component({
        selector: 'lib-bs4-pagination',
        template: `
    <div style="overflow-y: auto">
      <nav aria-label="navigation">
        <ul class="pagination">
          <li class="page-item" (click)="change(1)" [class.active]="mPaginate.current_page == 1"><a class="page-link">Inicio</a></li>
          <ng-container *ngFor="let i of numberToArray(ceil(mPaginate.current_page + 3))">
            <li class="page-item"
                *ngIf="mPaginate.current_page - i >= -3 && mPaginate.current_page - i < 3 && (i<=mPaginate.last_page && i >= 1)"
                (click)="change(i)" [class.active]="i == mPaginate.current_page"><a class="page-link">{{i}}</a></li>
          </ng-container>
          <li class="page-item" (click)="change(mPaginate.last_page)" [class.active]="mPaginate.current_page == mPaginate.last_page"><a
            class="page-link">Último</a></li>
        </ul>
      </nav>
    </div>      `,
        styles: [`
    .page-item {
      cursor: pointer;
    }
  `]
    })
], Bs4PaginationComponent);

let Bs4PaginationModule = class Bs4PaginationModule {
};
Bs4PaginationModule = __decorate([
    NgModule({
        declarations: [Bs4PaginationComponent],
        imports: [
            CommonModule
        ],
        exports: [Bs4PaginationComponent]
    })
], Bs4PaginationModule);

/*
 * Public API Surface of bs4-pagination
 */

/**
 * Generated bundle index. Do not edit.
 */

export { Bs4PaginationModule, Bs4PaginationComponent as ɵa };
//# sourceMappingURL=bs4-pagination.js.map
