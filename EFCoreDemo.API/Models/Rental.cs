﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDemo.API.Models;

[Table("rental")]
[Index("InventoryId", Name = "idx_fk_inventory_id")]
[Index("RentalDate", "InventoryId", "CustomerId", Name = "idx_unq_rental_rental_date_inventory_id_customer_id", IsUnique = true)]
public partial class Rental
{
    [Key]
    [Column("rental_id")]
    public int RentalId { get; set; }

    [Column("rental_date")]
    public DateTime RentalDate { get; set; }

    [Column("inventory_id")]
    public int InventoryId { get; set; }

    [Column("customer_id")]
    public int CustomerId { get; set; }

    [Column("return_date")]
    public DateTime? ReturnDate { get; set; }

    [Column("staff_id")]
    public int StaffId { get; set; }

    [Column("last_update")]
    public DateTime LastUpdate { get; set; }

    [ForeignKey("CustomerId")]
    [InverseProperty("Rentals")]
    public virtual Customer Customer { get; set; }

    [ForeignKey("InventoryId")]
    [InverseProperty("Rentals")]
    public virtual Inventory Inventory { get; set; }

    [InverseProperty("Rental")]
    public virtual ICollection<PaymentP202201> PaymentP202201s { get; set; } = new List<PaymentP202201>();

    [InverseProperty("Rental")]
    public virtual ICollection<PaymentP202202> PaymentP202202s { get; set; } = new List<PaymentP202202>();

    [InverseProperty("Rental")]
    public virtual ICollection<PaymentP202203> PaymentP202203s { get; set; } = new List<PaymentP202203>();

    [InverseProperty("Rental")]
    public virtual ICollection<PaymentP202204> PaymentP202204s { get; set; } = new List<PaymentP202204>();

    [InverseProperty("Rental")]
    public virtual ICollection<PaymentP202205> PaymentP202205s { get; set; } = new List<PaymentP202205>();

    [InverseProperty("Rental")]
    public virtual ICollection<PaymentP202206> PaymentP202206s { get; set; } = new List<PaymentP202206>();

    [ForeignKey("StaffId")]
    [InverseProperty("Rentals")]
    public virtual Staff Staff { get; set; }
}