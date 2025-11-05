namespace DomainClasses.Base
{
    public record BaseModel
    {
        public Guid Id { get; set; }
    }

    public class BaseClass
    {
        public Guid Id { get; set; }
    }
}
