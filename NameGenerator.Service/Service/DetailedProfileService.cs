using NameGenerator.Migrations;
using NameGenerator.Model.Entity;
using NameGenerator.Model.ViewModel;
using NameGenerator.Service.Interface;
using System;
using System.Linq;

namespace NameGenerator.Service.Service
{
    public class DetailedProfileService: IDetailedProfileService
    {
        private readonly NameGeneratorDbContext _context;
        public DetailedProfileService(NameGeneratorDbContext context)
        {
            _context = context;
        }
        public BaseResponseViewModel GenerateProfile(BasicProfileDetailsRequestViewModel model)
        {
            var profile = _context.DetailedProfiles.ToList().FirstOrDefault(x => x.FirstName == model.FirstName);
            if (profile == null)
            {
                var request = new DetailedProfile();

                request.Id = Guid.NewGuid();
                request.FirstName = model.FirstName;
                request.LastName = model.LastName;
                request.DateOfBirth = model.DateOfBirth;
                request.Gender = model.Gender;
                request.DateCreated = DateTime.Now;


                _context.DetailedProfiles.Add(request);
                _context.SaveChanges();
                return new BaseResponseViewModel { Status = true, Message = "Profile Generated" };
            }
            return new BaseResponseViewModel { Status = false, Message = "Profile Already Exists" };
        }

        public BasicProfileDetailsResponseViewModel SearchById(Guid id)
        {

            var profile = _context.DetailedProfiles.ToList().FirstOrDefault(x => x.Id == id);
            if (profile == null) return null;

            var response = new BasicProfileDetailsResponseViewModel();

            response.Id = profile.Id;
            response.FirstName = profile.FirstName;
            response.LastName = profile.LastName;
            response.Gender = profile.Gender;
            response.DateOfBirth = profile.DateOfBirth;

            return response;

        }
        public BaseResponseViewModel UpdateProfile(ProfileDetailsUpdateRequestViewModel model)
        {
            var profile = _context.DetailedProfiles.ToList().FirstOrDefault(x => x.Id == model.Id);
            if (profile != null)
            {
                var response = new ProfileDetailsUpdateRequestViewModel();

                response.FirstName = model.FirstName;
                response.LastName = model.LastName;

                _context.DetailedProfiles.Update(profile);
                _context.SaveChanges();
                return new BaseResponseViewModel { Status = true, Message = "Profile updated successfully" };
            }
            return new BaseResponseViewModel { Status = false, Message = "Profile does not exists!" };

        }
        public BaseResponseViewModel DeleteProfile(Guid id)
        {
            var profile = _context.DetailedProfiles.ToList().FirstToDefault(x => x.Id == id);
            if (profile != null)
            {

                _context.DetailedProfiles.Remove(profile);
                _context.SaveChanges();

                return new BaseResponseViewModel { Status = true, Message = "Profile deleted successfully" };
            }
            return new BaseResponseViewModel { Status = false, Message = "Profile does not exist!" };
        }
    }
}
