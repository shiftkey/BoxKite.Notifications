function Get-ScriptDirectory
{
    $Invocation = (Get-Variable MyInvocation -Scope 1).Value
    Split-Path $Invocation.MyCommand.Path
}

$ScriptDir = (Get-ScriptDirectory)
$BaseDir = Join-Path $ScriptDir ".."
$pfx = "$BaseDir\src\MockRT.Tests\MockRT.Tests_TemporaryKey.pfx"
Certutil -importpfx "$pfx"