namespace Infrastructure.Observability.ViewModels;
public class ProcessViewModel
{
    [Nest.PropertyName("name")]
    public string? ApplicationName { get; set; }
}
