using ASPNETMVC.Musicas.Dominio;
using ASPNETMVC.Musicas.Web.ViewModels.Album;
using AutoMapper;

namespace ASPNETMVC.Musicas.Web.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        public ViewModelParaDominioProfile()
        {
            CreateMap<AlbumViewModel , Album>();
        }
    }
}