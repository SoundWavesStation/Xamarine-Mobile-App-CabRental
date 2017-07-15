using CabRentalMobile.App.Core.Model;
using CabRentalMobile.App.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRentalMobile.App.Core.Service
{
    public class HotDogDataService
    {
        private static HotDogRepository hotDogRepository = new HotDogRepository();

        public List<HotDog> GetAllHotDogs()
        {
            return hotDogRepository.GetAllHotDogs();
        }
        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogRepository.GetGroupedHotDogs();
        }
        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            return hotDogRepository.GetHotDogsForGroup(hotDogGroupId);
        }
        public List<HotDog> GetFavoriteHotDogs()
        {
            return hotDogRepository.GetFavoriteHotDogs();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            return hotDogRepository.GetHotDogById(hotDogId);
        }
       
    }
}
