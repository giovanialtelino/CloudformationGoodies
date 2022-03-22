namespace CloudformationGoodies.Shared.Model
{
    public record StackComponent
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Code Code { get; set; }
        public List<Enviroment> Enviroments { get; set; }
    }
}
