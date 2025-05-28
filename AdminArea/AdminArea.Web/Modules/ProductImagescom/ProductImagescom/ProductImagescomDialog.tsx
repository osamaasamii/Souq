import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ProductImagescomForm, ProductImagescomRow, ProductImagescomService } from '../../ServerTypes/ProductImagescom';

@Decorators.registerClass('AdminArea.ProductImagescom.ProductImagescomDialog')
export class ProductImagescomDialog extends EntityDialog<ProductImagescomRow, any> {
    protected getFormKey() { return ProductImagescomForm.formKey; }
    protected getRowDefinition() { return ProductImagescomRow; }
    protected getService() { return ProductImagescomService.baseUrl; }

    protected form = new ProductImagescomForm(this.idPrefix);
}