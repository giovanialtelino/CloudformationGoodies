namespace CloudformationGoodies.Shared.Model
{
    public record Stack
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<StackComponent> Components { get; set; }
    }
}
