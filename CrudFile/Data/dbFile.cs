namespace CrudFile.Data
{
    public class dbFile
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string dbFileName { get; set; }
    }
}
