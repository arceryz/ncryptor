![](/banner.png)
![](/demo.gif)

# ncryptor
A minimal AES encryption/decryption program in Windows Forms. 

- [x] Click-to-open functionality for *.aes files.
- [x] AES encryption in CBC mode with PKCS7 padding and a random IV.
- [x] Argon2id key derivation.
- [ ] Extended UI for Argon2id salt, parallelism and iterations.
- [ ] Extended UI for AES parameters.
- [ ] Memory hardening.
- [ ] CPU hardening.


# Installation

Download a release from [the releases page](https://github.com/arceryz/ncryptor/releases) and extract the folder where you like.
You can then place a shortcut to Ncryptor.exe somewhere like /Documents or /Downloads /Desktop where windows can find it.
It will show up in the windows search menu.

To setup the click-to-open functionality, go to Settings/Apps/Default Apps and then add an entry for *.aes files. Link to the extracted
executable to complete the setup.

# Feature requests

Please create issues to request new functionality! This project aims to focus only on the encryption and decryption of text files (maybe images), so keep that in mind.
