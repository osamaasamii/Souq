import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ReviewcomRow } from "./ReviewcomRow";

export namespace ReviewcomService {
    export const baseUrl = 'Reviewcom/Reviewcom';

    export declare function Create(request: SaveRequest<ReviewcomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ReviewcomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ReviewcomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ReviewcomRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ReviewcomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ReviewcomRow>>;

    export const Methods = {
        Create: "Reviewcom/Reviewcom/Create",
        Update: "Reviewcom/Reviewcom/Update",
        Delete: "Reviewcom/Reviewcom/Delete",
        Retrieve: "Reviewcom/Reviewcom/Retrieve",
        List: "Reviewcom/Reviewcom/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ReviewcomService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}