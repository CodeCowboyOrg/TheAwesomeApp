Set-location "C:\Users\jfan\Documents\visual studio 2015\Projects\TheAwesomeApp\TheAwesomeApp\bin\Debug\mybin"
[System.Reflection.Assembly]::Load("System.EnterpriseServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")
$publish = New-Object System.EnterpriseServices.Internal.Publish
$publish.GacInstall("C:\Users\jfan\Documents\visual studio 2015\Projects\TheAwesomeApp\TheAwesomeApp\bin\Debug\mybin\AwesomeAssemblySigned.dll")
