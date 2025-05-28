import { fieldsProxy } from "@serenity-is/corelib";

export interface CategorycomRow {
    Id?: number;
    Name?: string;
    Image?: string;
    Description?: string;
}

export abstract class CategorycomRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'souqcom.Categorycom';
    static readonly deletePermission = 'Categorycom';
    static readonly insertPermission = 'Categorycom';
    static readonly readPermission = 'Categorycom';
    static readonly updatePermission = 'Categorycom';

    static readonly Fields = fieldsProxy<CategorycomRow>();
}