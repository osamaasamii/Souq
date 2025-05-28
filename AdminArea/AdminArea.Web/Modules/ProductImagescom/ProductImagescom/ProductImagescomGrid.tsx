import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ProductImagescomColumns, ProductImagescomRow, ProductImagescomService } from '../../ServerTypes/ProductImagescom';
import { ProductImagescomDialog } from './ProductImagescomDialog';

@Decorators.registerClass('AdminArea.ProductImagescom.ProductImagescomGrid')
export class ProductImagescomGrid extends EntityGrid<ProductImagescomRow> {
    protected getColumnsKey() { return ProductImagescomColumns.columnsKey; }
    protected getDialogType() { return ProductImagescomDialog; }
    protected getRowDefinition() { return ProductImagescomRow; }
    protected getService() { return ProductImagescomService.baseUrl; }
}