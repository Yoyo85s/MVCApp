﻿using Infrastructure.Entities;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Model;

public class AddressModel
{
    
    public int Id { get; set; }
    public string StreetName { get; set; } = null!;
    public string PostalCode { get; set; } = null!;
    public string City { get; set; } = null!;

    
}
