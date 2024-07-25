namespace Front.NovaPasta1
{
    public class Servico
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public double price { get; set; }
        public double discountPercentage { get; set; }
        public double rating { get; set; }
        public int stock { get; set; }
        public List<string> tags { get; set; }
        public string brand { get; set; }
        public string sku { get; set; }
        public int weight { get; set; }
    

    }
}
