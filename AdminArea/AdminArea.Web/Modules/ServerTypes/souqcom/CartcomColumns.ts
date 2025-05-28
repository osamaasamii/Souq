import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { CartcomRow } from "./CartcomRow";

export interface CartcomColumns {
    Id: Column<CartcomRow>;
    UserId: Column<CartcomRow>;
    ProductName: Column<CartcomRow>;
    Qty: Column<CartcomRow>;
}

export class CartcomColumns extends ColumnsBase<CartcomRow> {
    static readonly columnsKey = 'souqcom.Cartcom';
    static readonly Fields = fieldsProxy<CartcomColumns>();
}