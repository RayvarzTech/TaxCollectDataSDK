namespace TaxCollectData.Library.Dto.Content;

public record InvoiceHeaderDto
{
    /**
     * taxId
     */
    public string Taxid { get; init; }

    /**
     * invoiceDateTime
     */
    public long? Indatim { get; init; }

    /**
     * invoiceDateTimeGregorian
     */
    public long? Indati2m { get; init; }

    /**
     * invoiceType
     */
    public int? Inty { get; init; }

    /**
     * invoiceNumber
     */
    public string Inno { get; init; }

    /**
     * invoiceReferenceTaxId
     */
    public string Irtaxid { get; init; }

    /**
     * invoicePattern
     */
    public int? Inp { get; init; }

    /**
     * invoiceSubject
     */
    public int? Ins { get; init; }

    /**
     * sellerTaxIdentificationNumber
     */
    public string Tins { get; init; }

    /**
     * typeOfBuyer
     */
    public int? Tob { get; init; }

    /**
     * buyerId
     */
    public string Bid { get; init; }

    /**
     * buyerTaxIdentificationNumber
     */
    public string Tinb { get; init; }

    /**
     * sellerBranchCode
     */
    public string Sbc { get; init; }

    /**
     * buyerPostalCode
     */
    public string Bpc { get; init; }

    /**
     * buyerBranchCode
     */
    public string Bbc { get; init; }

    /**
     * flightType
     */
    public int? Ft { get; init; }

    /**
     * buyerPassportNumber
     */
    public string Bpn { get; init; }

    /**
     * sellerCustomsLicenceNumber
     */
    public string Scln { get; init; }

    /**
     * sellerCustomsCode
     */
    public string Scc { get; init; }

    /**
     * contractRegistrationNumber
     */
    public string Crn { get; init; }

    /**
     * billingId
     */
    public string Billid { get; init; }

    /**
     * totalPreDiscount
     */
    public decimal? Tprdis { get; init; }

    /**
     * totalDiscount
     */
    public decimal? Tdis { get; init; }

    /**
     * totalAfterDiscount
     */
    public decimal? Tadis { get; init; }

    /**
     * totalVatAmount
     */
    public decimal? Tvam { get; init; }

    /**
     * totalOtherDutyAmount
     */
    public decimal? Todam { get; init; }

    /**
     * totalBill
     */
    public decimal? Tbill { get; init; }

    /**
     * settlementType
     */
    public int? Setm { get; init; }

    /**
     * cashPayment
     */
    public decimal? Cap { get; init; }

    /**
     * installmentPayment
     */
    public decimal? Insp { get; init; }

    /**
     * totalVatOfPayment
     */
    public decimal? Tvop { get; init; }

    /**
     * tax17
     */
    public decimal? Tax17 { get; init; }

    // Export Fields

    /**
     * شماره کوتاژ اظهارنامه گمرکی
     */
    public string Cdcn { get; init; }

    /**
     * تاریخ کوتاژ اظهارنامه گمرکی
     */
    public int? Cdcd { get; init; }

    /**
     * مجموع وزن خالص
     */
    public decimal? Tonw { get; init; }

    /**
     * مجموع ارزش ریالی
     */
    public decimal? Torv { get; init; }

    /**
     * مجموع ارزش ارزی
     */
    public decimal? Tocv { get; init; }

    /**
     * شماره اقتصادی آژانس
     */
    public string? Tinc { get; init; }

    /**
     * شماره بارنامه
     */
    public string? Lno { get; init; }

    /**
     * شماره بارنامه مرجع
     */
    public string? Lrno { get; init; }

    /**
     * کشور مبدا
     */
    public string? Ocu { get; init; }

    /**
     * شهر مبدا
     */
    public string? Oci { get; init; }

    /**
     * کشور مقصد
     */
    public string? Dco { get; init; }

    /**
     * شهر مقصد
     */
    public string? Dci { get; init; }

    /**
     * شناسه ملی/شماره ملی/ شناسه مشارکت مدنی/ کد فراگیر اتباع غیر ایرانی گیرنده
     */
    public string? Tid { get; init; }

    /**
     * شناسه ملی/شماره ملی/ شناسه مشارکت مدنی/ کد فراگیر اتباع غیر ایرانی گیرنده
     */
    public string? Rid { get; init; }

    /**
     * نوع بارنامه/نوع حمل
     */
    public byte? Lt { get; init; }

    /**
     * شماره ناوگان
     */
    public string? Cno { get; init; }

    /**
     * شناسه ملی/شماره ملی/ شناسه مشارکت مدنی/ کد فراگیر اتباع غیر ایرانی راننده (در حمل و نقل جاده ای)
     */
    public string? Did { get; init; }

    /**
     * کالاهای حمل شده
     */
    public List<ShippingGoodDto>? Sg { get; init; }

    /**
     * شماره اعلامیه فروش
     */
    public string? Asn { get; init; }

    /**
     * تاریخ اعلامیه فروش
     */
    public int? Asd { get; init; }

    /**
     * شناسه یکتای بیمه نامه
     */
    public string? In { get; init; }

    /**
     * شناسه یکتای الحاقیه
     */
    public string? An { get; init; }
}