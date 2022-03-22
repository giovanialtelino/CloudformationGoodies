namespace CloudformationGoodies.Shared.Model
{
    public record Enviroment
    {
        public Guid EnviromentId { get; set; }
        public string EnviromentName { get; set; }
        public string Parameters { get; set;     }
    }
}
