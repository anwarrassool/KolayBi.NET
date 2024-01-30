using KolayBi.Net.Interfaces;

namespace KolayBi.Net.Models;

public class Request
{
    /// <summary>
    /// The model's input.
    /// </summary>
    public IInput Input { get; set; } = null!;
}