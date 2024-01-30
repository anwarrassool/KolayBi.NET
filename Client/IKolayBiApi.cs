using KolayBi.Net.Constants;
using KolayBi.Net.Models;
using KolayBi.Net.Models.AssociateDetailResponse;
using KolayBi.Net.Models.CreateAdressResponse;
using KolayBi.Net.Models.CreateAssociateResponse;
using KolayBi.Net.Models.CreateOrdersResponse;
using KolayBi.Net.Models.CreateProductResponse;
using KolayBi.Net.Models.CreateProductStockResponse;
using KolayBi.Net.Models.CreateProFormasOrdersResponse;
using KolayBi.Net.Models.GetAssociateRequest;
using KolayBi.Net.Models.GetProductRequest;
using KolayBi.Net.Models.GetTagsRequest;
using KolayBi.Net.Models.GetVaultsRequest;
using KolayBi.Net.Models.InvoiceDetailResponse;
using KolayBi.Net.Models.OrdersDetailResponse;
using KolayBi.Net.Models.ProceedInvoiceResponse;
using KolayBi.Net.Models.ProductDetailResponse;
using KolayBi.Net.Models.ProFormasOrdersDetailResponse;
using KolayBi.Net.Models.ResendInvoiceResponse;
using KolayBi.Net.Models.TagsDetailResponse;
using KolayBi.Net.Models.UpdateProductResponse;
using KolayBi.Net.Models.VaultsDetailResponse;
using KolayBi.Net.Models.ViewInvoiceResponse;
using KolayBi.NET.Models.CreateEDocumentResponse;
using KolayBi.NET.Models.CreateInvoiceResponse;
using RestEase;

namespace KolayBi.Net.Client;

[Header(HeaderKey.Accept, HeaderValue.ApplicationJson)]
[Header(HeaderKey.ContentType, HeaderValue.FormData)]
[Header(HeaderKey.UserAgent, HeaderValue.UserAgent)]
public interface IKolayBiApi
{
    #region Token

    [Post("access_token")]
    Task<TokenResponse> GetTokens(CancellationToken cancellationToken = default);

    #endregion predictions

    #region associates

    [RequiresToken]
    [Get("associates")]
    Task<AssociateDetailResponse> ListAssociates([Query] GetAssociateRequest request, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Post("associates")]
    Task<CreateAssociateResponse> CreateAssociates([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> createAssociateRequest, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Get("associates/{associate_id}")]
    Task<AssociateDetailResponse> GetAssociateDetail([Path] string associate_id, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Post("address/create")]
    Task<CreateAdressResponse> CreateAdress([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> createAdressRequest, CancellationToken cancellationToken = default);

    #endregion associates

    #region products

    [RequiresToken]
    [Get("products")]
    Task<ProductDetailResponse> ListProducts([Query] GetProductRequest request, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Post("products")]
    Task<CreateProductResponse> CreateProduct([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> createProductRequest, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Get("products/{product_id}")]
    Task<ProductDetailResponse> GetProductDetail([Path] string product_id, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Post("products/stock_histories")]
    Task<CreateProductStockResponse> CreateProductStock([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> createProductStockRequest, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Put("products/{product_id}")]
    Task<UpdateProductResponse> UpdateProduct([Path] string product_id, [Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> updateProductRequest, CancellationToken cancellationToken = default);

    #endregion products

    #region tags

    [RequiresToken]
    [Get("tags")]
    Task<TagsDetailResponse> ListTags([Query] GetTagsRequest request, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Get("tags/{tag_id}")]
    Task<TagsDetailResponse> GetTagsDetail([Path] string tag_id, CancellationToken cancellationToken = default);

    #endregion tags

    #region vaults

    [RequiresToken]
    [Get("vaults")]
    Task<VaultsDetailResponse> ListVaults([Query] GetVaultsRequest request, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Get("vaults/{vault_id}")]
    Task<VaultsDetailResponse> GetVaultsDetail([Path] string vault_id, CancellationToken cancellationToken = default);

    #endregion vaults

    #region invoices

    [RequiresToken]
    [Post("invoices")]
    Task<CreateInvoiceResponse> CreateInvoice([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> createInvoiceRequest, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Post("invoices/e-document/create")]
    Task<CreateEDocumentResponse> CreateEDocument([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object>  createEDocumentRequest, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Get("invoices/{document_id}")]
    Task<InvoiceDetailResponse> GetInvoiceDetail([Path] string document_id, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Delete("invoices/{document_id}")]
    Task<object> DeleteInvoice([Path] string document_id, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Post("invoices/proceed")]
    Task<ProceedInvoiceResponse> ProceedInvoice([Query] string document_id, [Query] string vault_id,  CancellationToken cancellationToken = default);

    [RequiresToken]
    [Delete("invoices/proceed/{document_id}")]
    Task<object> DeleteProceedInvoice([Path] string document_id, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Post("invoices/e-document/cancel")]
    Task<object> CancelEDocument([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> cancelEDocumentRequest, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Delete("invoices/e-document/view")]
    Task<ViewInvoiceResponse> ViewEDocument([Query] string uuid, CancellationToken cancellationToken = default);

    [RequiresToken]
    [Post("invoices/resend/{document_id}")]
    Task<ResendInvoiceResponse> ResendInvoice([Path] string document_id, CancellationToken cancellationToken = default);

    #endregion invoices

    #region orders

    [Get("orders")]
    Task<OrdersDetailResponse> GetOrders(CancellationToken cancellationToken = default);

    [Post("orders")]
    Task<CreateOrdersResponse> CreateOrders([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> createOrdersRequest, CancellationToken cancellationToken = default);

    [Post("orders/{document_id}")]
    Task<OrdersDetailResponse> GetOrdersDetail([Path] string document_id, CancellationToken cancellationToken = default);

    [Get("proformas")]
    Task<ProFormasOrdersDetailResponse> GetProFomarsOrders(CancellationToken cancellationToken = default);

    [Post("proformas")]
    Task<CreateProFormasOrdersResponse> CreateProFomarsOrders([Body(BodySerializationMethod.UrlEncoded)] Dictionary<string, object> createProFormasOrdersRequest, CancellationToken cancellationToken = default);

    [Post("proformas/{document_id}")]
    Task<ProFormasOrdersDetailResponse> GetProFomarsOrdersDetail([Path] string document_id, CancellationToken cancellationToken = default);

    #endregion orders
}