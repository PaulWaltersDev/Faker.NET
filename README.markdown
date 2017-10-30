Faker.NET
================================================

Credit and thanks to https://github.com/jonwingfield, whose Faker.NET repository this is forked from.

As much as possible, a line-for-line port of ffaker for ruby (https://github.com/EmmanuelOga/ffaker). With additional support for Australia.

Relies on ideas taken from Rob Conery's and Jon Wingfield's excellent sugar library (https://github.com/jonwingfield/sugar). I have just taken the idea to minimize the assembly's dependencies.

This fork was updated for a demo at a presentation on creating test data and fuzzing at Australian Testing Days 2017, for which the slides can be found at - https://docs.google.com/presentation/d/1QpGhI0LUQslqSE-iO2DjbGb-3hxd5U8Mpf5kLmgi2RE/edit?usp=sharing.


Supports .NET Framework and Mono.


Building
------------------------------------------------

nant build

nant build -D:mode=Debug


Tests
------------------------------------------------

There is a project in the solution named Faker.Net.NUnit.Tests that uses the relevant ffaker tests written in Ruby to test the .NET code.

NAnt command to run unit-tests

nant test

nant test -D:mode=Debug


Cleaning build output
-------------------------------------------------

nant clean

nant clean -D:mode=Debug
