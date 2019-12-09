## Easy Exercises
**[1.	Decrypt my message](https://github.com/cristofima/DevsuCodeJam/blob/master/DevsuCodeJam.Exercises/Easy/Exercise01.cs)**

You have been tasked with decrypting some very cool encrypted messages. Basically, ​most_​ vowels (not necessarily all of them) of the input message have been preceded by another string, called the key.  The function will receive ​**two string**​ parameters: the first one will be the key, and the second one, the encrypted message. The function will return a ​**string**

**Example:**

**Key**​: hi

**Message**​: ​hhiighhiEr hiordhiEr fhiUncthiihions

This should return ​highEr ordEr fUnctions

Please note that if the key is ​**NOT**​ followed by a vowel, then it must be treated as part of the message.

**Example:**

**Key**​: ll

**Message**​: ​hllalls

This should return ​halls​.

The letter y is ​**NOT** ​going to be considered a vowel and vowels that contain accents are not taken into consideration.

When ​null​  or an empty string are received, it should return an empty string. If ​key​ is ​null​ or empty, then use ​DCJ​ as default.

**[2. Clock Angles](https://github.com/cristofima/DevsuCodeJam/blob/master/DevsuCodeJam.Exercises/Easy/Exercise02.cs)**

Given an ​**array of strings** ​containing string representations of time in ​hh:mm​ pattern, where ​hh​ is an integer between 00 and 23 and ​mm​ is an integer between 00 and 59, calculate the sum of the angles measured between the clock hands. If the input is not on the ​hh:mm​ pattern, you need to subtract 100 from the result. The angle ​**MUST**​ be the one between the hour hand and the minute hand, clockwise, and not the other way around. We ignore the movement caused by seconds. Every angle must be between 0 and 2π (between 0 and 360°).

**Example**​:

**Input:** ​["12:00", "17:30", "blabla", "20:21", "26:88"]

**Output:** ​39.5

The function will receive a ​**string[ ]**​, and it must return a ​**floating point number**
