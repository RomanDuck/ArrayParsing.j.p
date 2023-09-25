using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This program receives an unknown quantity of delimited values and outputs numeric values.

namespace ArrayParsing.App
{
    internal class Program
    {
        // This method contains the entire program and includes input, processing, and output.
        static void Main(string[] args)
        {

            {
                // string 'numericValues' is used to output numeric values.
                string numericValues = "";

                // char 'delimiter2' is used to split the string into substrings.
                char delimiter2;

                // char 'delimiter' is used to deliver the delimiter value to the 'delimiter2' variable.
                char delimiter = ' ';

                // Declare 'string1' used to hold user's string input.
                string string1;

                // char delimitCollect
                string delimitCollect;

                // bool 'delimitAns' is used to determine if the delimiter value is valid.
                bool delimitAns;

                // Declare bool 'delimit_string' used to determine if the input string contains the delimiter value.
                bool delimit_string = false;

                // bool NeedParse1 is used to check if the user has any strings to parse and validate the user's first response.
                bool NeedParse1 = false;

                // bool NeedParse2 is used to determine if the user has another string to parse after the first string.
                bool NeedParse2 = false;

                // bool NeedParse3 is used to direct the program to the if block on line 119.
                bool NeedParse3 = false;

                // The following line asks the user if they have a string to parse.
                Console.Write("Do you have a string to Parse? (Please enter yes or no): ");

                // Declare string variable determiner as the string entered by the user.
                string determiner = Console.ReadLine();

                // Declare ans1 and ans2 string variables.
                // ans1 & ans2 are used to determine if there is a first string to be parsed.
                string ans1 = "yes";
                string ans2 = "no";

                // This if block will execute if the user response and 'ans1' strings are equivalent.
                // This means the user does have a first string to parse.
                if (determiner == ans1)
                {
                    NeedParse1 = true;
                    NeedParse2 = true;
                    NeedParse3 = true;
                }

                // This block will execute if the user response and 'ans2' strings are equivalent.
                // This means the user has no strings to parse at all.
                else if (determiner == ans2)
                {
                    NeedParse1 = true;
                    NeedParse2 = false;
                    NeedParse3 = false;
                }

                // This block will execute if the user response does not match 'ans1' or 'ans2'
                // The user's input is not valid.
                else
                {
                    NeedParse1 = false;
                }

                // This loop will execute if the above else block is executed.
                // This while loop will ask the user for a valid response.
                // If a valid response is not given, this loop will repeat and then run validation again.
                // This while loop will repeate until the user provides a vaild response.
                while (NeedParse1 == false)
                {
                    // Asks user to give a valid response.
                    Console.Write("Please enter a valid response in order to execute your request: ");

                    // Set string variable determiner as equal to the value entered by the user.
                    determiner = Console.ReadLine();

                    // This if block compares 'determiner' and 'ans1' strings.
                    // This block will execute if the strings are equivalent.
                    if (determiner == ans1)
                    {
                        NeedParse1 = true;
                        NeedParse2 = true;
                        NeedParse3 = true;
                    }

                    // This if block compares 'determiner' and 'ans2' strings.
                    // This block will execute if the strings are equivalent.
                    else if (determiner == ans2)
                    {
                        NeedParse1 = true;
                        NeedParse2 = false;
                        NeedParse3 = false;
                    }

                    // This block will execute if neither of the above two conditions are met.
                    // The user's input is once again invalid.
                    else
                    {
                        NeedParse1 = false;
                    }
                }


                // This if block executes if the 'NeedParse1', 'NeedParse2', and 'NeedParse3' bools are equivalent.
                if (NeedParse1 == true & NeedParse2 == true & NeedParse3 == true)
                {
                    // This while loop will continue to execute while the 'NeedParse1', 'NeedParse2', and 'NeedParse3' bools are equivalent.
                    while (NeedParse2 == true)
                    {
                        // Ask user to input their delimiter value.
                        Console.Write("Enter the character/symbol or space your string will be delimited by: ");

                        // Set string variable 'delimitCollect' equal to user input.
                        delimitCollect = Console.ReadLine();

                        // This if block will execute if 'delimitCollect' can be converted to a char variable.
                        if (char.TryParse(delimitCollect, out char delimit1))
                        {
                            delimitAns = true;
                            delimiter = delimit1;
                        }

                        // This block will execute if 'delimitCollect' cannot be converted to a char variable.
                        else
                        {
                            delimitAns = false;
                        }

                        // This if block will execute if 'delimitAns' is false.
                        // This means that the input value is not a valid delimiter and cannot be coverted to a char variable.
                        if (delimitAns == false)
                        {
                            // This while loop will continue until a vaild delimiter is passed into 'delimitCollect'.
                            while (delimitAns == false)
                            {
                                // Ask user to input a new, valid delimiter value.
                                Console.Write("Please enter a single valid character/symbol or space: ");

                                // Set 'delimitCollect' equal to user's input.
                                delimitCollect = Console.ReadLine();

                                // This if block will execute if 'delimitCollect' can be converted to a char variable.
                                // The delimiter value is valid.
                                if (char.TryParse(delimitCollect, out char delimit2))
                                {
                                    delimitAns = true;
                                    delimiter = delimit2;
                                }

                                // This block will execute if 'delimitCollect' cannot be converted to a char variable.
                                // The delimiter value is not valid.
                                else
                                {
                                    delimitAns = false;
                                }
                            }
                        }

                        // Pass delimiter value to variable 'delimiter2'.
                        delimiter2 = delimiter;

                        // Ask the user to input a string.
                        Console.Write("Enter a string: ");

                        // Set string variable 'string1' equal to the user inputed string.
                        string1 = Console.ReadLine();

                        // This if block will execute if 'string1' contains the 'delimiter2' value.
                        if (string1.Contains(delimiter2))
                        {
                            delimit_string = true;
                        }

                        // This block will execute if 'string1' does not contain the 'delimiter2' value.
                        else
                        {
                            delimit_string = false;
                        }

                        // This if block will execute if 'delimit_string' is false.
                        // This means the string does not contain the delimiter value.
                        if (delimit_string == false)
                        {
                            // This loop will repeat while the user input string does not contain the delimiter value.
                            while (delimit_string == false)
                            {
                                // Ask the user to input a string.
                                Console.Write("Please enter a string that contains your delimiter value: ");

                                // Set string variable 'string1' equal to the user inputed string.
                                string1 = Console.ReadLine();

                                // This if block will execute if 'string1' contains the 'delimiter2' value.
                                if (string1.Contains(delimiter2))
                                {
                                    delimit_string = true;
                                }

                                // This block will execute if 'string1' does not contain the 'delimiter2' value.
                                else
                                {
                                    delimit_string = false;
                                }
                            }
                        }

                        // Split the string in to substrings that are put in array 'input values'.
                        string[] inputValues = string1.Split(delimiter2);

                        // Declares string 'intValues'.
                        string intValues = "Numeric Values: ";

                        // Outputs the string in 'intValues'.
                        Console.Write(intValues);

                        // This foreach loop prints all values from the inputed string that are numeric.
                        foreach (string i in inputValues)
                        {
                            // Declare int variable 't', used to test if substrings can convert to int type.
                            int t;


                            // This block will execute if the substring can be coverted to a string.
                            if (Int32.TryParse(i, out t))
                            {
                                // This if block will execute if 'numericValues' has a length of '0'.
                                if (numericValues.Length == 0)
                                {
                                    numericValues = $"{t}";
                                }

                                // This else if block will execute if 'numericValues' has a length of greater than '0'.
                                else if (numericValues.Length > 0)
                                {
                                    numericValues = $", {t}";
                                }

                                // This else block matches the above if and else if blocks.
                                else
                                {
                                    // This block is left empty since there is no length of '-1'.
                                }

                                // Output numeric values.
                                Console.Write(numericValues);

                            }

                            // This block will execute if a substing cannot be converted to an int.
                            else
                            {
                                // This else block is left empty since nonnumeric values are of no use to the user in this program.
                            }

                        }

                        // Reset 'numericValues' to empty, assigning it a length of '0'.
                        numericValues = "";

                        // Insert a blank line for easier readability.
                        Console.WriteLine();

                        // Ask user if they have another string to parse.
                        Console.Write("Do you have another string to Parse? (Please enter yes or no): ");

                        // Set string 'determiner' equal to the user's new input string.
                        determiner = Console.ReadLine();

                        // If block will execute if 'determiner' and 'ans1' strings are equal.
                        if (determiner == ans1)
                        {
                            NeedParse2 = true;
                        }

                        // If block will execute if 'determiner' and 'ans2' strings are equal.
                        if (determiner == ans2)
                        {
                            NeedParse2 = false;
                        }

                        // While loop will start if a valid response is not entered above.
                        while (determiner != ans1 & determiner != ans2)
                        {
                            // Ask the user again if they have another string to parse.
                            Console.Write("Please enter a valid response in order to execute your request: ");

                            // Declare string variable determiner as value entered by the user.
                            determiner = Console.ReadLine();

                            // If block will execute if 'determiner' and 'ans1' strings are equal.
                            if (determiner == ans1)
                            {
                                NeedParse2 = true;
                            }

                            // If block will execute if 'determiner' and 'ans2' strings are equal.
                            if (determiner == ans2)
                            {
                                NeedParse2 = false;
                            }

                        }

                    }
                }

                if (NeedParse2 == false & determiner == ans2)
                {
                    Console.WriteLine("This program is now terminating. Press enter to end.");
                }

                else
                {
                    // Ask the user again if they have a string to parse.
                    Console.Write("Please enter a valid response in order to execute your request: ");

                    // Set 'determiner' equal to user input.
                    determiner = Console.ReadLine();

                    // This if block will execute if the user response and 'ans1' strings are equivalent.
                    // This means the user does have a first string to parse.
                    if (determiner == ans1)
                    {
                        NeedParse1 = true;
                        NeedParse2 = true;
                        NeedParse3 = true;
                    }

                    // This block will execute if the user response and 'ans2' strings are equivalent.
                    // This means the user has no strings to parse at all.
                    else if (determiner == ans2)
                    {
                        NeedParse1 = true;
                        NeedParse2 = false;
                        NeedParse3 = false;
                    }

                    // This block will execute if the user response does not match 'ans1' or 'ans2'
                    // The user's input is not valid.
                    else
                    {
                        NeedParse1 = false;
                    }

                    // This loop will execute if the above else block is executed.
                    // This while loop will ask the user for a valid response.
                    // If a valid response is not given, this loop will repeat and then run validation again.
                    // This while loop will repeate until the user provides a vaild response.
                    while (NeedParse1 == false)
                    {
                        // Asks user to give a valid response.
                        Console.Write("Please enter a valid response in order to execute your request: ");

                        // Set string variable determiner as equal to the value entered by the user.
                        determiner = Console.ReadLine();

                        // This if block compares 'determiner' and 'ans1' strings.
                        // This block will execute if the strings are equivalent.
                        if (determiner == ans1)
                        {
                            NeedParse1 = true;
                            NeedParse2 = true;
                            NeedParse3 = true;
                        }

                        // This if block compares 'determiner' and 'ans2' strings.
                        // This block will execute if the strings are equivalent.
                        else if (determiner == ans2)
                        {
                            NeedParse1 = true;
                            NeedParse2 = false;
                            NeedParse3 = false;
                        }

                        // This block will execute if neither of the above two conditions are met.
                        // The user's input is once again invalid.
                        else
                        {
                            NeedParse1 = false;
                        }
                    }

                    if (NeedParse1 == true & NeedParse2 == true & NeedParse3 == true)
                    {
                        // This while loop will continue to execute while the 'determiner' and 'ans1' strings are equivalent.
                        while (NeedParse2 == true)
                        {
                            // Ask user to input their delimiter value.
                            Console.Write("Enter the character/symbol or space your string will be delimited by: ");

                            // Set string variable 'delimitCollect' equal to user input.
                            delimitCollect = Console.ReadLine();

                            // This if block will execute if 'delimitCollect' can be converted to a char variable.
                            if (char.TryParse(delimitCollect, out char delimit1))
                            {
                                delimitAns = true;
                                delimiter = delimit1;
                            }

                            // This block will execute if 'delimitCollect' cannot be converted to a char variable.
                            else
                            {
                                delimitAns = false;
                            }

                            // This if block will execute if 'delimitAns' is false.
                            // This means that the input value is not a valid delimiter and cannot be coverted to a char variable.
                            if (delimitAns == false)
                            {
                                // This while loop will continue until a vaild delimiter is passed into 'delimitCollect'.
                                while (delimitAns == false)
                                {
                                    // Ask user to input a new, valid delimiter value.
                                    Console.Write("Please enter a single valid character/symbol or space: ");

                                    // Set 'delimitCollect' equal to user's input.
                                    delimitCollect = Console.ReadLine();

                                    // This if block will execute if 'delimitCollect' can be converted to a char variable.
                                    // The delimiter value is valid.
                                    if (char.TryParse(delimitCollect, out char delimit2))
                                    {
                                        delimitAns = true;
                                        delimiter = delimit2;
                                    }

                                    // This block will execute if 'delimitCollect' cannot be converted to a char variable.
                                    // The delimiter value is not valid.
                                    else
                                    {
                                        delimitAns = false;
                                    }
                                }
                            }

                            // Pass delimiter value to variable 'delimiter2'.
                            delimiter2 = delimiter;

                            // Ask the user to input a string.
                            Console.Write("Enter a string: ");

                            // Set string variable 'string1' equal to the user inputed string.
                            string1 = Console.ReadLine();

                            // This if block will execute if 'string1' contains the 'delimiter2' value.
                            if (string1.Contains(delimiter2))
                            {
                                delimit_string = true;
                            }

                            // This block will execute if 'string1' does not contain the 'delimiter2' value.
                            else
                            {
                                delimit_string = false;
                            }

                            // This if block will execute if 'delimit_string' is false.
                            // This means the string does not contain the delimiter value.
                            if (delimit_string == false)
                            {
                                // This loop will repeat while the user input string does not contain the delimiter value.
                                while (delimit_string == false)
                                {
                                    // Ask the user to input a string.
                                    Console.Write("Please enter a string that contains your delimiter value: ");

                                    // Set string variable 'string1' equal to the user inputed string.
                                    string1 = Console.ReadLine();

                                    // This if block will execute if 'string1' contains the 'delimiter2' value.
                                    if (string1.Contains(delimiter2))
                                    {
                                        delimit_string = true;
                                    }

                                    // This block will execute if 'string1' does not contain the 'delimiter2' value.
                                    else
                                    {
                                        delimit_string = false;
                                    }
                                }
                            }

                            // Split the string in to substrings that are put in array 'input values'.
                            string[] inputValues = string1.Split(',');

                            // Declares string 'intValues'
                            string intValues = "Numeric Values: ";

                            // Outputs the string in 'intValues'.
                            Console.Write(intValues);

                            // This foreach loop prints all values from the inputed string that are numeric.
                            foreach (string i in inputValues)
                            {
                                // Declare int variable 't', used to test if substrings can convert to int type.
                                int t;

                                // This block will execute if the substring can be coverted to a string.
                                if (Int32.TryParse(i, out t))
                                {
                                    // This if block will execute if 'numericValues' has a length of '0'.
                                    if (numericValues.Length == 0)
                                    {
                                        numericValues = $"{t}";
                                    }

                                    // This else if block will execute if 'numericValues' has a length of greater than '0'.
                                    else if (numericValues.Length > 0)
                                    {
                                        numericValues = $", {t}";
                                    }

                                    // This else block matches the above if and else if blocks.
                                    else
                                    {
                                        // This block is left empty since there is no length of '-1'.
                                    }

                                    // Output numeric values.
                                    Console.Write(numericValues);

                                }
                                else
                                {
                                    // This else block is left empty since nonnumeric values are of no use to the user.
                                }

                            }
                            // Reset 'numericValues' to empty, assigning it a length of '0'.
                            numericValues = "";

                            // Insert a blank line for easier readability.
                            Console.WriteLine();

                            // Ask user if they have another string to parse.
                            Console.Write("Do you have another string to Parse? (Please enter yes or no): ");

                            // Set string 'determiner' equal to the user's new input string.
                            determiner = Console.ReadLine();

                            // If block will execute if 'determiner' and 'ans1' strings are equal.
                            if (determiner == ans1)
                            {
                                NeedParse2 = true;
                            }

                            // If block will execute if 'determiner' and 'ans2' strings are equal.
                            if (determiner == ans2)
                            {
                                NeedParse2 = false;
                            }

                            // While loop will start if a valid response is not entered above.
                            while (determiner != ans1 & determiner != ans2)
                            {
                                // Asks user if they have a string to parse.
                                Console.Write("Please enter a valid response in order to execute your request: ");

                                // Declare string variable determiner as value entered by the user.
                                determiner = Console.ReadLine();

                                // If block will execute if 'determiner' and 'ans1' strings are equal.
                                if (determiner == ans1)
                                {
                                    NeedParse2 = true;
                                }

                                // If block will execute if 'determiner' and 'ans2' strings are equal.
                                if (determiner == ans2)
                                {
                                    NeedParse2 = false;
                                }

                            }

                        }
                    }

                    // The following block will execute if 'NeedParse' is false and 'determiner' is equal to 'ans2'.
                    // The following if block alerts the user that the program is going to end.
                    if (NeedParse2 == false & determiner == ans2)
                    {
                        // The following line displays a message to warn the user that the program is ending.
                        Console.WriteLine("This program is now terminating. Press enter to end.");
                    }

                }
                // The following line is used to keep the program window open until the user hits the enter key.
                Console.ReadLine();
            }
        }
    }
}
