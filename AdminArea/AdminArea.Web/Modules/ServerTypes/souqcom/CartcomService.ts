import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { CartcomRow } from "./CartcomRow";

export namespace CartcomService {
    export const baseUrl = 'souqcom/Cartcom';

    export declare function Create(request: SaveRequest<CartcomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<CartcomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<CartcomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<CartcomRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<CartcomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<CartcomRow>>;

    export const Methods = {
        Create: "souqcom/Cartcom/Create",
        Update: "souqcom/Cartcom/Update",
        Delete: "souqcom/Cartcom/Delete",
        Retrieve: "souqcom/Cartcom/Retrieve",
        List: "souqcom/Cartcom/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>CartcomService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}