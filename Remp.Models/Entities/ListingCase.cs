using Remp.Models.Enums;

namespace Remp.Models.Entities;

public class ListingCase
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? Description { get; set; }
    public string Street { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Postcode { get; set; } = string.Empty;
    public string State { get; set; } = string.Empty;
    public decimal? Longitude { get; set; }
    public decimal? Latitude { get; set; }
    public double Price { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public int Garages { get; set; }
    public double FloorArea { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsDeleted { get; set; }
    public PropertyType PropertyType { get; set; }
    public SaleCategory SaleCategory { get; set; }
    public ListingCaseStatus ListingCaseStatus { get; set; } = ListingCaseStatus.Created;

    public string UserId { get; set; } = string.Empty;
    public User User { get; set; } = null!;
    public ICollection<CaseContact> CaseContacts { get; set; } = new List<CaseContact>();
    public ICollection<MediaAsset> MediaAssets { get; set; } = new List<MediaAsset>();
    public ICollection<AgentListingCase> AgentListingCases { get; set; } = new List<AgentListingCase>();
}
