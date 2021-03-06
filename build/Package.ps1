properties {
    $Project = "BoxKite.Notifications"
    $ScriptDir = Resolve-Path "."
    $BaseDir = Join-Path $ScriptDir ".."
    $SolutionFile = "$BaseDir\src\$Project.sln"
    $OutputDir = "$BaseDir\Deploy\Package\"
    $ArtifactsDir = "$BaseDir\artifacts\"
    $NuGetPackDir = Join-Path "$OutputDir" "Pack\"
    $BaseVersion = "0.0.5"
    $Version = "$BaseVersion-pre" 
    $PatchNumber = (git rev-list --all | wc -l).trim() # TODO: better implementation
    $AssemblyVersion = "$BaseVersion.$PatchNumber"
}

function Log-Message ($message) {
    write-host $message -foregroundcolor "green"
}

function Set-Version {
    param([Parameter(Mandatory=$true)][string]$assembly_info,[Parameter(Mandatory=$true)][string]$Version)

    $infile=get-content $assembly_info
    $regex = New-Object System.Text.RegularExpressions.Regex "\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b"
    $replace = $regex.Replace($infile,$version)
    set-content -Value $replace $assembly_info
}

function Create-IfNotFound {
    param([Parameter(Mandatory=$true)][string]$Directory)

    if ((Test-Path $Directory -PathType Container) -ne $true) {
        mkdir $Directory | out-null 
    }
}

function Clear-Recursively {
    param([Parameter(Mandatory=$true)][string]$Directory)

    if (Test-Path $Directory -PathType Container) {
        ri $Directory -Recurse | out-null 
    }
}

function Create-Package {
    param([Parameter(Mandatory=$true)][string]$PackageName,[Parameter(Mandatory=$true)][string]$TempDir)

    Create-IfNotFound $TempDir
    Create-IfNotFound $ArtifactsDir
    Create-IfNotFound "$TempDir\lib\winrt45\"
    Create-IfNotFound "$TempDir\lib\net45\"

    $PackageNameFile = "$PackageName.nuspec"
    $nuspecFile = "$BaseDir\build\$PackageName\$PackageName.nuspec"

    cp $nuspecFile $TempDir
    cp "$OutputDir\BoxKite.Notifications\BoxKite.Notifications.dll" "$TempDir\lib\winrt45\"
    cp "$OutputDir\BoxKite.Notifications.Desktop.dll" "$TempDir\lib\net45\" # TODO: why even is this off?
   
    Log-Message "Modifying placeholder in nuspec file"
    $Spec = [xml](get-content "$TempDir\$PackageNameFile")
    $Spec.package.metadata.version = ([string]$Spec.package.metadata.version).Replace("{version}",$Version)
    foreach($dependency in $Spec.package.metadata.dependencies.dependency) { 
        $dependency.version = ([string]$dependency.version).Replace("{version}",$Version)
    } 

    $Spec.Save("$TempDir\$PackageNameFile")
    exec { ..\src\.nuget\NuGet.exe pack "$TempDir\$PackageNameFile" -Output $ArtifactsDir }
    Clear-Recursively $TempDir
}

task default -depends test

task clean {
    Log-Message "Clearing tracked and untracked files"
    git checkout -- $BaseDir
    git clean -df $BaseDir
    Clear-Recursively $OutputDir
    Clear-Recursively $ArtifactsDir
}

task version -depends clean {
    Log-Message "Updating version to $version"
    foreach ($assemblyinfo in $(get-childitem -Path $BaseDir -Include "AssemblyInfo.cs" -recurse)) {
        Set-Version -assembly_info "$assemblyinfo" -Version $AssemblyVersion
    }
}   

task compile -depends clean,version  {
    msbuild $SolutionFile "/p:OutDir=$OutputDir" "/p:Configuration=Release"  "/verbosity:quiet"
}

task package -depends compile {
    Create-Package -PackageName "$Project" -TempDir $NuGetPackDir
}

task release -depends package {
    Log-Message "Clearing tracked files"
    git checkout -- $BaseDir
}