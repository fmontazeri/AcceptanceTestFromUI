# AcceptanceTestFromUI

<p><strong>Install Some Packages&nbsp;</strong><br />
Install-Package SpecFlow.Xunit<br />
Install-Package SpecFlow.Tools.MsBuild.Generation&nbsp;<br />
Install-Package FluentAssertions</p>

<p><strong>Automate Acceptance Tests from UI</strong><br />
Install-Package &nbsp;Seleium.WebDriver<br />
Install-Package &nbsp;Selenium.WebDriver.ChromeDriver</p>

<p><strong>Headless Browser</strong></p>

<p>Install-Package &nbsp;SpecFlow.PhantomJs.WebDriver</p>

<p><strong>Run Acceptance Test need a runner&nbsp;</strong><br />
e.g. Install-Package xunit.ruuner.visualstudio</p>

<p><br />
<strong>Generate Code-Behind</strong><br />
<strong>SpecFlow &lt; 3</strong><br />
1.&nbsp;&nbsp; &nbsp;Select Tools | Options | SpecFlow from the menu in Visual Studio, and set Enable SpecFlowSingleFileGenerator CustomTool to &quot;true&quot;<br />
2.&nbsp;&nbsp; &nbsp;Build project or restart VS</p>

<p><strong>Generate Tests From MsBuild  SpecFlow 2.4.1 or higher</strong><br />
1.&nbsp;&nbsp; &nbsp;Addd the NuGet package SpecFlow.Tools.MsBuild.Generation with the same version as SpecFlow to your project.<br />
2.&nbsp;&nbsp; &nbsp;Remove all SpecFlowSingleFileGenerator custom tool entries from your feature files.<br />
&nbsp;<br />
3.&nbsp;&nbsp; &nbsp;Select Tools | Options | SpecFlow from the menu in Visual Studio, and set Enable SpecFlowSingleFileGenerator CustomTool to &quot;false&quot;.<br />
4.&nbsp;&nbsp; &nbsp;SDK Style project system<br />
5.&nbsp;&nbsp; &nbsp;Please use the SpecFlow 2.4.1 NuGet package or higher, as this version fixes an issue with previous versions (see Known Issues below)<br />
6.&nbsp;&nbsp; &nbsp;Add the NuGet package SpecFlow.Tools.MsBuild.Generation with the same version as SpecFlow to your project.<br />
7.&nbsp;&nbsp; &nbsp;Remove all SpecFlowSingleFileGenerator custom tool entries from your feature files.<br />
&nbsp;<br />
https://specflow.org/documentation/Generate-Tests-from-MsBuild/</p>

<p><strong>SpecFlow 3 with .NET Core Support: Public Preview now Available</strong><br />
https://specflow.org/2018/specflow-3-public-preview-now-available/<br />
&nbsp;</p>

See another sample https://github.com/techtalk/SpecFlow-Examples/tree/master/ASP.NET-MVC/BookShop
