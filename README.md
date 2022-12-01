### mockify-cli

### Usage:
![help-showcase](https://github.com/omoNattie/mockify-cli/blob/master/mockify/Source/Assets/Images/help.png) <br>

### Installing: 
```git
git clone https://github.com/omoNattie/mockify-cli.git
```

```bash
cd mockify-cli/mockify
dotnet build

cd bin/Debug/net6.0

./mockify --help
```
### Post-install:

To remove the "./" by adding it to your PATH and be able to use it everywhere. <br>
### For linux users:

### Moving the script to a folder
```bash
mkdir ~/mockify-script

cd mockify-cli/mockify/bin/Debug/net6.0
chmod +x ./mockify
sudo mv ./* ~/mockify-script
```
### Moving script to PATH
for fish shell
```fish
# ~/.config/fish/config.fish

fish_add_path ~/mockify-script 
```
for bash
```bash
# ~/.bashrc

PATH="~/mockify-script:$PATH"
```

### For windows users:
Adding to PATH and being able to use it everywhere. <br>

### Moving the script to a folder
```bash
mkdir ~/mockify-script
cd ~/mockify-cli/mockify/bin/Debug/net6.0

mv ./* ~/mockify-script
```

### Adding folder to PATH <br>
Start an administrative powershell.
```bash
setx PATH "$env:path;C:\Users\{your_name}\mockify-script" -m
```

Done!