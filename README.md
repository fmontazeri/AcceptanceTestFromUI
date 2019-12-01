# AcceptanceTestFromUI

Install Some Packages 
Install-Package SpecFlow.Xunit
Install-Package SpecFlow.Tools.MsBuild.Generation 
Install-Package FluentAssertions

Automate Acceptance Tests from UI
Install-Package  Seleium.WebDriver
Install-Package  Selenium.WebDriver.ChromeDriver

Headless Browser
Install-Package  SpecFlow.PhantomJs.WebDriver

Run Acceptance Test need a runner 
e.g. Install-Package xunit.ruuner.visualstudio
Generate Code-Behind
SpecFlow < 3
1.	Select Tools | Options | SpecFlow from the menu in Visual Studio, and set Enable SpecFlowSingleFileGenerator CustomTool to "true"
2.	Build project or restart VS

Generate Tests From MsBuild  SpecFlow 2.4.1 or higher
1.	Addd the NuGet package SpecFlow.Tools.MsBuild.Generation with the same version as SpecFlow to your project.
2.	Remove all SpecFlowSingleFileGenerator custom tool entries from your feature files.
 
3.	Select Tools | Options | SpecFlow from the menu in Visual Studio, and set Enable SpecFlowSingleFileGenerator CustomTool to "false".
4.	SDK Style project system
5.	Please use the SpecFlow 2.4.1 NuGet package or higher, as this version fixes an issue with previous versions (see Known Issues below)
6.	Add the NuGet package SpecFlow.Tools.MsBuild.Generation with the same version as SpecFlow to your project.
7.	Remove all SpecFlowSingleFileGenerator custom tool entries from your feature files.
 
https://specflow.org/documentation/Generate-Tests-from-MsBuild/

SpecFlow 3 with .NET Core Support: Public Preview now Available
https://specflow.org/2018/specflow-3-public-preview-now-available/
