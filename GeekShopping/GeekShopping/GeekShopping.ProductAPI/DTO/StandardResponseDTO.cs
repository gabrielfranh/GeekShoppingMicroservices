namespace GeekShopping.ProductAPI.DTO
{
    public class StandardResponseDTO
    {
        string ErrorMessage { get; set; }
        bool IsSucess { get; set; }
        object? Return { get; set; }
    }
}
