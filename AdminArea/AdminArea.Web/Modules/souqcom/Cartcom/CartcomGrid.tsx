import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { CartcomColumns, CartcomRow, CartcomService } from '../../ServerTypes/souqcom';
import { CartcomDialog } from './CartcomDialog';

@Decorators.registerClass('AdminArea.souqcom.CartcomGrid')
export class CartcomGrid extends EntityGrid<CartcomRow> {
    protected getColumnsKey() { return CartcomColumns.columnsKey; }
    protected getDialogType() { return CartcomDialog; }
    protected getRowDefinition() { return CartcomRow; }
    protected getService() { return CartcomService.baseUrl; }
}