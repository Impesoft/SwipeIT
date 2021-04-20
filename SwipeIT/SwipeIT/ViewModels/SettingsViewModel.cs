﻿using SwipeIT.Models;
using SwipeIT.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace SwipeIT.ViewModels
{
    public class SettingsViewModel : BaseViewModel

    {
        private bool showImagePicker;

        private Location selectedLocation;

        public Location SelectedLocation
        {
            get { return selectedLocation; }
            set
            {
                selectedLocation = value;
                OnPropertyChanged(nameof(SelectedLocation));
            }
        }

        private List<Location> availableLocations;

        public List<Location> AvailableLocations
        {
            get { return availableLocations; }
            set
            {
                availableLocations = value;
                OnPropertyChanged(nameof(AvailableLocations));
            }
        }

        public bool ShowImagePicker
        {
            get { return showImagePicker; }
            set
            {
                showImagePicker = value;
                OnPropertyChanged(nameof(ShowImagePicker));
            }
        }

        public Command<Account> SaveCommand => new Command<Account>(SaveAsync);
        public Command<Location> DeleteLocationCommand => new Command<Location>(DeleteLocationAsync);

        public Command<Location> AddLocationCommand => new Command<Location>(AddLocation);

        public Command<string> AvatarSelectedCommand => new Command<string>(AvatarSelected);
        public Command ImageClickedCommand => new Command(ImageClicked);

        public bool IsDeveloper { get; set; }
        public bool IsRecruiter { get; set; }

        public User CurrentUser { get; set; }
        public List<string> AvatarList { get; set; }

        public SettingsViewModel()
        {
            AvailableLocations = new List<Location>();
            CurrentUser = (User)CurrentUserSingleton.CurrentUser;
            foreach (Location item in Enum.GetValues(typeof(Location)))
            {
                if (item != Location.Unassigned && !CurrentUser.Locations.Contains(item))
                {
                    AvailableLocations.Add(item);
                }
            }
            //AvailableLocations = AvailableLocations.Where(x => !CurrentUser.Locations.Contains(x)).ToList();

            AvatarList = new List<string> {
                "Icon01.png",
                "Icon02.png",
                "Icon03.png",
                "Icon04.png",
                "Icon05.png",
                "Icon06.png",
                "Icon07.png",
                "Icon08.png",
                "Icon09.png",
                "Icon10.png",
                "Icon11.png",
                "Icon12.png",
                "Icon13.png",
                "Icon14.png",
                "Icon15.png",
                "Icon16.png",
                "Icon17.png",
                "Icon18.png",
                "Icon19.png",
                "Icon20.png",
                "Icon21.png",
                "Icon22.png",
                "Icon23.png",
                "Icon24.png",
                "Icon25.png",
                "Icon26.png",
                "Icon27.png",
                "Icon28.png",
                "Icon29.png",
                "Icon30.png",
                "Icon31.png",
            };
            if (CurrentUserSingleton.CurrentUser is Developer)
            {
                IsDeveloper = true;
                IsRecruiter = false;
            }
            else if (CurrentUserSingleton.CurrentUser is Recruiter)
            {
                IsDeveloper = false;
                IsRecruiter = true;
            }
        }

        private void DeleteLocationAsync(Location location)
        {
            CurrentUser.Locations.Remove(location);
            AvailableLocations.Add(location);
        }

        private void AddLocation(Location location)
        {
            CurrentUser.Locations.Add(location);
            AvailableLocations.Remove(location);
        }

        private void ImageClicked()
        {
            ShowImagePicker = true;
        }

        private void AvatarSelected(string imageURL)
        {
            CurrentUser.Image = imageURL;
            ShowImagePicker = false;
        }

        private async void SaveAsync(Account account)
        {
            if (account is Developer)
            {
                await DeveloperRepo.UpdateItemAsync((Developer)account);
            }
            else if (account is Recruiter)
            {
                await RecruiterRepo.UpdateItemAsync((Recruiter)account);
            }
        }
    }
}