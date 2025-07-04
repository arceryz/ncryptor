![](/banner.png)
![](/demo.gif)

# ncryptor
A minimal AES encryption/decryption program in Windows Forms. 

Current roadmap:
- [x] Click-to-open functionality for *.aes files.
- [x] AES encryption in CBC mode with PKCS7 padding and a random IV.
- [x] Argon2id key derivation.
- [ ] Extended UI for Argon2id salt, parallelism and iterations.
- [ ] Extended UI for AES parameters.
- [ ] Memory hardening.
- [ ] CPU hardening.

This project aims to focus only on the encryption and decryption of text files, so only create issue in that context.
I do not feel like creating an installer, because it makes the program more dependent on the system. This program is intended to be portable and usable from a USB drive.

# Installation

Download a release from [the releases page](https://github.com/arceryz/ncryptor/releases) and extract the folder where you like.
You can then place a shortcut to Ncryptor.exe somewhere like /Documents or /Downloads /Desktop where windows can find it.
It will show up in the windows search menu.

To setup the click-to-open functionality, go to Settings/Apps/Default Apps and then add an entry for *.aes files. Link to the extracted
executable to compte the setup.