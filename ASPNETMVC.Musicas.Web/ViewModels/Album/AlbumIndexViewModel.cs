using System.ComponentModel.DataAnnotations;

namespace ASPNETMVC.Musicas.Web.ViewModels.Album
{
    public class AlbumExibicaoViewModel
    {
        public int Id { get; set; }

        [Display(Name ="Nome do Album")]
        public string Nome { get; set; }

        [Display(Name = "Ano do Album")]
        public int Ano { get; set; }

        [Display(Name ="Observações")]
        public string Observacoes { get; set; }

        [Display(Name ="Email de contato")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}