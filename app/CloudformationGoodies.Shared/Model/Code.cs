namespace CloudformationGoodies.Shared.Model
{
    public record Code
    {
        public Guid Id { get; set; }
        public string Type => "YAML"; // just in case someone someday would bother with JSON
        public string Text { get; set; }
    }
}
