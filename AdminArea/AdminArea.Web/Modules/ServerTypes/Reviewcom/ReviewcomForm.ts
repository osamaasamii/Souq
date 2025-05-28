import { StringEditor, PrefixedContext, initFormType } from "@serenity-is/corelib";

export interface ReviewcomForm {
    Name: StringEditor;
    Email: StringEditor;
    Subject: StringEditor;
    Message: StringEditor;
}

export class ReviewcomForm extends PrefixedContext {
    static readonly formKey = 'Reviewcom.Reviewcom';
    private static init: boolean;

    constructor(prefix: string) {
        super(prefix);

        if (!ReviewcomForm.init)  {
            ReviewcomForm.init = true;

            var w0 = StringEditor;

            initFormType(ReviewcomForm, [
                'Name', w0,
                'Email', w0,
                'Subject', w0,
                'Message', w0
            ]);
        }
    }
}