function Get-ScriptDirectory
{
    $Invocation = (Get-Variable MyInvocation -Scope 1).Value
    Split-Path $Invocation.MyCommand.Path
}

$ScriptDir = (Get-ScriptDirectory)
$NuGetPath = Join-Path $ScriptDir "..\src\.nuget\NuGet.exe"
$PackagePath = Join-Path $ScriptDir "..\artifacts\*.nupkg"

$Package = Get-ChildItem $PackagePath

start-process $NuGetPath  -ArgumentList "push $Package" -NoNewWindow -Wait