using AutoMapper;
using ChatApp.Application.ViewModel;
using ChatApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApp.Application.AutoMapper
{
   public class DomainToViewModelMappingprofile:Profile
    {
        public DomainToViewModelMappingprofile() {

            CreateMap<AppUser, AppUserViewModel>();
        }
    }
}
