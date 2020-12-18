# GZDoom Launcher v1.4.1.1 source code

"ZDoom", "GZDoom", "LZDoom" and "Doom" aren't mine.

Used NuGet packages:
- Fody (used to merge libs into one executable)
- Newtonsoft Json
- SharpZipLib

## CHANGELOG
* v1.4.1.1 Fixes and minor things:
Now you can load a profile without getting weird errors.
Fixed typo in labelMultItemGuide.
When opening the "Select PWADs" dialog use .pk3 files as default extension.
Now the launcher founds the WAD and the GZD/ZD/LZD directories using `AppDomain.CurrentDomain.BaseDirectory`, not `Directory.GetCurrentDirectory()`.
Added some parameters to the launcher:
	-loadprofile [path] to autoload a profile file.
	-autostart to automatically start the game when you open the launcher
	-closeonstart to automatically check the `Close launcher on start` checkbox.

* v1.4 new features: Added a remove IWAD and PWADs button. Removed the window that asks you to copy the WAD in the IWADs/PWADs folder.
Fixes and minor things:
Now you can see the whole WAD path.
New text that tells you can use CTRL or SHIFT to select multiple PWADs.
Now you can add multiple wads at the same time with the + button.

* v1.3 new features: Now you can also download LZDoom and ZDoom from the launcher.

* v1.2 new features: Added profiles! Now you can export and import settings. Added the info button (?).

* v1.1 new features: Replaced the "Open folder" button with the "Add WAD" one.


You can find the latest not-zipped exe in the bin/Release folder.