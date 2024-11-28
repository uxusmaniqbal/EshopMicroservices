namespace Ordering.Application.Dtos;
public record PaymentDto(
    string CardNumber,
    string Cvv,
    string CardName,
    string Expiration,
    int PaymentMethod
    );

