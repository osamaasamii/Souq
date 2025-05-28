import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ProductImagescomRow } from "./ProductImagescomRow";

export interface ProductImagescomColumns {
    Id: Column<ProductImagescomRow>;
    ProductName: Column<ProductImagescomRow>;
    Image: Column<ProductImagescomRow>;
}

export class ProductImagescomColumns extends ColumnsBase<ProductImagescomRow> {
    static readonly columnsKey = 'ProductImagescom.ProductImagescom';
    static readonly Fields = fieldsProxy<ProductImagescomColumns>();
}