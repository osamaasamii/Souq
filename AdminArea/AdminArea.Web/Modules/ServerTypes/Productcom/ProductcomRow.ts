import { fieldsProxy } from "@serenity-is/corelib";

export interface ProductcomRow {
    Id?: number;
    Name?: string;
    Description?: string;
    Price?: number;
    Image?: string;
    CategoryId?: number;
    Date?: string;
    CategoryName?: string;
}

export abstract class ProductcomRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Productcom.Productcom';
    static readonly deletePermission = 'Productcom';
    static readonly insertPermission = 'Productcom';
    static readonly readPermission = 'Productcom';
    static readonly updatePermission = 'Productcom';

    static readonly Fields = fieldsProxy<ProductcomRow>();
}