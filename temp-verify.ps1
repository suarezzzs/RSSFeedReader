$body = '{"url":"https://example.com/feed"}'
Invoke-RestMethod -Method Get -Uri 'http://localhost:5006/api/subscriptions' | ConvertTo-Json -Depth 5
Write-Output ''
Invoke-RestMethod -Method Post -Uri 'http://localhost:5006/api/subscriptions' -ContentType 'application/json' -Body $body | ConvertTo-Json -Depth 5
