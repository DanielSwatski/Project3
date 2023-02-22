using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project3.Classes
{
    public enum Gender
    {
        Man,
        Woman,
        Other
    }

    public enum Pet
    {
        Dog,
        Cat,
        Bird,
        Snake,
        Fish,
        Turtle,
        None
    }

    public enum Commitment
    {
        Friends,
        Relationship,
        Marriage
    }


    public class UserProfile
    {
        private string username;
        private string occupation;
        private int age;
        private string profileUrl;
        private string goals;
        private string descritpion;
        private double height;
        private double weight;
        private String telephone;
        private string city;
        private List<string> genres;
        private List<string> food;
        private List<string> vacation;
        private Pet pet;
        private Gender gender;
        private Commitment commitment;

        public UserProfile(string username, string occupation, int age, string profileUrl, string description, double height, double weight, String telephone, string city, List<string> genres, List<string> food, List<string>vacation, Pet pet, Gender gender, Commitment commitment)
        {
            // get this shit done later
        }

        public string Username { get => username; set => username = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public int Age { get => age; set => age = value; }
        public string ProfileUrl { get => profileUrl; set => profileUrl = value; }
        public string Goals { get => goals; set => goals = value; }
        public string Descritpion { get => descritpion; set => descritpion = value; }
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public String Telephone { get => telephone; set => telephone = value; }
        public string City { get => city; set => city = value; }
        public List<string> Genres { get => genres; set => genres = value; }
        public List<string> Food { get => food; set => food = value; }
        public List<string> Vacation { get => vacation; set => vacation = value; }
        public Pet Pet { get => pet; set => pet = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public Commitment Commitment { get => commitment; set => commitment = value; }

        public String ToString()
        {
            return "To string in userprofile";
        }

    }
}