# BMI-ASP.NET-CORE-WEB-API
This project contains a BMI calculator implemented in C# using the .NET Core framework. The calculator calculates a person's BMI (Body Mass Index) based on their weight and height, and provides additional information such as their BMI category, ideal weight range, and recommendations for weight management.

## Files
### BMIController.cs:
This file contains the BMIController class, which defines four HTTP GET endpoints (GetBMI, IdealWeight, BMICategory, and Recommandations) that receive weight and height parameters, create a BMI object with those parameters, and return the results of various calculations performed by the BMI object. The endpoints are decorated with HttpGet and Route attributes to specify their URL paths.
### BMI.cs:
This file contains the BMI class, which represents a BMI object. It contains fields for weight, height, BMI, and height in meters, as well as methods for calculating the BMI, height in meters, BMI category, ideal weight range, and weight management recommendations.

## Endpoints
### GetBMI:
Calculates the BMI based on the weight and height parameters and returns it as a decimal value.
### IdealWeight:
Calculates the ideal weight range based on the height parameter and returns it as a string.
### BMICategory:
Calculates the BMI category based on the weight and height parameters and returns it as a string.
### Recommandations:
Provides weight management recommendations based on the BMI calculated from the weight and height parameters, and returns them as a string.

## Usage
To use the BMI calculator, send a GET request to one of the four available endpoints (GetBMI, IdealWeight, BMICategory, or Recommandations) with the weight and height parameters in the query string. For example, to calculate the BMI for a person weighing 75 kg and measuring 180 cm tall, send a GET request to https://example.com/BMI/GetBMI?weight=75&height=180. The response will be a decimal value representing the person's BMI.

## Disclaimer
The BMI calculator provided in this project is intended for educational and informational purposes only, and should not be used as a substitute for professional medical advice, diagnosis, or treatment. The accuracy of the results may vary depending on factors such as body composition, muscle mass, and other health conditions. Consult a qualified healthcare professional before making any changes to your diet, exercise routine, or other lifestyle habits.
