using User_Registrations;
Console.WriteLine("Hello, Welcome to User Registration Programe!");
Console.WriteLine("Choose Option what you want to validate :- ");
Console.WriteLine("1. First Name \n2.Last Name \n3. Email \n4. Mobile Number \n5. Password");
UserRegistration userregistration = new UserRegistration();
int option = Convert.ToInt32(Console.ReadLine());
switch(option)
{
    case 1:
        userregistration.FirstName();
        break;
    case 2:
        userregistration.LastName();
        break;
    case 3:
        userregistration.Email();
        break;
    case 4:
        userregistration.MobileNum();
        break;
    case 5:
        userregistration.Password();
        break;
    default:
        Console.WriteLine("Choose From available Option :) ");
        break;
}
Console.WriteLine("Choose Option what you want to validate Using Reflaction:- ");
Console.WriteLine("1. Validate First Name \n2. Validate Last Name \n3. Validate Email \n4. Validate Mobile Number \n5. Validate Password");
ValidReflction reflction = new ValidReflction();
int option1 = Convert.ToInt32(Console.ReadLine());
switch (option1)
{
    case 1:
        Console.WriteLine("Enter First Name:");
        string userName = Console.ReadLine();
        if (reflction.ValidateFirstName(userName) == true)
            Console.WriteLine("First name accepted");
        else
            Console.WriteLine("Invalid!!First letter must be capital and minimum 3 characters requiered!!");
        break;
    case 2:
        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();
        if (reflction.ValidateFirstName(lastName) == true)
            Console.WriteLine("First name accepted");
        else
            Console.WriteLine("Invalid!!First letter must be capital and minimum 3 characters requiered!!");
        break;
    case 3:
        Console.WriteLine("Enter Email address");
        string email = Console.ReadLine();
        if (reflction.ValidateEmail(email))
            Console.WriteLine("Email accepted");
        else
            Console.WriteLine("Invalid!!");
        break;
    case 4:
        Console.WriteLine("Enter mobile number");
        var number = Console.ReadLine();
        if (reflction.ValidateMobileNumber(number) == true)
            Console.WriteLine("Mobile number accepted");
        else
            Console.WriteLine("Please enter a valid number");
        break;
    case 5:
        Console.WriteLine("Enter 8 character password");
        var pwd = Console.ReadLine();
        if (reflction.ValidatePasswordRule1(pwd) == true)
            Console.WriteLine("Password eccepted");
        else
            Console.WriteLine("Invalid");
        break;
    default:
        Console.WriteLine("Choose From available Option :) ");
        break;
}

