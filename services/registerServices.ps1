$UrlFrontend = 'http://localhost:8500/v1/agent/service/register'
$UrlBackend1 = 'http://localhost:8501/v1/agent/service/register'
$UrlBackend2 = 'http://localhost:8502/v1/agent/service/register'
$UrlBackend3 = 'http://localhost:8503/v1/agent/service/register'

$Body = Get-Content .\counter.json

Invoke-RestMethod -Method Put -Uri $UrlBackend1 -Body $Body
Invoke-RestMethod -Method Put -Uri $UrlBackend2 -Body $Body
Invoke-RestMethod -Method Put -Uri $UrlBackend3 -Body $Body