import { IntegerEditor, ServiceLookupEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CartcomForm {
    UserId: IntegerEditor;
    ProductId: ServiceLookupEditor;
    Qty: IntegerEditor;
}

export class CartcomForm extends PrefixedContext {
    static readonly formKey = 'souqcom.Cartcom';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CartcomForm.init)  {
            CartcomForm.init = true;

            var w0 = IntegerEditor;
            var w1 = ServiceLookupEditor;

            initFormType(CartcomForm, [
                'UserId', w0,
                'ProductId', w1,
                'Qty', w0
            ]);
        }
    }
}