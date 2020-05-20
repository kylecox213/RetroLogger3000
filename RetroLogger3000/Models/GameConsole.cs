namespace RetroLogger3000.Models
{

    public class GameConsole
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public bool Functional { get; set; }
        public int GamePadID { get; set; }
        public int GameID { get; set; }

        public virtual GamePad GamePad { get; set; }
        public virtual Game Game { get; set; }
    }
}