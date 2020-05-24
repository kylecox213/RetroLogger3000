using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RetroLogger3000.Models
{

    public class GameConsole
    {
        public int ID { get; set; }

        [StringLength(25, ErrorMessage = "Console type cannot exceed 25 characters.")]
        [Required]
        public string Type { get; set; }

        [StringLength(25, ErrorMessage = "Model type cannot exceed 25 characters.")]
        public string Model { get; set; }

        public bool Functional { get; set; }

        public int GameID { get; set; }
        public int GamePadID { get; set; }

        public virtual ICollection<Game> Games { get; set; }
        public virtual ICollection<GamePad> GamePads { get; set; }
        public virtual ICollection<Adapter> Adapters { get; set; }
        public virtual ICollection<Cable> Cables { get; set; }
    }
}