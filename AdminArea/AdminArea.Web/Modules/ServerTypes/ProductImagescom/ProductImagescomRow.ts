import { fieldsProxy } from "@serenity-is/corelib";

export interface ProductImagescomRow {
    Id?: number;
    ProductId?: number;
    Image?: string;
    ProductName?: string;
}

export abstract class ProductImagescomRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Image';
    static readonly localTextPrefix = 'ProductImagescom.ProductImagescom';
    static readonly deletePermission = 'ProductImagescom';
    static readonly insertPermission = 'ProductImagescom';
    static readonly readPermission = 'ProductImagescom';
    static readonly updatePermission = 'ProductImagescom';

    static readonly Fields = fieldsProxy<ProductImagescomRow>();
}