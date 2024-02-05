// See https://aka.ms/new-console-template for more information
using System;
using System.Threading.Tasks;
using Business.Concrete;
using Entities;



PttManager pttManager = new(new PersonManager());
pttManager.GiveMask(new Person() { FirstName = "Deneme", LastName = "Deneme", 
    DateOfBirthYear = 2000, NationalIdentity = 26741503420 });