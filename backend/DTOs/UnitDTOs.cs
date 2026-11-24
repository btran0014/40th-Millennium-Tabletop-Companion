namespace backend.DTOs
{
    public record UnitResponseDTO(int Id, string Name, int UnitCount);
    public record CreateUnitDTO(string Name);
}