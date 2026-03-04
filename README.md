# Claim Management App

A full-stack claim management system built with **ASP.NET Core Web API**, **React**, and **Entity Framework**.

This application demonstrates a professional enterprise architecture with a service layer, RESTful APIs, and a React frontend consuming backend endpoints.

## Tech Stack

Backend

- C# (.NET Web API)
- Entity Framework Core
- SQLite Database
- REST API Architecture

Frontend

- React
- Fetch API
- Component-based architecture

## Features

- Create insurance claims
- View claims in a structured table
- Update claim status (Pending / Approved / Denied)
- Delete claims
- Persistent database storage
- RESTful API integration with React frontend

## Architecture

Controller → Service Layer → Database (Entity Framework)

Frontend communicates with backend through HTTP REST endpoints.

## API Endpoints

GET /api/claims
POST /api/claims
GET /api/claims/{id}
PUT /api/claims/{id}
DELETE /api/claims/{id}

## Screenshots

(Add screenshots of the UI here)

## Purpose

This project was built to demonstrate full-stack development skills and enterprise-style architecture using the Microsoft development stack.
