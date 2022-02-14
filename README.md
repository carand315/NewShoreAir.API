# NewShoreAir.API

This project is built with Net Core 5.0 Framework

## SQL Server Previous Database Instance

The project will generate automatically the database based on "code first" approach. 
Needs a SQL Database instance called **localhost**, in the case will be a different name, must be changed in appsettings.json file in NewShoreAirConnection Connection String of NewShoreAir.API project.

## Compile and run the App

1. Compile the app in order to check the Nuget Packages.
2. Run the app using NewShoreAir.API profile. App will run as self-hosted
3. App creates the database from scratch
4. App runs Swagger Page

## Run SQL Seed Data  (Recommended)

NewShoreAir.DataAccess/Common contains SeedData.sql file with seed data for testing. If you prefer, you can add yours.
