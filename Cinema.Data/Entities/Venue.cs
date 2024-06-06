using System.ComponentModel.DataAnnotations;

namespace Cinema.Data.Entities;

public class Venue
{
    /// <summary>
    /// Identificador único da localização do cinema.
    /// </summary>
    public int VenueId { get; set; }

    /// <summary>
    /// Nome da localização do cinema.
    /// </summary>
    [StringLength(150)]
    [Required]
    public string? Name { get; set; }

    /// <summary>
    /// Indica se a localização está ativa.
    /// </summary>
    [Required]
    public bool Active { get; set; }

    /// <summary>
    /// CEP (Código de Endereçamento Postal) da localização do cinema.
    /// </summary>
    [StringLength(8)]
    [Required]
    public string? ZipCode { get; set; }

    /// <summary>
    /// Estado onde a localização está situada.
    /// </summary>
    [StringLength(2)]
    [Required]
    public string? State { get; set; }

    /// <summary>
    /// Cidade onde a localização está situada.
    /// </summary>
    [StringLength(150)]
    [Required]
    public string? City { get; set; }

    /// <summary>
    /// Nome da rua da localização do cinema.
    /// </summary>
    [StringLength(250)]
    [Required]
    public string? Street { get; set; }

    /// <summary>
    /// Número do endereço da localização do cinema.
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// Complemento do endereço da localização do cinema.
    /// </summary>
    [StringLength(150)]
    public string? Complement { get; set; }

    public Venue()
    {
        
    }

    public Venue(string? name, bool active, string? zipCode, string? state, string? city, string? street, string? number, string? complement)
    {
        Name = name;
        Active = active;
        ZipCode = zipCode;
        State = state;
        City = city;
        Street = street;
        Number = number;
        Complement = complement;
    }
}
