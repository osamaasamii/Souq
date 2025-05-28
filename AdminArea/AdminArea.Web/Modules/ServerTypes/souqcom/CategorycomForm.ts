import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface CategorycomForm {
    Name: StringEditor;
    Image: StringEditor;
    Description: StringEditor;
}

export class CategorycomForm extends PrefixedContext {
    static readonly formKey = 'souqcom.Categorycom';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!CategorycomForm.init)  {
            CategorycomForm.init = true;

            var w0 = StringEditor;

            initFormType(CategorycomForm, [
                'Name', w0,
                'Image', w0,
                'Description', w0
            ]);
        }
    }
}