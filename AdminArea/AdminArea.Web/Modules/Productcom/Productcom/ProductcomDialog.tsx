import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProductcomForm, ProductcomRow, ProductcomService } from '../../ServerTypes/Productcom';

@Decorators.registerClass('AdminArea.Productcom.ProductcomDialog')
export class ProductcomDialog extends EntityDialog<ProductcomRow, any> {
    protected getFormKey() { return ProductcomForm.formKey; }
    protected getRowDefinition() { return ProductcomRow; }
    protected getService() { return ProductcomService.baseUrl; }

    protected form = new ProductcomForm(this.idPrefix);
}