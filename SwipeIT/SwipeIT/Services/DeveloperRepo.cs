﻿using SwipeIT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwipeIT.Services
{
    public class DeveloperRepo : IDataStore<Developer>
    {
        private static DeveloperRepo instance;

        private DeveloperRepo()
        {
            AddDummyData();
        }

        private List<Developer> developers { get; set; }

        public static DeveloperRepo GetSingleton()
        {
            if (instance == null)
            {
                instance = new DeveloperRepo();
            }
            return instance;
        }

        public List<Developer> GetDevelopers()
        {
            return developers;
        }

        public async Task<bool> AddItemAsync(Developer item)
        {
            developers.Add(item);
            return await Task.FromResult(true);
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Developer> GetItemAsync(int id)
        {
            return await Task.FromResult(developers.FirstOrDefault(s => s.ID == id));
        }

        public Task<IEnumerable<Developer>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateItemAsync(Developer item)
        {
            Developer oldItem = developers.FirstOrDefault(x => x == item);
            developers.Remove(oldItem);
            developers.Add(item);

            return await Task.FromResult(true);
        }

        private void AddDummyData()
        {
            developers = new List<Developer>
            {
                new Developer
                {
                    ID = 420,
                    LastName = "Van Gelder",
                    FirstName = "Jens",
                    Image = "1.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Haacht",
                        "Leuven",
                        "Mechelen",
                    },
                },
                new Developer
                {
                    ID = 1,
                    LastName = "Maes",
                    FirstName = "Dries",
                    Image = "2.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 2,
                    LastName = "Impe",
                    FirstName = "Ward",
                    Image = "3.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Evergem",
                    },
                },
                new Developer
                {
                    ID = 3,
                    LastName = "Kesteloot",
                    FirstName = "Sebastiaan-Willem",
                    Image = "4.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 4,
                    LastName = "Van Tittelboom",
                    FirstName = "Simon",
                    Image = "5.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 5,
                    LastName = "Alfvoet",
                    FirstName = "Joyce",
                    Image = "6.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 6,
                    LastName = "DeLobelle",
                    FirstName = "Kobe",
                    Image = "7.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 7,
                    LastName = "Danckaert",
                    FirstName = "Emma",
                    Image = "8.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 8,
                    LastName = "Stavropoulos",
                    FirstName = "Andreas",
                    Image = "9.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 9,
                    LastName = "Van Durme",
                    FirstName = "Pieter",
                    Image = "10.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 10,
                    LastName = "Van Royen",
                    FirstName = "Nick",
                    Image = "11.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 11,
                    LastName = "Van Yperzele",
                    FirstName = "Diederick",
                    Image = "12.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Gent",
                    },
                },
                new Developer
                {
                    ID = 12,
                    LastName = "Verhulsdonck",
                    FirstName = "Marieke",
                    Image = "13.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="Communication"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Holland",
                    },
                },
                new Developer
                {
                    ID = 13,
                    LastName = "Wouters",
                    FirstName = "Michiel",
                    Image = "14.png",
                    Skills = new List<Skill>
                    {
                        new Skill
                        {
                            SkillName="C#"
                        },
                    },
                    Locations = new List<string>
                    {
                        "Limburg",
                        "Aalst",
                    },
                },
            };
        }

        public Task<Developer> GetAllItemsAsync()
        {
            throw new NotImplementedException();
        }
    }
}