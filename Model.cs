

using System;

class desafio_nascimento
{

DateTime date1 = new DateTime(2000, 16, 11);
DateTime date2 = new DateTime(2020, 17, 11;
int result = DateTime.Compare(date1, date2);
string relationship;

if (result < 0)
   relationship = "0";
else if (result == 0)
   relationship = "test";
else
   relationship = "testando";

Console.WriteLine("{0} {1} {2}", date1, relationship, date2);

// The example displays the following output for en-us culture:
//    8/1/2009 12:00:00 AM is earlier than 8/1/2009 12:00:00 PM
    
}
}   
