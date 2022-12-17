/*
Write a program to findout "category of height" based on the given height of a person (in inches), using "if".
Height categories:
Height is less than 150 cm = "Dwarf"
Height is between 150 cm and 165 cm = "Average height"
Height is between 165 cm and 195 cm = "Tall"
Height is above 195 cm = "Abnormal height"

Note: 1 inch = 2.54 centimeter
You need to convert the input value (inches) into centimeters.

Eg:
Input: 75
Output: Tall 
*/

namespace AssignmentHeightInCategories
{
	class Program
	{
		static void Main()
		{
			// Input
			double inch = 2.54;
			double height = 75 * inch;
			string result = null;

			// Check the height and find the height category accordingly
			if (height < 150)
			{
				result = "Dwarf";
			}
			else if (height >= 150 && height <= 165)
			{
				result = "Average height";
			}
			else if (height >= 165 && height <= 195)
			{
				result = "Tall";
			}
			else if (height > 195)
			{
				result = "Abnormal height";
			}

			// Output
			System.Console.WriteLine(result);
			System.Console.ReadKey();
		}
	}
}
