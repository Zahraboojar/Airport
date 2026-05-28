using ManageAirportApp.DAL;
using ManageAirportApp.Domain;
using ManageAirportApp.Share;
using ManageAitportApp.DAL;
using ManageSchoolApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageAirportApp.Service
{
    public class SettingService : BaseService<Setting, SettingRepo, SettingDto>, ICrudService<Setting, SettingDto>
    {
        static private SettingRepo repo = new SettingRepo();
        public SettingService() : base(repo)
        {
        }

        public async Task<OperationResult> AddAsync(SettingDto entity)
        {
            var setting = new Setting
            {
                AirportId = entity.AirportId,
                CreatedById = LoginedUserService.EmployeeId,
                Description = entity.Description,
                Email = entity.Email,
                Link = entity.Link,
                Logo = entity.Logo
            };
               
            return await _repo.AddAsync(setting);

        }
        public async Task<OperationResult> UpdateAsync(SettingDto entity, int id)
        {
            var settingResult = await GetByIdAsync(id);
            if (settingResult.IsSuccess)
            {

                var existingSetting = settingResult.Data;

                existingSetting.AirportId = entity.AirportId;
                existingSetting.Description = entity.Description;
                existingSetting.Email = entity.Email;
                existingSetting.Link = entity.Link;
                existingSetting.Logo = entity.Logo;

                return await _repo.UpdateAsync(existingSetting);
            }
            else
            {
                return OperationResult.Failed(Messages.NotFound);
            }
        }

        protected override SettingDto MapEntityToDto(Setting entity)
        {
            return new SettingDto
            {
                Email = entity.Email,
                AirportId = entity.AirportId,
                Description = entity.Description,
                Airport = entity.Airport,
                AirportName = entity.Airport?.Name,
                Link = entity.Link,
                Logo = entity.Logo,
                Id = entity.Id,
            };
        }
    }
}
