namespace Remp.Models.Entities;

public class AgentPhotographyCompany
{
    public string AgentId { get; set; } = string.Empty;
    public Agent Agent { get; set; } = null!;
    public string PhotographyCompanyId { get; set; } = string.Empty;
    public PhotographyCompany PhotographyCompany { get; set; } = null!;
}
