# Cardle? (Title still pending)

## About
Cardle Made by Zach Wilson, and Eli Wilson

February 2, 2023

Based on the New York Times Wordle. Guess what the Car is based by a specific picture.

## Installing from the GitHub Release
Choose the Release of your choosing then download the standalone build zip file for that release. They generally follow the naming scheme of `Cardle-[State]-V#-#.zip`. Then unzip the game folder from the zip file, and place the contents of the game in a directory of your choosing.
You can send a shortcut for the `Cardle.exe` to the desktop should you wish.
All you need to do is click on the exe to launch and bob's your uncle.

## Playing the Game
To get the latest version of the game, you can download/play from one of the following source(s)

- [GitHub Releases](https://github.com/PlatFormPlayZ/Cardle/releases)
- [Simmer.io](https://simmer.io/@Ronis/)
- [Play the Dev Branch](https://github.com/PlatFormPlayZ/Cardle/blob/main/README.md#playing-the-dev-branch)
- [Apple Store?]()
- [Google Play Store?]()

## Playing the Dev Branch
To play the Dev Branch, all you need to do is follow the instructions below to clone the Repository...
- Install [github desktop](https://desktop.github.com/) (which I recommend for new users). 
- Either sign in with an existing github account or skip the sign-in step by supplying a username and email.
- Hit "Clone a repository from the Internet..." then Click the URL button
- Paste `https://github.com/PlatFormPlayZ/Cardle` into the URL Bar
- Then choose the file location that you would like to have the repo cloned to (Have a specific folder for it.)

Then Once you have the Repository cloned, you need to open it in Unity...
- Install [Unity HUB](https://public-cdn.cloud.unity3d.com/hub/prod/UnityHubSetup.exe) on your computer.
- For unity, you do have to have an account, so make sure you make on and or sign in yours. If you are making one, be sure to verify your email.
- Once you are signed in, skip the installation of the latest version of unity (you don't need it for this tutorial but you can get it if you want it).
- Click agree and get Personal Liscense.
- Now we need to install [Unity 2020.1.4 (aka 2020.1.4f1)](https://unity3d.com/unity/whats-new/2020.1.4) then click `Install this version with Unity Hub`.
- Then select the following Modules before continueing, 
  - Android Build Support
  - WebGL Build Support
  - Windows Build Support (IL2CPP)
- Continue and Install 2020.1.4f1 (this is going to take some time before you can move onto the last step)
- If an installation page pops up for Visual Studio, add the module `Game Development with Unity` before clicking `Install`.

Now that we have the repo cloned, unity installed, all that is left is to open the project in unity...
- Under the Projects tab in Unity Hub click `open`
- Navigate to the folder which we cloned our repo to. By Default it is `%UserProfile%/Documents/GitHub/Cardle`
- Select `Cardle` folder in the repo then click `open`
- Once the project has opened, you can play in the development environment. Do so by going to scenes > MainMenu then `Play` at the top.

If you have an error wher Unity is failing to load the project due to the layout see [this article](https://answers.unity.com/questions/1712501/stuck-in-failed-to-load-window-layout-loop.html).
To summarize try:
- Go to `%UserProfile%/AppData/Roaming/Unity/Editor-5.x/Preferences/Layouts` and delete `LastLayout.dwlt`
- Then go to the cloned Repo folder then  `./Cardle/Library/` and delete `CurrentLayout-default.dwlt`
