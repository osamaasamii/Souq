import { Decorators, EntityGrid } from '@serenity-is/corelib';
import { ReviewcomColumns, ReviewcomRow, ReviewcomService } from '../../ServerTypes/Reviewcom';
import { ReviewcomDialog } from './ReviewcomDialog';

@Decorators.registerClass('AdminArea.Reviewcom.ReviewcomGrid')
export class ReviewcomGrid extends EntityGrid<ReviewcomRow> {
    protected getColumnsKey() { return ReviewcomColumns.columnsKey; }
    protected getDialogType() { return ReviewcomDialog; }
    protected getRowDefinition() { return ReviewcomRow; }
    protected getService() { return ReviewcomService.baseUrl; }
}