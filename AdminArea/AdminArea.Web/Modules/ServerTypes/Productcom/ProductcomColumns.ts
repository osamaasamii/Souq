import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ProductcomRow } from "./ProductcomRow";

export interface ProductcomColumns {
    Id: Column<ProductcomRow>;
    Name: Column<ProductcomRow>;
    Description: Column<ProductcomRow>;
    Price: Column<ProductcomRow>;
    Image: Column<ProductcomRow>;
    CategoryName: Column<ProductcomRow>;
    Date: Column<ProductcomRow>;
}

export class ProductcomColumns extends ColumnsBase<ProductcomRow> {
    static readonly columnsKey = 'Productcom.Productcom';
    static readonly Fields = fieldsProxy<ProductcomColumns>();
}