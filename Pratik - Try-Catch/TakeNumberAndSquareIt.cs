using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratik___Try_Catch
{
    public class NumberMetod
    {
        public int numberMetod()
        {

            bool isValueInput = false;
            int validNumber = 0;
            while (!isValueInput)
            {
                Console.Write("Bir Sayı Giriniz: ");
                string input = Console.ReadLine();


                try
                {
                    // Boşsa…
                    if (string.IsNullOrWhiteSpace(input))
                        throw new InvalidException("Sayı girmediniz.");

                    // Format ve overflow’u kontrol eden satır:
                    try
                    {
                        validNumber = Convert.ToInt32(input);
                    }
                    catch (FormatException)
                    {
                        // Kendi özel format exception’ınızı yazdırıyoruz
                        throw new MyFormatException("Geçerli bir tamsayı formatında değer girin.");
                    }
                    catch (OverflowException)
                    {
                        // Kendi özel overflow exception’ınızı yazdırıyoruz
                        throw new MyOverflowException("Sayı int sınırlarını aştı.");
                    }

                    // Buraya geldiğimizde validNumber’e artık doğru bir int atandı
                    isValueInput = true;
                }
                catch (InvalidException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (MyFormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (MyOverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (MyArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return validNumber * validNumber;
        }
    }
}