namespace TaxCollectData.Library.Dto.Content;

public class Article6StatusDto
{
    public Article6StatusDto(string economicCode, long vatValue, int period)
    {
        EconomicCode = economicCode;
        VatValue = vatValue;
        Period = period;
    }

    public string EconomicCode { get; set; }
    public long VatValue { get; set; }
    public int Period { get; set; }
}