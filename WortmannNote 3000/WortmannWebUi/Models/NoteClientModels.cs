namespace WortmannWebUi.Models
{
    public class NoteClientModels
    {
        public string id { get; set; }
        public string header { get; set; }
        public string content { get; set; }
        public DateTime posted { get; set; }
        public object user { get; set; }
        public string userId { get; set; }
    }
}
