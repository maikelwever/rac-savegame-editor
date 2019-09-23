# rac-savegame-editor

A savegame editor for the Ratchet and Clank series of games.


# Functional parts
 
 - Can load savegames in PS3 format, both decrypted and encrypted.
 - Contains code (currently not in use) to re-crypt the savegame for import on an actual PS3.
 - Loads some basic values from the savegame and shows these in the UI.


# Currently supported games

 - Ratchet and Clank 1 (OG)
 - Ratchet and Clank 2 (Going Commando)
 - Ratchet and Clank 3 (Up Your Arsenal)


# Do I need the encrypted or decrypted load button?

 - If you are importing RPCS3 savegames, these are all stored decrypted.
 - If you have decrypted your saves manually (with pfdtool or something similar), use the decrypted button.
 - Else, use the encrypted button. The default encryption key is all 0xFF, and works on unencrypted games as well. 


# Short term roadmap

 - Support all Ratchet games on the PS3.
 - Add as much editable value as currently known.
 - Support opening .PSU files from PS2 Quadriligy (so not the PSP ports for now).


# Development

The project is written in C# and uses GTK3 via GtkSharp for UI rendering. It expects to be built using .NET Core 2.0.
You can use whatever IDE or editor you like, but one with .sln or .csproj support will be nice to have.

I've used both VS Code, Rider, and Visual Studio in the past.
Alternatively, you can just use your favorite editor, and the `dotnet` command-line tool.

For development of the UI parts, please see the GTK notes below.


## Adding new addresses for values in savegames

I've tried to make it as easy as possible to add new values to edit.
Please see `GameItems.cs` for a list of currently supported items.
You can add new items in the same style as the current definitions.


## Getting GTK on Windows

### For end-users or non-UI developers

The simpelest way to globally install the GTK3 libraries is by using a redist package:
https://github.com/tschoonj/GTK-for-Windows-Runtime-Environment-Installer/releases/tag/2019-08-05

Ensure the 'Add to PATH' box is ticked during install, 
and restart your IDE if it was open during the installation process.

### For (UI) developers

The most feature complete way of dealing with GTK3 on Windows is by installing MSYS2.
A small guide is written here: https://www.gtk.org/download/windows.php .

Follow the 'Using GTK from MSYS2 packages' guide, and ensure you install at least:

  - mingw-w64-x86_64-gtk3
  - mingw-w64-x86_64-glade
  - mingw-w64-x86_64-devhelp

Afterwards, add the msys2 mingw64 binary path to your system's PATH environment variable, 
and restart open IDE processes. 
For reference, the binary path looks like this: `c:\\msys64\\mingw64\\bin`.

### For bundling in a zip together with the main executable

Most easy is to install the redist package (see above), 
and copy `c:\\Program Files\\GTK3-Runtime Win64\\` to an empty folder.

Build with your favorite build tooling, 
and copy the bin/Debug (or bin/Release) folder contents to the `bin` folder of your previously empty folder.


## Getting help

If you want some help getting this to run, or are not sure where to change something, please find me on the game-fuckery-inc Discord server.
You can recognize me by the avatar ;)


# Legal stuff

This project is licensed under the GNU General Public License v3.0. Please see the LICENSE file for more details.

This project uses a modified version of PS3SaveManager by Jappi88. For more details, please see: https://github.com/maikelwever/ps3savemanager
