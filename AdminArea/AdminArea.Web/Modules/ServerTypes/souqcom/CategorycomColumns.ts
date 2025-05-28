import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CategorycomRow } from "./CategorycomRow";

export interface CategorycomColumns {
    Id: Column<CategorycomRow>;
    Name: Column<CategorycomRow>;
    Image: Column<CategorycomRow>;
    Description: Column<CategorycomRow>;
}

export class CategorycomColumns extends ColumnsBase<CategorycomRow> {
    static readonly columnsKey = 'souqcom.Categorycom';
    static readonly Fields = fieldsProxy<CategorycomColumns>();
}