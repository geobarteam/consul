$UrlFrontend = 'http://localhost:8500/v1/agent/service/register?token=685af0d0-779c-4ad5-8cfd-3ae5f1c40d38'
$UrlBackend1 = 'http://localhost:8501/v1/agent/service/register?token=685af0d0-779c-4ad5-8cfd-3ae5f1c40d38'
$UrlBackend2 = 'http://localhost:8502/v1/agent/service/register?token=685af0d0-779c-4ad5-8cfd-3ae5f1c40d38'
$UrlBackend3 = 'http://localhost:8503/v1/agent/service/register?token=685af0d0-779c-4ad5-8cfd-3ae5f1c40d38'

$Body = Get-Content .\services\counter.json

Invoke-RestMethod -Method Put -Uri $UrlBackend1 -Body $Body
Invoke-RestMethod -Method Put -Uri $UrlBackend2 -Body $Body
Invoke-RestMethod -Method Put -Uri $UrlBackend3 -Body $Body