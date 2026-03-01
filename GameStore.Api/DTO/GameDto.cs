namespace GameStore.Api.DTO;

public record class GameDto
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? Genre { get; init; }
    public decimal Price { get; init; }
    public DateOnly ReleaseDate { get; init; }
};
