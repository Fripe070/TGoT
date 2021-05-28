![GitHub Workflow Status (branch)](https://img.shields.io/github/workflow/status/TechnoShip123/TGoT/%F0%9F%9B%A0%20Build%20Unity%20Project/master?label=Unity%20Build&logo=github%20actions&logoColor=skyblue&style=for-the-badge)
![GitHub all releases](https://img.shields.io/github/downloads/TechnoShip123/TGoT/total?label=Downloads&logo=github&style=for-the-badge)
![GitHub top language](https://img.shields.io/github/languages/top/TechnoShip123/TGoT?style=for-the-badge)

![Supported Platforms](https://img.shields.io/badge/Platforms-Windows%20%7C%20OSX%20%7C%20Linux%20%7C%20WebGL%20%7C%20Android%20%7C%20iOS-brightgreen?style=for-the-badge&logo=unity)
# The Game Of Thonk (TGoT)

### About
This is a simple game created by me in order to learn and understand:
- [Unity](https://unity.com/) (2020.3)
- [C#](https://docs.microsoft.com/en-us/dotnet/csharp/) Development

For anyone interested, I'm learning my way around Unity using [their
learning platform](https://learn.unity.com/).

### Playing

#### Where to download
This repository has a GitHub Action that builds the project after each commit. However, I do create
releases when appropriate. In other words, the latest **stable** build can be found at the 
[releases page](https://github.com/TechnoShip123/TGoT/releases/latest), but for the latest 
(and possibly **unstable** build) you need to go to the latest 
[Unity Build workflow](https://github.com/TechnoShip123/TGoT/actions/) and scroll down to 
the artifacts. There you can download a `.zip` of the latest build by selecting your platform 
(for example `Build-StandaloneWindows64` for the latest 64-bit Windows build).

#### Supported Platforms
Currently the game is available for the following platforms:
- Linux (64-bit)
- MacOS (Intel 64-bit and Apple Silicon)
- Windows (Universal Windows Platform, 32-bit, 64-bit)
- WebGL (Defaults to [http://localhost:57492/](http://localhost:57492/))
- Android (4.4 KitKat)
- iOS (iPhone and iPad)

Note that you may have to do more for playing on MacOS and Linux (converting to program), however
everything is done and ready for windows via the TGoT Installer.

#### Installation & Uninstallation (Windows Installer)
To install the game, download and run the installer from either the 
[releases page](https://github.com/TechnoShip123/TGoT/releases/latest/) (**stable build**) 
or the latest GitHub Action for the 
[_Build Unity Project_](https://github.com/TechnoShip123/TGoT/actions/) workflow (**latest build**).
Windows might warn you with something along the lines of _"This app could harm your device blah
blah blah"_. Press _"Run anyway"_ and walk through the installer. Once finished, you should see the
game in the Start Menu (_All Apps_ section)! If you clicked the checkbox at the end, the installer
will automatically run the game, otherwise you can go to your apps menu and click to run the game.

To uninstall the game, head to `Control Panel > Programs > Programs and Features` 
(Uninstall or change a program). Right clicking the game and pressing
uninstall should take you there as well. Find the game in the list
of applications, and select it, then press **uninstall**.

#### How to play
The repository has a [Wikipedia](https://github.com/TechnoShip123/TGoT/Wiki/) where information is listed about
the game, how to play it, and more. It will of course get updated as more features arrive to the game.

### Contributing
#### All contributions are subject to the [Unity Contribution Agreement (UCA)](https://unity3d.com/legal/licenses/Unity_Contribution_Agreement)
When making a pull request, remember that you are confirming your agreement
to the terms and conditions of the UCA, including that your Contributions 
are your original creation and that you have complete right and authority
to make your Contributions.

When contributing, please have the following in mind:
- I am not experienced with Unity, in fact this project _for me to learn_ it, so please do not PR with something
you know is advanced. As annoying as it is, I won't be able to accept PRs until I completely understand what's 
  going on and how to do it myself.
- When contributing, please **do not** contribute to the master branch 
  [*TGoT/master*](https://github.com/TechnoShip123/TGoT/tree/master/), instead create a new
  branch in your fork, or even commit directly to the development branch 
  [*TGoT/dev*](https://github.com/TechnoShip123/TGoT/tree/dev/), which is where I do my 
  development and testing.
- I may turn down issues/suggestions if they are too advanced, but that _does not mean I am leaving it_.
- Please do not create issues/comments/etc that you know are not related to the repository.
- Make sure to read the Wiki before posting an issue, it may be a purposeful feature.

### Donating
You don't.
