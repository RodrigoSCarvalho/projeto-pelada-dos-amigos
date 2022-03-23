using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Proj_Pelada_Dos_Amigos.Models
{
    public class Jogador
    {

        public int Id { get; set; }

        public string Nome { get; set; }

        public Pote Pote { get; set; }

        public Time Time { get; set; }
    }
}
