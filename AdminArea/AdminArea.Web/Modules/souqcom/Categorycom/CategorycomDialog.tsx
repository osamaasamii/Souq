import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { CategorycomForm, CategorycomRow, CategorycomService } from '../../ServerTypes/souqcom';

@Decorators.registerClass('AdminArea.souqcom.CategorycomDialog')
export class CategorycomDialog extends EntityDialog<CategorycomRow, any> {
    protected getFormKey() { return CategorycomForm.formKey; }
    protected getRowDefinition() { return CategorycomRow; }
    protected getService() { return CategorycomService.baseUrl; }

    protected form = new CategorycomForm(this.idPrefix);
}