# POMS

This repository contains a very small purchase order management sample. The
application consists of a C# ASP.NET Core API backend and a Vue based single
page application front end.

## Requirements

* [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) – used to
  build and run the backend.
* Any modern web browser.

## Backend

The backend project lives in the `backend` folder. It exposes a single endpoint:

```
GET /api/orders
```

which returns a list of ten sample orders in JSON format. Each order contains a
PO number, quantities and basic shipping information.

To start the API run the following commands:

```bash
cd backend
dotnet run
```

By default the API listens on `http://localhost:5000` (and `https://localhost:5001`
if HTTPS certificates are configured).

## Frontend

The Vue app in the `frontend` directory queries the API at `/api/orders` and
displays the returned data in a table.

Serve the static files with any HTTP server. One option using Python is:

```bash
cd frontend
python3 -m http.server 8080
```

With both servers running open <http://localhost:8080> in your browser to see
the orders.

## Example JSON response

Below is a trimmed example of the JSON returned by the API:

```json
[
  {
    "poNumber": "PO001",
    "orderQty": 10,
    "shipQty": 5,
    "shipper": "Shipper A",
    "consignee": "Consignee A"
  }
]
```

The front end reads these objects and shows all available fields in the table.

