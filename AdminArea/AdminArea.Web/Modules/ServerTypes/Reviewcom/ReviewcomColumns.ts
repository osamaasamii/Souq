import { ColumnsBase, fieldsProxy } from "@serenity-is/corelib";
import { Column } from "@serenity-is/sleekgrid";
import { ReviewcomRow } from "./ReviewcomRow";

export interface ReviewcomColumns {
    Id: Column<ReviewcomRow>;
    Name: Column<ReviewcomRow>;
    Email: Column<ReviewcomRow>;
    Subject: Column<ReviewcomRow>;
    Message: Column<ReviewcomRow>;
}

export class ReviewcomColumns extends ColumnsBase<ReviewcomRow> {
    static readonly columnsKey = 'Reviewcom.Reviewcom';
    static readonly Fields = fieldsProxy<ReviewcomColumns>();
}