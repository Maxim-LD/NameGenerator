using NameGenerator.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator.Service.Interface
{
    public interface IDetailedProfileService
    {
        public BasicProfileDetailsResponseViewModel GeneratedProfile(BasicProfileDetailsRequestViewModel model);
    }
}
