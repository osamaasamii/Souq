import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CategorycomColumns, CategorycomRow, CategorycomService } from '../../ServerTypes/souqcom';
import { CategorycomDialog } from './CategorycomDialog';

@Decorators.registerClass('AdminArea.souqcom.CategorycomGrid')
export class CategorycomGrid extends EntityGrid<CategorycomRow> {
    protected getColumnsKey() { return CategorycomColumns.columnsKey; }
    protected getDialogType() { return CategorycomDialog; }
    protected getRowDefinition() { return CategorycomRow; }
    protected getService() { return CategorycomService.baseUrl; }
}