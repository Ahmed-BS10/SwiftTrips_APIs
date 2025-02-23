﻿using DataAccess_Layer.Entities.Hotels;
using DataAccess_Layer.Entities.People;
using System.ComponentModel.DataAnnotations;

public class eSavedHotlesDA
{
    [Key]

    public int SavedHotleID { get; set; }

    public int UserID { get; set; }

    public int HotleID { get; set; }

    public bool IsSaved {  get; set; }

    public DateTime SaveDate { get; set; }


    // Navigation Property

    public eUsersDA users {  get; set; }

    public eHotelsDA hotels {  get; set; }  

}
