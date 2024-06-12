namespace Cinema.Data.Entities;
public class VenueOperatingHour
{
    /// <summary>
    /// Identificador único da regra de horário.
    /// </summary>
    public int VenueOperatingHoursId { get; set; }

    /// <summary>
    /// Identificador da unidade (venue) a que essa regra se aplica.
    /// </summary>
    public int VenueId { get; set; }

    public Venue Venue { get; set; }

    /// <summary>
    /// Horário da primeira sessão.
    /// </summary>
    public TimeOnly FirstSessionTime { get; set; }

    /// <summary>
    /// Horário da última sessão.
    /// </summary>
    public TimeOnly LastSessionTime { get; set; }

    /// <summary>
    /// Intervalo entre as sessões em minutos.
    /// </summary>
    public short IntervalMinutes { get; set; }

    /// <summary>
    /// Tipo de valor (0 = padrão, 1 = número do dia da semana, 2 = data específica).
    /// </summary>
    public OperatingHourType Type { get; set; }

    /// <summary>
    /// Valor genérico que depende do tipo (pode ser um texto, um número do dia da semana, ou uma data específica).
    /// </summary>
    public string? Value { get; set; }
}

public enum OperatingHourType
{
    Default,
    DayOfWeek,
    SpecificDate
}
