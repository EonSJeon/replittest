=join(":",format(prop("Hours")+floor((prop("Minutes")+floor(prop("Seconds"))/60)/60)),format(prop("Minutes")+floor(prop("Seconds")/60)%60),format(prop("Seconds")%60));
using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine (GetDay(80));
  }
  static string GetDay(int dayNum){
    string dayName;
    switch (dayNum) {
      case 0:
        dayName="Sunday";
        break;
      case 1:
        dayName="Monday";
        break;
      case 2:
        dayName="Tuesday";
        break;
      case 3:
        dayName="Wednesday";
        break;
      case 4:
        dayName="Thursday";
        break;
      case 5:
        dayName="Friday";
        break;
      case 6:
        dayName="Saturday";
        break;
      default:
        dayName="Invalid Day Number";
        break;
    }
    return dayName;
  }
}