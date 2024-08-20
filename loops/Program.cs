//PROJECT III
        string[] myStrings = new string[2] 
        { 
            "I like pizza. I like roast chicken. I like salad", 
            "I like all three of the menu choices" 
        };

        foreach (string myString in myStrings)
        {
            string tempString = myString;
            int periodLocation;
            
            do
            {
                periodLocation = tempString.IndexOf(".");
                if (periodLocation != -1)
                {
                    string sentence = tempString.Substring(0, periodLocation).Trim();
                    Console.WriteLine(sentence);
                    tempString = tempString.Substring(periodLocation + 1).TrimStart();
                }
                else
                {
                    Console.WriteLine(tempString.Trim());
                }
            } while (periodLocation != -1);
        }
    
    

//PROJECT I
// int number;
//         bool validInput = false;

//         Console.WriteLine("Enter an integer value between 5 and 10:");

//         do
//         {
//             string? input = Console.ReadLine();
//             if (int.TryParse(input, out number))
//             {
//                 if (number >= 5 && number <= 10)
//                 {
//                     validInput = true;
//                 }
//                 else
//                 {
//                     Console.WriteLine("You entered {0}. Please enter a number between 5 and 10.", number);
//                     Console.WriteLine("Try again.");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Sorry, you entered an invalid number, please try again.");
//             }
//         } while (!validInput);

//         Console.WriteLine($"Your input value ({number}) has been accepted.");


 //PROJECT II

    //  string[] validRoles = { "administrator", "manager", "user" };
    //     string role;
    //     bool validEntry = false;

    //     Console.WriteLine("Enter your role name (Administrator, Manager, or User):");

    //     do
    //     {
    //         string? input = Console.ReadLine();
    //         if (input != null)
    //         {
    //             role = input.Trim().ToLower();
    //             if (Array.Exists(validRoles, r => r == role))
    //             {
    //                 validEntry = true;
    //             }
    //             else
    //             {
    //                 Console.WriteLine($"The role name that you entered, \"{input}\" is not valid. Enter your role name (Administrator, Manager, or User):");
    //             }
    //         }
    //         else
    //         {
    //             Console.WriteLine("Input cannot be null. Please try again.");
    //         }
    //     } while (!validEntry);

        // Console.WriteLine($"Your input value ({input}) has been accepted.");
        
