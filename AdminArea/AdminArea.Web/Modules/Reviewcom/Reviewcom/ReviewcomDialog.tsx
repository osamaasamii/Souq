import { Decorators, EntityDialog } from '@serenity-is/corelib';
import { ReviewcomForm, ReviewcomRow, ReviewcomService } from '../../ServerTypes/Reviewcom';

@Decorators.registerClass('AdminArea.Reviewcom.ReviewcomDialog')
export class ReviewcomDialog extends EntityDialog<ReviewcomRow, any> {
    protected getFormKey() { return ReviewcomForm.formKey; }
    protected getRowDefinition() { return ReviewcomRow; }
    protected getService() { return ReviewcomService.baseUrl; }

    protected form = new ReviewcomForm(this.idPrefix);
}