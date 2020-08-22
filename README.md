# Constant Write
[![Build Status](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Factions-badge.atrox.dev%2FLukasLangrock%2FConstantWrite%2Fbadge&style=flat)](https://actions-badge.atrox.dev/LukasLangrock/ConstantWrite/goto)

## About
This little CLI tool lets you run torture tests on your drives.
I made this because I was bored and there are probably better solutions out there but this one is open-source and .NET Core based.

## Starting the application
Right now this application is only released as pre-release as I think there are still some important features missing. You can either download the pre-release from [here](https://github.com/LukasLangrock/ConstantWrite/releases) or compile it yourself. If you know how to execute a compiled .NET Core application then you are welcome to download the pre-release but I will only provide a guide on compiling the application and not for executing the pre-release!

### Compile yourself
This will walk you through the step by step process of compiling the application from code:

1. You need to have the **.NET Core SDK** installed before you can compile using .NET Core. This project uses version 2.1 but the latest version should work fine. You can download it from [here](https://dotnet.microsoft.com/download). Make sure to get the **SDK** for **.NET Core** and NOT the *.NET Core Runtime* and neither the *.NET Framework*.

2. Secondly you need the code for this project. I assume you already know to clone a repo with git or download from GitHub. If not then take a look at that green download button at the top of the GitHub page or click [here](https://github.com/LukasLangrock/ConstantWrite/archive/master.zip).

3. Then using your favourite console you can **navigate to the `src` folder** of this project and **run `dotnet run`**. This will at first compile the code and then execute it. If you are on Windows you can also just open the src folder from the downloaded project in Windows Explorer and on the top left click on *File* and then *Open Windows PowerShell*. After that type `dotnet run` in the blue window that just opened.

4. **Done!** The application will now start up and greet you with a menu of what to do.

### Let's get to actually use it
It's very easy now. When the application starts you should see a menu from where you can start the torture test, edit settings or exit. Just type in the number of the menu point you want to select.

Thanks for using my application. Feel free to create a new isssue if you have any problems.
