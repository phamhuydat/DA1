import { __decorate } from "tslib";
import { Component, EventEmitter, Input, Output } from '@angular/core';
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
export { Bs4PaginationComponent };
//# sourceMappingURL=data:application/json;base64,eyJ2ZXJzaW9uIjozLCJmaWxlIjoiYnM0LXBhZ2luYXRpb24uY29tcG9uZW50LmpzIiwic291cmNlUm9vdCI6Im5nOi8vYnM0LXBhZ2luYXRpb24vIiwic291cmNlcyI6WyJsaWIvYnM0LXBhZ2luYXRpb24uY29tcG9uZW50LnRzIl0sIm5hbWVzIjpbXSwibWFwcGluZ3MiOiI7QUFBQSxPQUFPLEVBQUMsU0FBUyxFQUFFLFlBQVksRUFBRSxLQUFLLEVBQXFCLE1BQU0sRUFBZ0IsTUFBTSxlQUFlLENBQUM7QUEyQ3ZHO0lBSUU7UUFGVSxlQUFVLEdBQUcsSUFBSSxZQUFZLEVBQUUsQ0FBQztJQUcxQyxDQUFDO0lBRUQseUNBQVEsR0FBUjtJQUNBLENBQUM7SUFFRCx1Q0FBTSxHQUFOLFVBQU8sQ0FBTTtRQUNYLElBQUksQ0FBQyxVQUFVLENBQUMsSUFBSSxDQUFDLENBQUMsQ0FBQyxDQUFDO0lBRTFCLENBQUM7SUFFRCw0Q0FBVyxHQUFYLFVBQVksT0FBc0I7UUFFaEMsSUFBSSxDQUFDLFNBQVMsR0FBRyxPQUFPLENBQUMsU0FBUyxDQUFDLFlBQVksQ0FBQztRQUNoRCxPQUFPLENBQUMsR0FBRyxDQUFDLElBQUksQ0FBQyxTQUFTLENBQUMsQ0FBQztJQUM5QixDQUFDO0lBRUQscUNBQUksR0FBSixVQUFLLENBQUM7UUFDSixPQUFPLElBQUksQ0FBQyxJQUFJLENBQUMsQ0FBQyxDQUFDLENBQUM7SUFDdEIsQ0FBQztJQUVELDhDQUFhLEdBQWIsVUFBYyxLQUFLO1FBQ2pCLElBQU0sR0FBRyxHQUFHLEVBQUUsQ0FBQztRQUNmLEtBQUssSUFBSSxDQUFDLEdBQUcsQ0FBQyxFQUFFLENBQUMsSUFBSSxLQUFLLEVBQUUsQ0FBQyxFQUFFLEVBQUU7WUFDL0IsR0FBRyxDQUFDLElBQUksQ0FBQyxDQUFDLENBQUMsQ0FBQztTQUNiO1FBQ0QsT0FBTyxHQUFHLENBQUM7SUFDYixDQUFDO0lBOUJRO1FBQVIsS0FBSyxFQUFFOzZEQUF1QjtJQUNyQjtRQUFULE1BQU0sRUFBRTs4REFBaUM7SUFGL0Isc0JBQXNCO1FBdkJsQyxTQUFTLENBQUM7WUFDVCxRQUFRLEVBQUUsb0JBQW9CO1lBQzlCLFFBQVEsRUFBRSxtNUJBY0s7cUJBQ04sdURBSVI7U0FDRixDQUFDO09BQ1csc0JBQXNCLENBZ0NsQztJQUFELDZCQUFDO0NBQUEsQUFoQ0QsSUFnQ0M7U0FoQ1ksc0JBQXNCIiwic291cmNlc0NvbnRlbnQiOlsiaW1wb3J0IHtDb21wb25lbnQsIEV2ZW50RW1pdHRlciwgSW5wdXQsIE9uQ2hhbmdlcywgT25Jbml0LCBPdXRwdXQsIFNpbXBsZUNoYW5nZXN9IGZyb20gJ0Bhbmd1bGFyL2NvcmUnO1xuXG4vLyB0c2xpbnQ6ZGlzYWJsZS1uZXh0LWxpbmU6Y2xhc3MtbmFtZVxuaW50ZXJmYWNlIG15UGFnaW5hdGUge1xuXG4gIGN1cnJlbnRfcGFnZTogbnVtYmVyO1xuICBkYXRhOiBhbnk7XG4gIGZpcnN0X3BhZ2VfdXJsOiBzdHJpbmc7XG4gIGZyb206IG51bWJlcjtcbiAgbGFzdF9wYWdlOiBudW1iZXI7XG4gIGxhc3RfcGFnZV91cmw6IHN0cmluZztcbiAgbmV4dF9wYWdlX3VybDogc3RyaW5nO1xuICBwYXRoOiBzdHJpbmc7XG4gIHBlcl9wYWdlOiBudW1iZXI7XG4gIHByZXZfcGFnZV91cmw/OiBhbnk7XG4gIHRvOiBudW1iZXI7XG4gIHRvdGFsOiBudW1iZXI7XG5cbn1cblxuQENvbXBvbmVudCh7XG4gIHNlbGVjdG9yOiAnbGliLWJzNC1wYWdpbmF0aW9uJyxcbiAgdGVtcGxhdGU6IGBcbiAgICA8ZGl2IHN0eWxlPVwib3ZlcmZsb3cteTogYXV0b1wiPlxuICAgICAgPG5hdiBhcmlhLWxhYmVsPVwibmF2aWdhdGlvblwiPlxuICAgICAgICA8dWwgY2xhc3M9XCJwYWdpbmF0aW9uXCI+XG4gICAgICAgICAgPGxpIGNsYXNzPVwicGFnZS1pdGVtXCIgKGNsaWNrKT1cImNoYW5nZSgxKVwiIFtjbGFzcy5hY3RpdmVdPVwibVBhZ2luYXRlLmN1cnJlbnRfcGFnZSA9PSAxXCI+PGEgY2xhc3M9XCJwYWdlLWxpbmtcIj5JbmljaW88L2E+PC9saT5cbiAgICAgICAgICA8bmctY29udGFpbmVyICpuZ0Zvcj1cImxldCBpIG9mIG51bWJlclRvQXJyYXkoY2VpbChtUGFnaW5hdGUuY3VycmVudF9wYWdlICsgMykpXCI+XG4gICAgICAgICAgICA8bGkgY2xhc3M9XCJwYWdlLWl0ZW1cIlxuICAgICAgICAgICAgICAgICpuZ0lmPVwibVBhZ2luYXRlLmN1cnJlbnRfcGFnZSAtIGkgPj0gLTMgJiYgbVBhZ2luYXRlLmN1cnJlbnRfcGFnZSAtIGkgPCAzICYmIChpPD1tUGFnaW5hdGUubGFzdF9wYWdlICYmIGkgPj0gMSlcIlxuICAgICAgICAgICAgICAgIChjbGljayk9XCJjaGFuZ2UoaSlcIiBbY2xhc3MuYWN0aXZlXT1cImkgPT0gbVBhZ2luYXRlLmN1cnJlbnRfcGFnZVwiPjxhIGNsYXNzPVwicGFnZS1saW5rXCI+e3tpfX08L2E+PC9saT5cbiAgICAgICAgICA8L25nLWNvbnRhaW5lcj5cbiAgICAgICAgICA8bGkgY2xhc3M9XCJwYWdlLWl0ZW1cIiAoY2xpY2spPVwiY2hhbmdlKG1QYWdpbmF0ZS5sYXN0X3BhZ2UpXCIgW2NsYXNzLmFjdGl2ZV09XCJtUGFnaW5hdGUuY3VycmVudF9wYWdlID09IG1QYWdpbmF0ZS5sYXN0X3BhZ2VcIj48YVxuICAgICAgICAgICAgY2xhc3M9XCJwYWdlLWxpbmtcIj7Dmmx0aW1vPC9hPjwvbGk+XG4gICAgICAgIDwvdWw+XG4gICAgICA8L25hdj5cbiAgICA8L2Rpdj4gICAgICBgLFxuICBzdHlsZXM6IFtgXG4gICAgLnBhZ2UtaXRlbSB7XG4gICAgICBjdXJzb3I6IHBvaW50ZXI7XG4gICAgfVxuICBgXVxufSlcbmV4cG9ydCBjbGFzcyBCczRQYWdpbmF0aW9uQ29tcG9uZW50IGltcGxlbWVudHMgT25Jbml0LCBPbkNoYW5nZXMge1xuICBASW5wdXQoKSBtUGFnaW5hdGU6IG15UGFnaW5hdGU7XG4gIEBPdXRwdXQoKSBjaGFuZ2VQYWdlID0gbmV3IEV2ZW50RW1pdHRlcigpO1xuXG4gIGNvbnN0cnVjdG9yKCkge1xuICB9XG5cbiAgbmdPbkluaXQoKTogdm9pZCB7XG4gIH1cblxuICBjaGFuZ2UoaTogYW55KSB7XG4gICAgdGhpcy5jaGFuZ2VQYWdlLmVtaXQoaSk7XG5cbiAgfVxuXG4gIG5nT25DaGFuZ2VzKGNoYW5nZXM6IFNpbXBsZUNoYW5nZXMpIHtcblxuICAgIHRoaXMubVBhZ2luYXRlID0gY2hhbmdlcy5tUGFnaW5hdGUuY3VycmVudFZhbHVlO1xuICAgIGNvbnNvbGUubG9nKHRoaXMubVBhZ2luYXRlKTtcbiAgfVxuXG4gIGNlaWwoeCkge1xuICAgIHJldHVybiBNYXRoLmNlaWwoeCk7XG4gIH1cblxuICBudW1iZXJUb0FycmF5KHZhbHVlKSB7XG4gICAgY29uc3QgcmVzID0gW107XG4gICAgZm9yIChsZXQgaSA9IDE7IGkgPD0gdmFsdWU7IGkrKykge1xuICAgICAgcmVzLnB1c2goaSk7XG4gICAgfVxuICAgIHJldHVybiByZXM7XG4gIH1cbn1cbiJdfQ==