# Requires a jailbroken PS Vita / PSV TV.

This is done in VitaShell but any shell-like app that can en/decrypt content should work.

I once fucked up my save folder playing with the files in the decrypted folder so **FOLLOW EXACTLY WHAT IS WRITTEN** and nobody should be hurt.
Worst case scenario was I had to delete all my saves, reason why I'd recommend you to backup saves that matters for you.

***

## Getting your savefiles
0. (if not already done) : tick the **Enable Unsafe Homebrew** in Settings > HENkaku Settings
1. Open VitaShell then browse to ux0:user/00/savedata.
2. Highlight the PCSF00482 folder. **Do NOT press X yet !**
3. Press Δ and select _Open decrypted_, like this, then press X.
![Screenshot of the *open decrypted* button](/docs/vitahelp.png?raw=true)
4. Select the saves you want to backup with Square, then press Δ and select *Copy*.
Naming scheme : *RCX_SAVEDATA_Y.bin* where *X* is the game (1 = RaC, 2 = GC, 3 = UYA) and *Y* the slot (1-5).
5. Go to either a folder you created at ux0: or in ux0:data, then press Δ and choose *Paste*.
6. Press START and then go down to *SELECT button*. Choose the option you want to use to transfer between the Vita and the PC.
FTP will require the console to be connected to the same network as the PC.
7. Press SELECT. Follow on-screen instructions.
Grab the saves from ux0:data or the folder where you put them (I personnally put them in ux0:decrypted)

***

## Installing the saves back
0. (if not already done) : tick the **Enable Unsafe Homebrew** in Settings > HENkaku Settings
1. Open VitaShell.
2. Press START and then go down to *SELECT button*. Choose the option you want to use to transfer between the Vita and the PC. 
FTP will require the console to be connected to the same network as the PC.
3. Once tranfer is done, browse to ux0:data or the folder where you copied them.
4. Select your saves with Square, then press Δ and select *Copy*.
5. Browse to ux0:user/00/savedata.
6. Highlight the PSCF00482 folder. **Do NOT press X yet !**
7. Press Δ and select _Open decrypted_, like this, then press X.
![Screenshot of the *open decrypted* button](/docs/vitahelp.png?raw=true)
8. Press Δ and select *Paste*. Note that **NO CONFIRMATION WILL BE ASKED** and your old saves will be **UNRECOVERABLE** !

***

## General advices

* **MAKE UNENCRYPTED BACKUPS!**
* From my memories, installing a save for a slot that was never populated will make the game unhappy so I'd recommend not doing it. 
* The description for the saves is stored in an *external* file, so the file select screen will have the old save infos listed unless said (or any ?) file is loaded
* **Don't** touch anything in PCSF00482 sub-folders, especially keystone and sealedkey, or you may lose your saves !
