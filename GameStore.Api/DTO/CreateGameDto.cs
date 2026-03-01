namespace GameStore.Api.DTO;

public record CreateGameDto
(
    string name,
    string Genre,
    decimal price,
    DateOnly ReleaseDate
);