import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CategorycomRow } from "./CategorycomRow";

export namespace CategorycomService {
    export const baseUrl = 'souqcom/Categorycom';

    export declare function Create(request: SaveRequest<CategorycomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CategorycomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CategorycomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CategorycomRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CategorycomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CategorycomRow>>;

    export const Methods = {
        Create: "souqcom/Categorycom/Create",
        Update: "souqcom/Categorycom/Update",
        Delete: "souqcom/Categorycom/Delete",
        Retrieve: "souqcom/Categorycom/Retrieve",
        List: "souqcom/Categorycom/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CategorycomService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}