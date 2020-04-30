using System;
using ApiaryMonitoringSystem.BLL.DTO;
using ApiaryMonitoringSystem.DAL.Entities;
using ApiaryMonitoringSystem.DAL.Interfaces;
using ApiaryMonitoringSystem.BLL.Infrastructure;
using ApiaryMonitoringSystem.BLL.Interfaces;
using System.Collections.Generic;
using AutoMapper;

namespace ApiaryMonitoringSystem.BLL.Services
{
    public class ApiaryMonitoringService : IMonitoringService
    {
        IUnitOfWork Database { get; set; }

        public ApiaryMonitoringService(IUnitOfWork unitOfWork)
        {
            Database = unitOfWork;
        }

        public ApiaryDTO GetApiary(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Id for Apiary was not set", "");
            }
            var apiary = Database.Apiaries.Get(id.Value);
            if (apiary == null)
            {
                throw new ValidationException("Can't find an Apiary", "");
            }
            // Get beekeeper data to add BeekeeperDTO to ApiaryDTO
            //var apiaryBeekeeper = Database.Users.Get(apiary.beekeeper);
            //var BeekeeperDTO = new UserDTO { };
            //if (apiaryBeekeeper != null)
            //{
            //    BeekeeperDTO.id = apiaryBeekeeper.id;
            //    BeekeeperDTO.first_name = apiaryBeekeeper.first_name;
            //    BeekeeperDTO.second_name = apiaryBeekeeper.second_name;
            //    BeekeeperDTO.phone_number = apiaryBeekeeper.phone_number;
            //    BeekeeperDTO.role_id = apiaryBeekeeper.role_id;
            //}
            return new ApiaryDTO
            {
                Id = apiary.Id,
                Title = apiary.Title,
                Beekeeper = apiary.Beekeeper,
                CurrentAddress = apiary.CurrentAddress,
            // ToDo: Add list of beehives 
            };
        }

        public BeeHiveDTO GetBeeHive(int? id)
        {
            if (id == null)
            {
                throw new ValidationException("Id for BeeHive was not set", "");
            }
            var beehive = Database.BeeHives.Get(id.Value);
            if (beehive == null)
            {
                throw new ValidationException("Can't find an BeeHive", "");
            }
            ApiaryDTO ItsApiary = new ApiaryDTO();
            if (beehive.ApiaryId.HasValue)
            {
                var itsApiary = Database.Apiaries.Get(beehive.ApiaryId.Value);
                if (itsApiary != null)
                {
                    // Attention! I don't like this dublication of code. I need to use ApiaryDTO.GetApiary() here.
                    ItsApiary.Id = itsApiary.Id;
                    ItsApiary.Title = itsApiary.Title;
                    ItsApiary.Beekeeper = itsApiary.Beekeeper;
                    ItsApiary.CurrentAddress = itsApiary.CurrentAddress;
                };
            }
            return new BeeHiveDTO
            {
                Id = beehive.Id,
                Number = beehive.Number,
                ApiaryId = beehive.ApiaryId,
                Apiary = ItsApiary,
                QueenbeeAge = beehive.QueenbeeAge,
                QueenbeeBreed = beehive.QueenbeeBreed,
                FamilyClass = beehive.FamilyClass,
                HiveType = beehive.HiveType,
                ImageFile = beehive.ImageFile,
                // ToDo: Add lists of HealthStatuses and Inspections
            };
        }

        public IEnumerable<BeeHiveDTO> GetBeeHives()
        {
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<BeeHive, BeeHiveDTO>()
            // ToDo: add inserted objects into mapper
            .ForMember(dist => dist.Apiary,
                       opt => opt.Ignore())
            .ForMember(dist => dist.Inspections,
                       opt => opt.Ignore())
            .ForMember(dist => dist.HealthStatuses,
                       opt => opt.Ignore())
            ).CreateMapper();
            return mapper.Map<IEnumerable<BeeHive>, List<BeeHiveDTO>>(Database.BeeHives.GetAll());
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
