// problem: https://www.codewars.com/kata/568d0dd208ee69389d000016/train/csharp

public class RentalCar {

  public static int RentalCarCost(int days) 
  {
      int total = 0;
      if ( days < 3 )
      {
        total = days * 40;
      }
      else if ( days < 7 )
      {
        total = days * 40 - 20;
      }
      else 
      {
        total = days * 40 - 50;
      }
    return total;
  }

}
