$Url = 'http://localhost:8501/v1/acl/create?token=685af0d0-779c-4ad5-8cfd-3ae5f1c40d38'
$BodyAnonymous = Get-Content .\acl\anonymous.json
$BodyAdministrator = Get-Content .\acl\Administrator.json

Invoke-RestMethod -Method Put -Uri $Url -Body $BodyAnonymous
Invoke-RestMethod -Method Put -Uri $Url -Body $BodyAdministrator
