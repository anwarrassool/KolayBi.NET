using System.Net;
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
using Newtonsoft.Json;
using RestEase;
using Stef.Validation;

namespace KolayBi.Net.Client;

// ReSharper disable once InconsistentNaming
public static class IKolayBiApiExtensions
{
    private const int WaitTimeInSeconds = 3;

    #region Token

    public static async Task<TokenResponse> GetAccessToken(this IKolayBiApi api, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.GetTokens(cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new TokenResponse();
            },
            cancellationToken
        );

    }

    #endregion predictions

    #region associates

    public static async Task<AssociateDetailResponse> ListAssociates(this IKolayBiApi api, GetAssociateRequest request, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.ListAssociates(request, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new AssociateDetailResponse();
            },
            cancellationToken
        );
    }

    public static async Task<CreateAssociateResponse> CreateAssociates(this IKolayBiApi api, Dictionary<string, object> createAssociateRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.CreateAssociates(createAssociateRequest, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new CreateAssociateResponse();
            },
            cancellationToken
        );
    }

    public static async Task<AssociateDetailResponse> GetAssociateDetail(this IKolayBiApi api, string associate_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.GetAssociateDetail(associate_id, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new AssociateDetailResponse();
                },
                cancellationToken
        );
       // return await api.GetAssociateDetail(associate_id, cancellationToken);

    }

    public static async Task<CreateAdressResponse> CreateAdress(this IKolayBiApi api, Dictionary<string, object> createAdressRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.CreateAdress(createAdressRequest, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new CreateAdressResponse();
                },
                cancellationToken
        );
        //return await api.CreateAdress(request, cancellationToken);

    }

    #endregion associates

    #region products

    public static async Task<ProductDetailResponse> ListProducts(this IKolayBiApi api, GetProductRequest request, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);


        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.ListProducts(request, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new ProductDetailResponse();
                },
                cancellationToken
        );

        //return await api.ListProducts(request, cancellationToken);

    }

    public static async Task<CreateProductResponse> CreateProduct(this IKolayBiApi api, Dictionary<string, object> createProductRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
                timeoutInSeconds,
                async ct => await api.CreateProduct(createProductRequest, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new CreateProductResponse();
                },
                cancellationToken
        );
    }

    public static async Task<ProductDetailResponse> GetProductDetail(this IKolayBiApi api, string product_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.GetProductDetail(product_id, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new ProductDetailResponse();
                },
                cancellationToken
        );
    }

    public static async Task<CreateProductStockResponse> CreateProductStock(this IKolayBiApi api, Dictionary<string, object> createProductStockRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.CreateProductStock(createProductStockRequest, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new CreateProductStockResponse();
                },
                cancellationToken
        );
    }

    public static async Task<UpdateProductResponse> UpdateProduct(this IKolayBiApi api, [Path] string product_id, Dictionary<string, object> updateProductRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);
        return await CallAsync(
                timeoutInSeconds,
                    async ct => await api.UpdateProduct(product_id, updateProductRequest, cancellationToken).ConfigureAwait(false),
                    async ct => {
                        await Task.CompletedTask;
                        return new UpdateProductResponse();
                    },
                    cancellationToken
            );

    }

    #endregion products

    #region tags

    public static async Task<TagsDetailResponse> ListTags(this IKolayBiApi api, GetTagsRequest request, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.ListTags(request, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new TagsDetailResponse();
                },
                cancellationToken
        );
    }

    public static async Task<TagsDetailResponse> GetTagsDetail(this IKolayBiApi api, string tag_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.GetTagsDetail(tag_id, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new TagsDetailResponse();
                },
                cancellationToken
        );
    }

    #endregion tags

    #region vaults

    public static async Task<VaultsDetailResponse> ListVaults(this IKolayBiApi api, GetVaultsRequest request, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.ListVaults(request, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new VaultsDetailResponse();
                },
                cancellationToken
        );
    }

    public static async Task<VaultsDetailResponse> GetVaultsDetail(this IKolayBiApi api, string vault_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.GetVaultsDetail(vault_id, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new VaultsDetailResponse();
                },
                cancellationToken
        );
    }

    #endregion vaults

    #region invoices

    public static async Task<CreateInvoiceResponse> CreateInvoice(this IKolayBiApi api, Dictionary<string, object> createInvoiceRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
                async ct => await api.CreateInvoice(createInvoiceRequest, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new CreateInvoiceResponse();
                },
                cancellationToken
        );
    }

    public static async Task<CreateEDocumentResponse> CreateEDocument(this IKolayBiApi api, Dictionary<string, object> createEDocumentRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
                timeoutInSeconds,
                async ct => await api.CreateEDocument(createEDocumentRequest, cancellationToken).ConfigureAwait(false),
                async ct => {
                    await Task.CompletedTask;
                    return new CreateEDocumentResponse();
                },
                cancellationToken
        );

    }

    public static async Task<InvoiceDetailResponse> GetInvoiceDetail(this IKolayBiApi api, string document_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);
        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.GetInvoiceDetail(document_id, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new InvoiceDetailResponse();
            },
            cancellationToken
        );
    }

    public static async Task<object> DeleteInvoice(this IKolayBiApi api, string document_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);
        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.DeleteInvoice(document_id, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new object();
            },
            cancellationToken
        );

    }

    public static async Task<ProceedInvoiceResponse> ProceedInvoice(this IKolayBiApi api, string document_id, string vault_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.ProceedInvoice(document_id, vault_id, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new ProceedInvoiceResponse();
            },
            cancellationToken
        );
    }

    public static async Task<object> DeleteProceedInvoice(this IKolayBiApi api, string document_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.DeleteProceedInvoice(document_id, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new object();
            },
            cancellationToken
        );
    }

    public static async Task<object> CancelEDocument(this IKolayBiApi api, Dictionary<string, object> cancelEDocumentRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.CancelEDocument(cancelEDocumentRequest, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new object();
            },
            cancellationToken
        );
    }

    public static async Task<ViewInvoiceResponse> ViewEDocument(this IKolayBiApi api, string uuid, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);
        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.ViewEDocument(uuid, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new ViewInvoiceResponse();
            },
            cancellationToken
        );
    }

    public static async Task<ResendInvoiceResponse> ResendInvoice(this IKolayBiApi api, string document_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);
        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.ResendInvoice(document_id, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new ResendInvoiceResponse();
            },
            cancellationToken
        );
    }

    #endregion invoices

    #region orders

    public static async Task<OrdersDetailResponse> GetOrders(this IKolayBiApi api, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.GetOrders(cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new OrdersDetailResponse();
            },
            cancellationToken
        );


    }

    public static async Task<CreateOrdersResponse> CreateOrders(this IKolayBiApi api, Dictionary<string, object> createOrdersRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);
        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.CreateOrders(createOrdersRequest, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new CreateOrdersResponse();
            },
            cancellationToken
        );
        //return await api.CreateOrders(createOrdersRequest, cancellationToken);

    }

    public static async Task<OrdersDetailResponse> GetOrdersDetail(this IKolayBiApi api, string document_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);

        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.GetOrdersDetail(document_id, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new OrdersDetailResponse();
            },
            cancellationToken
        );

        //return await api.GetOrdersDetail(document_id, cancellationToken);
    }

    public static async Task<ProFormasOrdersDetailResponse> GetProFomarsOrders(this IKolayBiApi api, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);
        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.GetProFomarsOrders(cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new ProFormasOrdersDetailResponse();
            },
            cancellationToken
        );
        //return await api.GetProFomarsOrders(cancellationToken);

    }

    public static async Task<CreateProFormasOrdersResponse> CreateProFomarsOrders(this IKolayBiApi api, Dictionary<string, object> createProFormasOrdersRequest, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);
        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.CreateProFomarsOrders(createProFormasOrdersRequest, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new CreateProFormasOrdersResponse();
            },
            cancellationToken
        );
        //return await api.CreateProFomarsOrders(createProFormasOrdersRequest, cancellationToken);

    }

    public static async Task<ProFormasOrdersDetailResponse> GetProFomarsOrdersDetail(this IKolayBiApi api, string document_id, int timeoutInSeconds = 5 * 60, CancellationToken cancellationToken = default)
    {
        Guard.NotNull(api);
        return await CallAsync(
            timeoutInSeconds,
            async ct => await api.GetProFomarsOrdersDetail(document_id, cancellationToken).ConfigureAwait(false),
            async ct => {
                await Task.CompletedTask;
                return new ProFormasOrdersDetailResponse();
            },
            cancellationToken
        );

    }
    #endregion products

    internal static async Task<T> CallAsync<T>(
        int timeoutInSeconds,
        Func<CancellationToken, Task<T>> checkAsync,
        Func<CancellationToken, Task<T>> cancelAsync,
        CancellationToken cancellationToken)
    {
        var timeoutCancellationSource = new CancellationTokenSource();
        timeoutCancellationSource.CancelAfter(timeoutInSeconds * 1000);

        try
        {
            var cancellation = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutCancellationSource.Token);

            var response = await checkAsync(cancellation.Token).ConfigureAwait(false);

            return response;
        }
        catch (TaskCanceledException)
        {
            try
            {
                timeoutCancellationSource = new CancellationTokenSource();
                timeoutCancellationSource.CancelAfter(1000);
                await cancelAsync(timeoutCancellationSource.Token);
            }
            catch
            {
            }

            throw;
        }
        catch (ApiException error)
        {
            if (error.StatusCode == HttpStatusCode.OK || error.StatusCode == HttpStatusCode.Created)
            {
                return JsonConvert.DeserializeObject<T>(error.Content);
            }
            else
            {
                return JsonConvert.DeserializeObject<T>(error.Content);
            }
        }
    }


    //public static async Task<IReadOnlyList<ModelVersion>?> GetAllModelVersionsAsync(this IReplicateApi api, string owner, string name, CancellationToken cancellationToken = default)
    //{
    //    Guard.NotNull(api);

    //    return await PageAsync
    //    (
    //        async () => await api.GetModelVersionsAsync(owner, name, cancellationToken).ConfigureAwait(false),
    //        async url => await api.GetModelVersionsByUrlAsync(url, cancellationToken).ConfigureAwait(false)
    //    );
    //}

    //private static async Task<IReadOnlyList<T>?> PageAsync<T>(Func<Task<PagedResult<T>>> getAsync, Func<string, Task<PagedResult<T>>> nextAsync)
    //{
    //    var predictionsResult = await getAsync().ConfigureAwait(false);
    //    if (predictionsResult.Results is null)
    //    {
    //        return null;
    //    }

    //    var results = predictionsResult.Results.ToList();
    //    while (predictionsResult.Next is not null)
    //    {
    //        predictionsResult = await nextAsync(predictionsResult.Next).ConfigureAwait(false);
    //        if (predictionsResult.Results is null)
    //        {
    //            break;
    //        }

    //        results.AddRange(predictionsResult.Results);
    //    }

    //    return results;
    //}
}


