import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProductcomColumns, ProductcomRow, ProductcomService } from '../../ServerTypes/Productcom';
import { ProductcomDialog } from './ProductcomDialog';

@Decorators.registerClass('AdminArea.Productcom.ProductcomGrid')
export class ProductcomGrid extends EntityGrid<ProductcomRow> {
    protected getColumnsKey() { return ProductcomColumns.columnsKey; }
    protected getDialogType() { return ProductcomDialog; }
    protected getRowDefinition() { return ProductcomRow; }
    protected getService() { return ProductcomService.baseUrl; }
}