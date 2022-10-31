var target = Argument("target", "Build");
var configuration = Argument("configuration", "Release");

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////


Task("Build")
    .Does(() =>
{
    var settings = new MSBuildSettings();
    settings.SetConfiguration(configuration);
    settings.ToolVersion = MSBuildToolVersion.VS2022;

    MSBuild("mac-test-ci.csproj", settings);
});

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);