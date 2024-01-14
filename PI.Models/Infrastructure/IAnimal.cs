namespace PI.Models.Infrastructure
{
    public interface IAnimal
    {
        public int Age { get; set; }
        public string Type { get; set; }
        public string KindOfAnimal { get; set; }
    }
}
