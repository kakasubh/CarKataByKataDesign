This is a console application which can be directly executed from visual studio or visual studio code.

developed using .net core 5.0 and xunit for unit testing.

Requirement:

# CarKataByKataDesign

Car Kata
You have to construct a car. Step by Step. Kata by Kata. First you have to implement the engine and the fuel tank. The default fuel level of a car is 20 liters. The maximum size of the tank is 60 liters. Of course every car's life begins with an engine not running. ;-) 
Every call of a method from the car correlates to 1 second. 
The fuel consumption in running idle is 0.0003 liter/second. For convenience the start of the engine consumes nothing and we don't care, if the engine is warm or cold. The fuel tank is on reserve, if the level is under 5 liters. 

The fuel tank display shows the level as rounded for 2 decimal places. Internally an accuracy up to 10 decimal places should be more than enough. In difference to most real cars, the fuel tank display is always showing its information, also when the engine is not running.

 Braking is BY a speed. Accelerating is TO a speed. (Remember: Every call of a method from the car correlates to 1 second.)
For every car the default acceleration is at most 10 km/h per second.
In a new further constructor of the car it should be possible to set a higher acceleration. The value has always to be in a range from 5 to 20. Correct if under minimum or above maximum.
Every car brakes at most 10 km/h per second. (Very bad brakes, I know... This car would braking bad. :D The maximum speed of a car is 250 km/h and of course it cannot have a negative speed.
The consumption for a driving car is be taken from these ranges:
1. 1 - 60 km/h -> 0.0020 liter/second
2. 61 - 100 km/h -> 0.0014 liter/second
3. 101 - 140 km/h -> 0.0020 liter/second
4. 141 - 200 km/h -> 0.0025 liter/second
5. 201 - 250 km/h -> 0.0030 liter/second
Car should have dashboard display that should have
1. fuel tank display
2. Current speed
3. Current temperature
Assume there is external service that will provide you with current temperature. In all tests only the whole car will be tested. Feel free to write your own tests for the other classes.
Add console application which will display car dashboard values. It will expect below inputs
1. Start Car
2. Stop Car
3. Brake Car (Also take number by which rate speed will be reduced)
4. Accelerate Car (Also take number by which rate speed will be increased)
5. Refuel (Also take number of liters to be refueled)

