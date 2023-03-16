using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;


// only using this in the main section so it can be easier to control
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
        private string desciption;
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

        public UserProfile(string username, string occupation, int age, string city, double height, double weight, string profileUrl, Pet pet, List<string> vacation, List<string> genres, List<string> food, Gender gender, Commitment commitment, string description, String telephone)
        {
            this.username = username;
            this.occupation = occupation;
            this.age = age;
            this.city = city;
            this.height = height;
            this.weight = weight;
            this.profileUrl = profileUrl;
            this.pet = pet;
            this.vacation = vacation;
            this.genres = genres;
            this.food = food;
            this.gender = gender;
            this.commitment = commitment;
            this.Descritpion = desciption;
            this.telephone = telephone;
        }

        
        public UserProfile(DataRow row)
        {
            String holder; // used for converting objects to strings to arrays to list of strings
            this.username = (string)row.ItemArray[0];
            this.occupation = (string)row.ItemArray[1];
            this.age = (int)row.ItemArray[2];
            this.city = (string)row.ItemArray[3];
            this.height = (double)row.ItemArray[4];
            this.weight = (double)row.ItemArray[5];
            this.profileUrl = (string)row.ItemArray[6];
            Enum.Parse(typeof(Pet), (string)row.ItemArray[7]);

            holder = (string)row.ItemArray[8];
            this.vacation = new List<String>(holder.Split(';'));
            
            holder = (string)row.ItemArray[9];
            this.genres = new List<String>(holder.Split(';'));

            holder = (string)row.ItemArray[10];
            this.food = new List<String>(holder.Split(';'));

            Enum.Parse(typeof(Gender), (string)row.ItemArray[11]);
            Enum.Parse(typeof(Commitment), (string)row.ItemArray[12]);
            this.Descritpion = (string)row.ItemArray[13];
            this.telephone = (string)row.ItemArray[14];
        }



        public string Username { get => username; set => username = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public int Age { get => age; set => age = value; }
        public string ProfileUrl { get => profileUrl; set => profileUrl = value; }
        public string Goals { get => goals; set => goals = value; }
        public string Descritpion { get => desciption; set => desciption = value; }
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
            return "Username: " + this.username + "\nOccupation: " + this.occupation + "\nAge: " + this.age.ToString() +
                "\nDescription: " + this.desciption + "\nHeight: " + this.height.ToString() + "\nWeight: " + this.weight.ToString() + "\nTelephone: " + this.telephone + "\nCity: " + this.city;
        }

    }
}