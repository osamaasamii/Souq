import { ServiceLookupEditor, StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ProductImagescomForm {
    ProductId: ServiceLookupEditor;
    Image: StringEditor;
}

export class ProductImagescomForm extends PrefixedContext {
    static readonly formKey = 'ProductImagescom.ProductImagescom';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ProductImagescomForm.init)  {
            ProductImagescomForm.init = true;

            var w0 = ServiceLookupEditor;
            var w1 = StringEditor;

            initFormType(ProductImagescomForm, [
                'ProductId', w0,
                'Image', w1
            ]);
        }
    }
}