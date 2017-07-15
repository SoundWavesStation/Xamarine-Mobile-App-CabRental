using CabRentalMobile.App.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabRentalMobile.App.Core.Repository
{
    public class HotDogRepository
    {
        private static List<HotDogGroup> hotDogGroups = new List<HotDogGroup>()
        {
            new HotDogGroup()
            {
                HotDogGroupId=1,
                Title="Meat Lovers",
                ImagePath = "",
                HotDogs=new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=1,
                        Name="Regular Hot Dog",
                        ShortDescription = "The best there is on this planet",
                        Description="Manchego smelly cheese fontina. hard test",
                        ImagePath="hotdog1",
                        Available=true,
                        PrepTime=10,
                        Ingredients=new List<string>(){ "Regular bun","Suasage","Keychup"},
                        Price=8,
                        isFavorite=true
                    },
                    new HotDog()
                    {
                        HotDogId=2,
                        Name="Haute Dog",
                        ShortDescription = "This is classy",
                        Description="TEST TEST TEST TEST",
                        ImagePath="hotdog2",
                        Available=true,
                        PrepTime=15,
                        Ingredients=new List<string>(){ "Baked bun","Gorment sausage","Keychup"},
                        Price=10,
                        isFavorite=false
                    },
                    new HotDog()
                    {
                        HotDogId=3,
                        Name="Extra Long",
                        ShortDescription = "test extra long",
                        Description="extra long. hard test",
                        ImagePath="hotdog3",
                        Available=true,
                        PrepTime=10,
                        Ingredients=new List<string>(){ "extra long bun","extra long Suasage","Keychup"},
                        Price=8,
                        isFavorite=true
                    }

                }
            },new HotDogGroup()
            {
                HotDogGroupId =2,
                Title="Veggie Lovers",
                ImagePath="",
                HotDogs = new List<HotDog>()
                {
                    new HotDog()
                    {
                        HotDogId=4,
                        Name="Veggie Hot Dog",
                        ShortDescription = "American Viggie Lover",
                        Description="Vigie HotDof. hard test",
                        ImagePath="hotdog4",
                        Available=true,
                        PrepTime=10,
                        Ingredients=new List<string>(){ "viggie bun","viggie Suasage","Keychup"},
                        Price=8,
                        isFavorite=false
                    },
                     new HotDog()
                    {
                        HotDogId=5,
                        Name="Haute Dog veggie",
                        ShortDescription = "classy and veggie",
                        Description="Haute dog. hard test",
                        ImagePath="hotdog5",
                        Available=true,
                        PrepTime=15,
                        Ingredients=new List<string>(){ "Haute dog bun","Haute dog Suasage","Keychup"},
                        Price=10,
                        isFavorite=true
                    },
                      new HotDog()
                    {
                        HotDogId=6,
                        Name="Extra long veggie",
                        ShortDescription = "For when a regular one isn't enough",
                        Description="Beetroot water spinach",
                        ImagePath="hotdog6",
                        Available=true,
                        PrepTime=10,
                        Ingredients=new List<string>(){ "Extra long veggie bun", "Extra long viggie Suasage", "Keychup"},
                        Price=8,
                        isFavorite=false
                    }

                }
            }
        };

        public List<HotDog> GetAllHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                select hotDog;

            return hotDogs.ToList<HotDog>();
        }

        public HotDog GetHotDogById(int hotDogId)
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogGroup in hotDogGroups
                from hotDog in hotDogGroup.HotDogs
                where hotDog.HotDogId == hotDogId
                select hotDog;

            return hotDogs.FirstOrDefault();
        }

        public List<HotDogGroup> GetGroupedHotDogs()
        {
            return hotDogGroups;
        }
        public List<HotDog> GetHotDogsForGroup(int hotDogGroupId)
        {
            var group = hotDogGroups.Where(h => h.HotDogGroupId == hotDogGroupId).FirstOrDefault();

            if(group != null)
            {
                return group.HotDogs;
            }
            return null;
        }

        public List<HotDog> GetFavoriteHotDogs()
        {
            IEnumerable<HotDog> hotDogs =
                from hotDogsGroup in hotDogGroups
                from hotDog in hotDogsGroup.HotDogs
                where hotDog.isFavorite
                select hotDog;

            return hotDogs.ToList<HotDog>();
        }
    }
}
