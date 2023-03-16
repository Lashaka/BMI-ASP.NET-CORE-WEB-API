namespace BMI_API
{
    using System;

    class BMI
    {
        private double Weight, Height, Bmi, HeightInMeters;

        public BMI(double weight, double height)
        {
            Weight = weight;
            Height = height;
            HeightInMeters = CalculateHeightInMeters();
            Bmi = CalculateBmi();
        }

        public double getBmi()
        {
            return Bmi;
        }

        private double CalculateBmi()
        {
            return Weight / (HeightInMeters * HeightInMeters);
        }

        private double CalculateHeightInMeters()
        {
            return Height / 100.0;
        }

        public string BMICategory()
        {
            if (Bmi < 18.5)
            {
                return "You are underweight";
            }
            else if (Bmi < 25)
            {
                return "You have a normal weight";
            }
            else if (Bmi < 30)
            {
                return "You are overweight";
            }
            else
            {
                return "You are obese";
            }

        }

        // Returns the ideal weight using the height data.
        public string IdealWeight()
        {
            double minWeight = 18.5 * (HeightInMeters * HeightInMeters);
            double maxWeight = 24.9 * (HeightInMeters * HeightInMeters);


            return "Your ideal weight range is between " + minWeight + "kg and " + maxWeight + "kg.";
        }

        public string Recommandations()
        {
            if (Bmi < 18.5)
            {
                double targetWeight = 24.9 * (HeightInMeters * HeightInMeters);
                double weightToGain = targetWeight - Weight;
                return "You are underweight. To reach your ideal weight, you should gain " + weightToGain + "kg.";
            }
            else if (Bmi >= 25)
            {
                double targetWeight = 24.9 * (HeightInMeters * HeightInMeters);
                double weightToLose = Weight - targetWeight;
                return "You are overweight or obese. To reach your ideal weight, you should lose " + weightToLose + "kg.";
            }
            else
            {
                return "You are in the normal bmi range.";
            }
        }

    }

}

