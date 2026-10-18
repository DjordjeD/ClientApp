# ClientApp

Windows Forms client for a small lookup service built for Algotech. Its partner is [ServerApp](https://github.com/DjordjeD/ServerApp).

The client shows a login screen and asks the server for a person by name and surname. The two talk over a SOAP web service: the proxy is generated under `Web References/localhost` from the server's `WebService1.asmx`.

## Stack

C# · .NET Framework · Windows Forms · ASMX/SOAP

## Run

1. Start [ServerApp](https://github.com/DjordjeD/ServerApp) locally (IIS Express from Visual Studio).
2. Open `ClientApp.sln` in Visual Studio.
3. If the server runs on a different port, update the web reference URL in `App.config`.
4. Run it with F5.
