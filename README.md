# Constant Write
[![Build Status](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Factions-badge.atrox.dev%2FLukas34%2FConstantWrite%2Fbadge&style=flat)](https://actions-badge.atrox.dev/Lukas34/ConstantWrite/goto)

## About
This little CLI tool lets you run torture tests on your drives.
I made this because I was bored and there are probably better solutions out there but this one is open-source and .NET Core based.

## How to use it
Right now this application is not yet released as I think there are still some important features missing. If you want to run and use the application anyways you will have to compile it yourself. Although that may sound difficult it totally isn't.

### Compile yourself
This will walk you through the step by step process of compiling the application from code:

1. You need to have the **.NET Core SDK** installed before you can compile using .NET Core. This project uses version 2.1 but the latest version should work fine. You can download it from [here](https://dotnet.microsoft.com/download). Make sure to get the **SDK** for **.NET Core** and NOT the *.NET Core Runtime* and neither the *.NET Framework*.

2. Secondly you need the code for this project. If you are unfamiliar with git and you just want to use the application you can click on the **green download button** and select **Download ZIP** or use this [link](https://github.com/Lukas34/ConstantWrite/archive/master.zip).

    If you however know how to use git you probably already know how to clone this repo so I will not explain this here.

3. Then using your favourite console you can **navigate to the src folder** of this project and run **`dotnet run`**. This will at first compile the code and then execute it. If you are on Windows and you don't know how to navigate using the console you can just open the src folder from the downloaded project in Windows Explorer and on the top left click on *File* and then *Open Windows PowerShell*. After that type `dotnet run` in the blue window that just opened.

4. **Done!** The application will now start up and greet you with a menu of what to do.

### Let's get to actually use it
It's very easy now. When the application starts you should see a menu from where you can start the torture test, edit settings or exit. Just type in the number of the menu point you want to select.

Thanks for using my application. Feel free to create a new isssue if you have any problems.
