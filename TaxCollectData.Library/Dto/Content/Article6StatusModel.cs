namespace TaxCollectData.Library.Dto.Content;

public class Article6StatusModel
{
    public Article6StatusModel(bool article6RemainStatus)
    {
        Article6RemainStatus = article6RemainStatus;
    }

    public bool Article6RemainStatus { get; set; }
}