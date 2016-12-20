using EPiServer.Core;

namespace KampanjSidan.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
