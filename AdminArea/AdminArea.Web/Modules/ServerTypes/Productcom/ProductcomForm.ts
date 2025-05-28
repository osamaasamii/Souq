import { StringEditor, DecimalEditor, ServiceLookupEditor, DateEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ProductcomForm {
    Name: StringEditor;
    Description: StringEditor;
    Price: DecimalEditor;
    Image: StringEditor;
    CategoryId: ServiceLookupEditor;
    Date: DateEditor;
}

export class ProductcomForm extends PrefixedContext {
    static readonly formKey = 'Productcom.Productcom';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductcomForm.init)  {
            ProductcomForm.init = true;

            var w0 = StringEditor;
            var w1 = DecimalEditor;
            var w2 = ServiceLookupEditor;
            var w3 = DateEditor;

            initFormType(ProductcomForm, [
                'Name', w0,
                'Description', w0,
                'Price', w1,
                'Image', w0,
                'CategoryId', w2,
                'Date', w3
            ]);
        }
    }
}