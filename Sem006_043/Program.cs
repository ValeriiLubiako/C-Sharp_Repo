// string[] values= { "-1,035.77219", "1AFF", "1e-35",
//                          "1,635,592,999,999,999,999,999,999", "-17.455",
//                          "190.34001", "1.29e325"};
string[] values= { "-1035.77219", "-1 035.77219","1AFF", "1e-35",
                         "1 635 592 999 999 999 999 999 999", "1635592999999999999999999", "-17.455",
                         "190.34001", "1.29e325"};                         
// string[] values= { "-1,035", "-17.455",
//                          "190.34001", "190,34001", "0.34001", "0,34001"};

      double result;

      foreach (string value in values)
      {
         try {
            result = Convert.ToDouble(value);
            Console.WriteLine("Converted '{0}' to {1}.", value, result);
         }
         catch (FormatException) {
            Console.WriteLine("Unable to convert '{0}' to a Double.", value);
         }
         catch (OverflowException) {
            Console.WriteLine("'{0}' is outside the range of a Double.", value);
         }
      }
