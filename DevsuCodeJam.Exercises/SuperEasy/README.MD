## **Super Easy Exercises**

**[1. Encrypt your message](https://github.com/cristofima/DevsuCodeJam/blob/master/DevsuCodeJam.Exercises/SuperEasy/Exercise01.cs)** 

You have been tasked with developing a new way to encrypt communications. Basically, every  vowel of the input message will have to be preceded by another string, called the key.

The function will receive​ **two string**​ parameters: the first one will be the key, and the second one, the message. The function will return a ​**string**​.

**Example:**

**Key**​: dcj

**Message**​: I love prOgrAmming!

This should return ​dcjI ldcjovdcje prdcjOgrdcjAmmdcjing!

The letter y is ​**NOT** ​going to be considered a vowel and vowels that contain accents are not taken into consideration.

If ​message​ is ​null​ or empty, return an empty string. If ​key​ is ​null​ or empty, then use ​DCJ​ as the default.

**[2.	Track my time](https://github.com/cristofima/DevsuCodeJam/blob/master/DevsuCodeJam.Exercises/SuperEasy/Exercise02.cs)**

Given an array of integers representing a time in ms, calculate the sum of all those values and present them in another integer array where the first element has the number of days, the second element has the number of hours, the third element has the number of minutes, the fourth element has the number of seconds and the fifth element has the number of milliseconds. If a time is negative, it counts as ​0 ms​. If input​ is ​null​ or empty, it counts as ​0 ms​.

**Example:**

**Input**​: ​[65647440, 199644521]

**Output**​: ​[3, 1, 41, 31, 961]

**[3. N<sup>th</sup> case](https://github.com/cristofima/DevsuCodeJam/blob/master/DevsuCodeJam.Exercises/SuperEasy/Exercise03.cs)**

Write a method that receives an ​**integer**​ and a ​**string**​, and returns the exact same string where every k*n​<sup>th</sup> (k > 0)​ char has had its case changed.

If ​null​ is received as the message, return an empty string. If ​n <= 0​, return the same message.

**Example:**

**Input**​: ​(3, "Greetings, this is AN EXAMPLE!")

**Output**​: ​"GrEetIngS, ThiS iS An ExAMpLE!"

**[4. Series reloaded](https://github.com/cristofima/DevsuCodeJam/blob/master/DevsuCodeJam.Exercises/SuperEasy/Exercise04.cs)**

Write a method that receives a ​**positive integer**​, and returns the ​**n<sup>th</sup>** element of this series.

-3, -2, 1, 6, 13, 22, 33, 46, 61, 78 ...

If it receives ​1​, it should return ​-3​. It it receives ​2​, it should return the next element ​-2​, and so on. If ​n <= 0​, it should return ​-1​.
