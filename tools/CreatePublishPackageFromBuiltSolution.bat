@echo off
set startDirectory=%~dp0
set pathToOutputDirectory=%startDirectory%tempPublished
if exist "%pathToOutputDirectory%" rmdir /s /q "%pathToOutputDirectory%"
md "%pathToOutputDirectory%"
set pathToSource=%startDirectory%..\src
copy "%pathToSource%\Peons\bin\Release\Peons.dll" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons\bin\Release\Peons.pdb" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.Collections\bin\Release\Peons.Collections.dll" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.Collections\bin\Release\Peons.Collections.pdb" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.DomainEvents\bin\Release\Peons.DomainEvents.dll" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.DomainEvents\bin\Release\Peons.DomainEvents.pdb" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.DomainEvents.NinjectPublisher\bin\Release\Peons.DomainEvents.NinjectPublisher.dll" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.DomainEvents.NinjectPublisher\bin\Release\Peons.DomainEvents.NinjectPublisher.pdb" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.Logging\bin\Release\Peons.Logging.dll" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.Logging\bin\Release\Peons.Logging.pdb" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.Logging.Adapters.NLog\bin\Release\Peons.Logging.Adapters.NLog.dll" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.Logging.Adapters.NLog\bin\Release\Peons.Logging.Adapters.NLog.pdb" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.NUnit\bin\Release\Peons.NUnit.dll" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.NUnit\bin\Release\Peons.NUnit.pdb" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.NUnit.NodaTime\bin\Release\Peons.NUnit.NodaTime.dll" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.NUnit.NodaTime\bin\Release\Peons.NUnit.NodaTime.pdb" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.Web\bin\Release\Peons.Web.dll" "%pathToOutputDirectory%"
copy "%pathToSource%\Peons.Web\bin\Release\Peons.Web.pdb" "%pathToOutputDirectory%"
pause