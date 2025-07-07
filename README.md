# POMS

This repository contains a sample Vue single page application (SPA) and a C# ASP.NET Core API backend.

## Backend

The backend project is located in the `backend` folder. It exposes a single API endpoint `/api/orders` that returns ten sample purchase orders.

To build and run the API you need the .NET 6 SDK installed:

```bash
cd backend
dotnet run
```

## Frontend

The frontend is a minimal Vue application located in the `frontend` folder. It fetches the orders from the backend and displays them in a table.

To serve the static files you can use any HTTP server. For example:

```bash
cd frontend
python3 -m http.server 8080
```

Then open `http://localhost:8080` in your browser.

