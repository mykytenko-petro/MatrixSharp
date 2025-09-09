# MatrixSharp

## How to build and run project
**Execute all commands in bash/zsh/git bash**

```bash
git clone https://github.com/mykytenko-petro/MatrixSharp.git
cd MatrixSharp/
dotnet restore
dotnet restore Tests/Tests.csproj
dotnet build -p:ExcludeTests=true
cd Tests/
dotnet run
```

**Visual Studio - TBA**