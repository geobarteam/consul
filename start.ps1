Start-Process docker-compose up
Start-Sleep -Seconds 10
.\enablePolicy.ps1
.\registerServices.ps1
.\startServices.ps1
