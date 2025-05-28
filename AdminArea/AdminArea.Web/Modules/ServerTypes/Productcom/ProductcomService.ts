import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ProductcomRow } from "./ProductcomRow";

export namespace ProductcomService {
    export const baseUrl = 'Productcom/Productcom';

    export declare function Create(request: SaveRequest<ProductcomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ProductcomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProductcomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ProductcomRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProductcomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ProductcomRow>>;

    export const Methods = {
        Create: "Productcom/Productcom/Create",
        Update: "Productcom/Productcom/Update",
        Delete: "Productcom/Productcom/Delete",
        Retrieve: "Productcom/Productcom/Retrieve",
        List: "Productcom/Productcom/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ProductcomService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}