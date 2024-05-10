import { EventEmitter, OnChanges, OnInit, SimpleChanges } from '@angular/core';
interface myPaginate {
    current_page: number;
    data: any;
    first_page_url: string;
    from: number;
    last_page: number;
    last_page_url: string;
    next_page_url: string;
    path: string;
    per_page: number;
    prev_page_url?: any;
    to: number;
    total: number;
}
export declare class Bs4PaginationComponent implements OnInit, OnChanges {
    mPaginate: myPaginate;
    changePage: EventEmitter<any>;
    constructor();
    ngOnInit(): void;
    change(i: any): void;
    ngOnChanges(changes: SimpleChanges): void;
    ceil(x: any): number;
    numberToArray(value: any): any[];
}
export {};
