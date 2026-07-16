$response = Invoke-WebRequest -Uri 'http://localhost:5017' -UseBasicParsing
Write-Output $response.StatusCode
Write-Output $response.Content.Substring(0, [Math]::Min(200, $response.Content.Length))
