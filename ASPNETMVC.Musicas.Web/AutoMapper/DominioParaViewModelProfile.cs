using ASPNETMVC.Musicas.Dominio;
using ASPNETMVC.Musicas.Web.ViewModels.Album;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETMVC.Musicas.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        public DominioParaViewModelProfile()
        {
            CreateMap<Album , AlbumExibicaoViewModel>();
            CreateMap<Album , AlbumViewModel>();
        }
    }
}