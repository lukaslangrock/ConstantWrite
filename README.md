# Constant Write
[![Build status](https://lukaslangrock.visualstudio.com/ConstantWrite/_apis/build/status/.NET%20Core-CI)](https://lukaslangrock.visualstudio.com/ConstantWrite/_build/latest?definitionId=19)

## About
This little CLI tool lets you run torture tests on your drives.
I made this because I was bored and there are probably better solutions out there but this one is open-source and dotnet-core based.

## How to use it
### Run
Rights now I have no releases because the project is nowhere near completion. If you want to try it anyways, click on the [Azure Pipeline](https://lukaslangrock.visualstudio.com/ConstantWrite/_build) badge and download the artifacts from the newest drop. From there you just launch cmd or a shell if you are on linux and navigate to the downloaded (and extracted) artifacts. Then just run `dotnet ConstantWrite.dll` and my application should startup.

And make sure you have the [dotnet core](https://dotnet.microsoft.com) runtime installed and updated to the newest official version.

### Compile yourself
You can also [download](https://github.com/Lukas34/ConstantWrite/archive/master.zip) or the source code and run `dotnet run` in the `src` folder. I haven't tried that yet but I guess it should work.
Good luck.

### Let's get to actually use it
It's very easy now. When the application starts you should see a menu from where you can start the stress test(which is not supported yet), edit settings and exit. Hit me up if you have any problems.
