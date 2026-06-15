using Microsoft.Extensions.DependencyInjection;
using TaxCollectData.Library.Abstraction;
using TaxCollectData.Library.Abstraction.Signatory;
using TaxCollectData.Library.Dto.Config;
using TaxCollectData.Library.Exceptions;
using TaxCollectData.Library.Extensions;

namespace TaxCollectData.Library.Business;

public class TaxApiService
{
    private const string BASE_URL = "http://master.nta.local/requestsmanager/api/";

    private static readonly EncryptionConfig _defaultEncryptionConfig = new(
        taxOrgPublicKey: "MIICIjANBgkqhkiG9w0BAQEFAAOCAg8AMIICCgKCAgEAxdzREOEfk3vBQogDPGTMqdDQ7t0oDhuKMZkA+Wm1lhzjjhAGfSUOuDvOKRoUEQwP8oUcXRmYzcvCUgcfoRT5iz7HbovqH+bIeJwT4rmLmFcbfPke+E3DLUxOtIZifEXrKXWgSVPkRnhMgym6UiAtnzwA1rmKstJoWpk9Nv34CYgTk8DKQN5jQJqb9L/Ng0zOEEtI3zA424tsd9zv/kP4/SaSnbbnj0evqsZ29X6aBypvnTnwH9t3gbWM4I9eAVQhPYClawHTqvdaz/O/feqfm06QBFnCgL+CBdjLs30xQSLsPICjnlV1jMzoTZnAabWP6FRzzj6C2sxw9a/WwlXrKn3gldZ7Ctv6Jso72cEeCeUI1tzHMDJPU3Qy12RQzaXujpMhCz1DVa47RvqiumpTNyK9HfFIdhgoupFkxT14XLDl65S55MF6HuQvo/RHSbBJ93FQ+2/x/Q2MNGB3BXOjNwM2pj3ojbDv3pj9CHzvaYQUYM1yOcFmIJqJ72uvVf9Jx9iTObaNNF6pl52ADmh85GTAH1hz+4pR/E9IAXUIl/YiUneYu0G4tiDY4ZXykYNknNfhSgxmn/gPHT+7kL31nyxgjiEEhK0B0vagWvdRCNJSNGWpLtlq4FlCWTAnPI5ctiFgq925e+sySjNaORCoHraBXNEwyiHT2hu5ZipIW2cCAwEAAQ==",
        encryptionKeyId: "6a2bcd88-a871-4245-a393-2843eafe6e02" 
    );
    private readonly IServiceCollection _serviceCollection = new ServiceCollection();
    private IServiceProvider _serviceProvider;
    
    public static TaxApiService Instance { get; set; } = new();
    private TaxApiService()
    {
    }
    
    private ITaxApis _taxApis;
    public ITaxApis TaxApis
    {
        get => _serviceProvider.GetService<ITaxApis>() ?? throw new NotInitializedException(nameof(_taxApis));
        private set => _taxApis = value;
    }

    private ITransferApi _transferApi;
    public ITransferApi TransferApi
    {
        get => _serviceProvider.GetService<ITransferApi>() ?? throw new NotInitializedException(nameof(_transferApi));
        private set => _transferApi = value;
    }
    
    private ITaxIdGenerator _taxIdGenerator;
    public ITaxIdGenerator TaxIdGenerator
    {
        get => _serviceProvider.GetService<ITaxIdGenerator>() ?? throw new NotInitializedException(nameof(_taxIdGenerator));
        private set => _taxIdGenerator = value;
    }

    public void Init(string clientId,
        SignatoryConfig transferSignatoryConfig,
        IProperties properties,
        string baseUrl = BASE_URL,
        EncryptionConfig encryptionConfig = null,
        SignatoryConfig? contentSignatoryConfig = null)
    {
        _serviceCollection.Clear();
        _serviceCollection.AddTaxApi(baseUrl,
            clientId,
            properties,
            transferSignatoryConfig,
            contentSignatoryConfig,
            encryptionConfig ?? _defaultEncryptionConfig);
        _serviceProvider = _serviceCollection.BuildServiceProvider();
    }
    
    public void Init(string clientId,
        Pkcs8SignatoryConfig transferSignatoryConfig,
        IProperties properties,
        string baseUrl = BASE_URL,
        EncryptionConfig encryptionConfig = null,
        Pkcs8SignatoryConfig? contentSignatoryConfig = null)
    {
        _serviceCollection.Clear();
        _serviceCollection.AddTaxApi(baseUrl,
            clientId,
            properties,
            transferSignatoryConfig,
            contentSignatoryConfig,
            encryptionConfig ?? _defaultEncryptionConfig);
        _serviceProvider = _serviceCollection.BuildServiceProvider();
    }
    
    public void Init(string clientId,
        Pkcs11SignatoryConfig transferSignatoryConfig,
        IProperties properties,
        string baseUrl = BASE_URL,
        EncryptionConfig encryptionConfig = null,
        Pkcs11SignatoryConfig? contentSignatoryConfig = null)
    {
        _serviceCollection.Clear();
        _serviceCollection.AddTaxApi(baseUrl,
            clientId,
            properties,
            transferSignatoryConfig,
            contentSignatoryConfig,
            encryptionConfig ?? _defaultEncryptionConfig);
        _serviceProvider = _serviceCollection.BuildServiceProvider();
    }
    
    public void Init<TTransferSignatory>(string clientId,
        IProperties properties,
        string baseUrl = BASE_URL,
        EncryptionConfig encryptionConfig = null) where TTransferSignatory : class, ISignatory, ITransferSignatory, IContentSignatory
    {
        _serviceCollection.Clear();
        _serviceCollection.AddTaxApi<TTransferSignatory>(baseUrl,
            clientId,
            properties,
            encryptionConfig ?? _defaultEncryptionConfig);
        _serviceProvider = _serviceCollection.BuildServiceProvider();
    }
    public void Init<TTransferSignatory, TContentSignatory>(string clientId,
        IProperties properties,
        string baseUrl = BASE_URL,
        EncryptionConfig encryptionConfig = null)
        where TTransferSignatory : class, ITransferSignatory 
        where TContentSignatory : class, IContentSignatory
    {
        _serviceCollection.Clear();
        _serviceCollection.AddTaxApi<TTransferSignatory, TContentSignatory>(baseUrl,
            clientId,
            properties,
            encryptionConfig ?? _defaultEncryptionConfig);
        _serviceProvider = _serviceCollection.BuildServiceProvider();
    }
}