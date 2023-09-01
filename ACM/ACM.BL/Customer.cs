using System;

class Customer
{
    public string FirstName { get; set; }
    private string lastname;
    public string LastName
    {
        get 
        { 
            return lastname; 
        } 
        set 
        {
            lastname = "ABC";
        }
    }

    public string FullName 
    {
        get
        {
            return LastName + ", " + FirstName;
        }
    }

    public int CustomerID { get; set; }
    public string EmailAddress { get; set; }



    
    
}
