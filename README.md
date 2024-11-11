# UnityIgnore
A simple system to be able to ignore files with Unity's managed version control.

## Why?
Some packages or libraries tend to utilize the unity folder for cache files or user files. The issue is, that using Unity in combination with perforce (for example) don't obey any ignore file.
Therefore I made this small package that reads a custom .unityIgnore file in the root folder of the project and makes sure to not commit changes to these files.

## How to use it:
Install the package and create a .unityIgnore file in the root folder of your project. Make sure that a version control package is enabled, as it otherwise won't do anything.
You can write glob-specific paths into the .unityIgnore file and create comments by starting the line with a #. You can also use regex expression which can be handled by C# Regex library. To do that start the line with an "r" followed by your regex without a space.
