using NameGenerator.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace NameGenerator.Service.Interface
{
    public interface IDetailedProfileService
    {
        public BaseResponseViewModel GenerateProfile(BasicProfileDetailsRequestViewModel model);
        public BasicProfileDetailsResponseViewModel SearchById(Guid id);
        public BaseResponseViewModel UpdateProfile(ProfileDetailsUpdateRequestViewModel model);
        public BaseResponseViewModel DeleteProfile(Guid id);
    }
}
