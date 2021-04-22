﻿using SwipeIT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace SwipeIT.Services
{
    public class SkillsRepo : IDataStore<Skill>
    {
        private static SkillsRepo instance;
        private ObservableCollection<Skill> skills { get; set; }

        private SkillsRepo()
        {
            AddDummyData();
        }

        public static SkillsRepo GetSingleton()
        {
            return instance ?? (instance = new SkillsRepo());
        }

        public ObservableCollection<Skill> GetSkills()
        {
            return skills;
        }

        public async Task<bool> AddItemAsync(Skill item)
        {
            skills.Add(item);
            return await Task.FromResult(true);
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Skill> GetItemAsync(int id)
        {
            return await Task.FromResult(skills.FirstOrDefault(s => s.ID == id));
        }

        public Task<IEnumerable<Skill>> GetItemsAsync(bool forceRefresh = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Skill item)
        {
            throw new NotImplementedException();
        }

        public Task<Skill> GetAllItemsAsync()
        {
            throw new NotImplementedException();
        }

        private void AddDummyData()
        {
            skills = new ObservableCollection<Skill>
            {
                new Skill
                {
                    SkillName = "C#"
                },
                new Skill
                {
                    SkillName = "Java"
                },
                new Skill
                {
                    SkillName = ".NET"
                },
                new Skill
                {
                    SkillName = "HTML"
                },
                new Skill
                {
                    SkillName = "CSS"
                },
                new Skill
                {
                    SkillName = "Javascript"
                },
            };
        }
    }
}