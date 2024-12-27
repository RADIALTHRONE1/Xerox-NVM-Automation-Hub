v1.0.0.0 (or thereabouts) of the Xerox NVM Automation Tool.

This will emulate all of the necessary key presses needed to open the PWS Diagnostic Tool, open an NVM Script to read, Save the read values, and repeat the process for as many scripts as are present.
I've included a folder of all the possible NVM values. Yes, all of them. 1,998 CSV files each with 500 values. You can use your own folders, just make sure that you have the 'Done' and 'SaveFiles' folders like the included one. (I'll probably fix this later).
As a warning, running every file will take a LONG TIME. Blank files (with no values found) take around 30 seconds to process; which means that 1,998 blank files would take around 16 hours (and files with values to read might take longer iirc).
Also, when you run the automatic tool your computer will be unusable for the duration. Press the button, walk away.

This tool is currently built to run only on a 32-bit Windows 7 System. You will need to download .NET if you don't already have it, but you should be prompted with the link for it.
If you have a 32-bit Windows 10 install, it might work, but I think I remember it taking a slightly different set of keystrokes to work. If you need support, let me know and I'll see what I can do.
If you have a 64-bit System with a working 64-bit version of the Xerox PWS Driver, please hit me up!

I've only tested this using the Versant style PWS Tools. Older tools (like 4110 old) won't work because they'll need a different sequences of key presses.

I'm also working on finishing a tool to automatically clean and convert the database files the PWS Tool saves NVM files into.