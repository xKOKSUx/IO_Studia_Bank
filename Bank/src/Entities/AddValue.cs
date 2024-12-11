namespace Bank.src.Entities
{
    public class AddValue
    {
        public int Value { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public AddValue(int value, string description, DateTime date)
        {
            Value = value;
            Description = description;
            Date = date;
        }
    }
}
