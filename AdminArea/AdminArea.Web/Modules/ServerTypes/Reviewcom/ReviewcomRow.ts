import { fieldsProxy } from "@serenity-is/corelib";

export interface ReviewcomRow {
    Id?: number;
    Name?: string;
    Email?: string;
    Subject?: string;
    Message?: string;
}

export abstract class ReviewcomRow {
    static readonly idProperty = 'Id';
    static readonly nameProperty = 'Name';
    static readonly localTextPrefix = 'Reviewcom.Reviewcom';
    static readonly deletePermission = 'Reviewcom';
    static readonly insertPermission = 'Reviewcom';
    static readonly readPermission = 'Reviewcom';
    static readonly updatePermission = 'Reviewcom';

    static readonly Fields = fieldsProxy<ReviewcomRow>();
}