using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GuestResponse
/// </summary>
public class GuestResponse
{
    //We have almost finished our application, but we still have one problem to solve: users can submit any data they want
    //in the Default.aspx form or even post the form without any data at all. We need to make sure that we get values for all
    //of the form fields so we have good data and know who is and who isn’t coming to the party.
    [Required]
    public string Name { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Phone { get; set; }
    [Required(ErrorMessage = "Please tell us if you will attend")]
    public bool? WillAttend { get; set; }
}