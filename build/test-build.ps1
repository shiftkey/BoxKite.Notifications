function Get-ScriptDirectory
{
    $Invocation = (Get-Variable MyInvocation -Scope 1).Value
    Split-Path $Invocation.MyCommand.Path
}

$ScriptDir = (Get-ScriptDirectory)
$ToolsPath = Join-Path $ScriptDir "..\tools"

import-module "$ToolsPath\psake\psake.psm1"
invoke-psake "$ScriptDir\Package.ps1" test