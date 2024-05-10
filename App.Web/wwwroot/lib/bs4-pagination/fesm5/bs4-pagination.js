import { __decorate } from 'tslib';
import { EventEmitter, Input, Output, Component, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

var Bs4PaginationComponent = /** @class */ (function () {
    function Bs4PaginationComponent() {
        this.changePage = new EventEmitter();
    }
    Bs4PaginationComponent.prototype.ngOnInit = function () {
    };
    Bs4PaginationComponent.prototype.change = function (i) {
        this.changePage.emit(i);
    };
    Bs4PaginationComponent.prototype.ngOnChanges = function (changes) {
        this.mPaginate = changes.mPaginate.currentValue;
        console.log(this.mPaginate);
    };
    Bs4PaginationComponent.prototype.ceil = function (x) {
        return Math.ceil(x);
    };
    Bs4PaginationComponent.prototype.numberToArray = function (value) {
        var res = [];
        for (var i = 1; i <= value; i++) {
            res.push(i);
        }
        return res;
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
            template: "\n    <div style=\"overflow-y: auto\">\n      <nav aria-label=\"navigation\">\n        <ul class=\"pagination\">\n          <li class=\"page-item\" (click)=\"change(1)\" [class.active]=\"mPaginate.current_page == 1\"><a class=\"page-link\">Inicio</a></li>\n          <ng-container *ngFor=\"let i of numberToArray(ceil(mPaginate.current_page + 3))\">\n            <li class=\"page-item\"\n                *ngIf=\"mPaginate.current_page - i >= -3 && mPaginate.current_page - i < 3 && (i<=mPaginate.last_page && i >= 1)\"\n                (click)=\"change(i)\" [class.active]=\"i == mPaginate.current_page\"><a class=\"page-link\">{{i}}</a></li>\n          </ng-container>\n          <li class=\"page-item\" (click)=\"change(mPaginate.last_page)\" [class.active]=\"mPaginate.current_page == mPaginate.last_page\"><a\n            class=\"page-link\">\u00DAltimo</a></li>\n        </ul>\n      </nav>\n    </div>      ",
            styles: ["\n    .page-item {\n      cursor: pointer;\n    }\n  "]
        })
    ], Bs4PaginationComponent);
    return Bs4PaginationComponent;
}());

var Bs4PaginationModule = /** @class */ (function () {
    function Bs4PaginationModule() {
    }
    Bs4PaginationModule = __decorate([
        NgModule({
            declarations: [Bs4PaginationComponent],
            imports: [
                CommonModule
            ],
            exports: [Bs4PaginationComponent]
        })
    ], Bs4PaginationModule);
    return Bs4PaginationModule;
}());

/*
 * Public API Surface of bs4-pagination
 */

/**
 * Generated bundle index. Do not edit.
 */

export { Bs4PaginationModule, Bs4PaginationComponent as ɵa };
//# sourceMappingURL=bs4-pagination.js.map
