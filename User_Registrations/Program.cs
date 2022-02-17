using User_Registrations;
Console.WriteLine("Hello, Welcome to User Registration Programe!");
Console.WriteLine("Choose Option what you want to validate :- ");
Console.WriteLine("1. First Name \n2.Last Name \n3. Email \n4. Mobile Number");
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
    default:
        Console.WriteLine("Choose From available Option :) ");
        break;
}