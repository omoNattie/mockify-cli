### mockify-cli

```git
git clone https://github.com/omoNattie/mockify-cli.git
```

```bash
cd mockify-cli/mockify
dotnet build

cd bin/Debug/net6.0
```

then run the program based on your OS.

### for linux users
To remove the "./" by adding it to your PATH and be able to use it everywhere. <br>
### Moving the script to a folder
```bash
mkdir ~/mockify-script

cd mockify-cli/mockify/bin/Debug/net6.0
chmod +x ./mockify
sudo mv ./mockify ~/mockify-script
```
### Moving script to PATH
for fish shell
```
# ~/.config/fish/config.fish

fish_add_path ~/mockify-script 
```
for bash
```bash
# ~/.bashrc

PATH="~/mockify-script:$PATH"
```
