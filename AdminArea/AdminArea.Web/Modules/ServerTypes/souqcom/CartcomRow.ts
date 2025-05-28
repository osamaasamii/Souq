import { fieldsProxy } from "@serenity-is/corelib";

export interface CartcomRow {
    Id?: number;
    UserId?: number;
    ProductId?: number;
    Qty?: number;
    ProductName?: string;
}

export abstract class CartcomRow {
    static readonly idProperty = 'Id';
    static readonly localTextPrefix = 'souqcom.Cartcom';
    static readonly deletePermission = 'Cartcom';
    static readonly insertPermission = 'Cartcom';
    static readonly readPermission = 'Cartcom';
    static readonly updatePermission = 'Cartcom';

    static readonly Fields = fieldsProxy<CartcomRow>();
}