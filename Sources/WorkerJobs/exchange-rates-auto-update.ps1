$ProgressPreference = "SilentlyContinue"
try { 
	$Res = Invoke-WebRequest -Uri https://kioskbrains.net/worker-jobs/exchange-rates-auto-update -UseBasicParsing -Headers @{"ApiKey"="D3RXYRX45TACDKJ8X9A1CBKX7L44LIB0IUPKQCOWNG2ZYK37SA83FQ4CYEJ44ZDB"}
	$Res.StatusCode
}
catch {
	$ErrorMessage = $_.Exception.Message
	$ErrorMessage
	Exit 1
}