﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SwipeIT.Models
{
    public abstract class User : Account
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        private string image;

        public string Image
        {
            get { return image; }
            set
            {
                image = value;
                OnPropertyChanged(nameof(Image));
            }
        }

        private int yearsOfExperience;

        public int YearsOfExperience
        {
            get { return yearsOfExperience; }
            set
            {
                yearsOfExperience = value;
                OnPropertyChanged(nameof(yearsOfExperience));
            }
        }

        private List<Skill> skills;

        public List<Skill> Skills
        {
            get { return skills; }
            set
            {
                skills = value;
                OnPropertyChanged(nameof(Skills));
            }
        }

        private ObservableCollection<Location> locations;

        public ObservableCollection<Location> Locations
        {
            get { return locations; }
            set
            {
                locations = value;
                OnPropertyChanged(nameof(Locations));
            }
        }

        public User()
        {
            Skills = new List<Skill>();
            Locations = new ObservableCollection<Location>();
        }
    }
}