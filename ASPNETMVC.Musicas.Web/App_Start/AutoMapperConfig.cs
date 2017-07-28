using ASPNETMVC.Musicas.Web.AutoMapper;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPNETMVC.Musicas.Web.App_Start
{
    public class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.Initialize( m =>
             {
                 m.AddProfile<DominioParaViewModelProfile>();
                 m.AddProfile<ViewModelParaDominioProfile>();
             }
            );
        }
    }
}