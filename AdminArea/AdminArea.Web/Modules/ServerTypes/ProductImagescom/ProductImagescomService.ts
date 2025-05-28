import { SaveRequest, SaveResponse, ServiceOptions, DeleteRequest, DeleteResponse, RetrieveRequest, RetrieveResponse, ListRequest, ListResponse, serviceRequest } from "@serenity-is/corelib";
import { ProductImagescomRow } from "./ProductImagescomRow";

export namespace ProductImagescomService {
    export const baseUrl = 'ProductImagescom/ProductImagescom';

    export declare function Create(request: SaveRequest<ProductImagescomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ProductImagescomRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProductImagescomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ProductImagescomRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProductImagescomRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ProductImagescomRow>>;

    export const Methods = {
        Create: "ProductImagescom/ProductImagescom/Create",
        Update: "ProductImagescom/ProductImagescom/Update",
        Delete: "ProductImagescom/ProductImagescom/Delete",
        Retrieve: "ProductImagescom/ProductImagescom/Retrieve",
        List: "ProductImagescom/ProductImagescom/List"
    } as const;

    [
        'Create', 
        'Update', 
        'Delete', 
        'Retrieve', 
        'List'
    ].forEach(x => {
        (<any>ProductImagescomService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}