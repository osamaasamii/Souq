import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CartcomForm, CartcomRow, CartcomService } from '../../ServerTypes/souqcom';

@Decorators.registerClass('AdminArea.souqcom.CartcomDialog')
export class CartcomDialog extends EntityDialog<CartcomRow, any> {
    protected getFormKey() { return CartcomForm.formKey; }
    protected getRowDefinition() { return CartcomRow; }
    protected getService() { return CartcomService.baseUrl; }

    protected form = new CartcomForm(this.idPrefix);
}