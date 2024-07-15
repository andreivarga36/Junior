using System.Collections.Immutable;

namespace JuniorSoftwareDeveloper
{
    public class GenericPackage
    {
        private string uniqueId;
        private double weight;
        private readonly string packageName = "";
        private string courierName = "";

        public GenericPackage(string uniqueId)
        {
            this.uniqueId = uniqueId;
        }


        public GenericPackage(string uniqueId, double weight, string packageName, string courierName) : this (uniqueId)
        {
            this.weight = weight;
            this.packageName = packageName;
            this.courierName = courierName;
        }

        public string UniqueId { get => uniqueId; private set => uniqueId = value; }

        public double Weight { get => weight; }

        public string PackageName { get => packageName; }

        public string CourierName { get => courierName; set => courierName = value; }

        public void AddItem(double itemWeight)
        {
            weight += itemWeight;
        }

        public bool CheckId()
        {
            return ContainsOnlyDigits()
                && TotalOddDigitsAreMultipleOfThree()
                && IsSumOfDigitsDivisibleByFour()
                && IsDifferenceBetweenAnyTwoConsecutiveDigitsLessThanFive()
                && HasValidLength();
        }

        public string ComputeDetails()
        {
            string packageDetails = $"Pachetul {PackageName} avand codul {UniqueId} si greutatea {Weight} apartine curierului {CourierName}";

            return packageDetails;
        }


        private bool ContainsOnlyDigits()
        {
            foreach (var character in uniqueId)
            {
                if (!char.IsDigit(character))
                {
                    return false;
                }
            }

            return true;
        }

        private bool TotalOddDigitsAreMultipleOfThree()
        {
            if (!ContainsOnlyDigits())
            {
                return false;
            }

            int oddNumbers = 0;

            for (int i = 0; i < uniqueId.Length; i++) 
            {
                if (int.Parse(uniqueId[i].ToString()) % 2 != 0)
                {
                    oddNumbers++;
                }
            }

            return oddNumbers % 3 == 0;
        }

        private bool IsSumOfDigitsDivisibleByFour()
        {
            if (!ContainsOnlyDigits())
            {
                return false;
            }

            int sum = 0;

            foreach (var character in uniqueId) 
            {
                sum += int.Parse(character.ToString());
            }

            return sum % 4 == 0;
        }

        private bool IsDifferenceBetweenAnyTwoConsecutiveDigitsLessThanFive()
        {
            if (!ContainsOnlyDigits())
            {
                return false;
            }

            for (int i = 0; i <= uniqueId.Length - 2; i++)
            {
                int first = int.Parse(uniqueId[i].ToString());
                int second = int.Parse(uniqueId[i + 1].ToString());

                if (first > second && first - second > 5)
                {
                    return false;
                }
                else if (second > first && second - first > 5)
                {
                    return false;
                }
            }

            return true;
        }

        private bool HasValidLength()
        {
            return uniqueId.Length >= 10 && uniqueId.Length <= 12;
        }

    }
}
