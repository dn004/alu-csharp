#!/usr/bin/env bash

# Define the name of the new project
project_name="new_project"

# Create the folder if it doesn't exist
mkdir -p "0-$project_name"

# Change to the project directory
cd "0-$project_name" || exit

# Initialize a new C# console application project
dotnet new console -n "$project_name"

# Print a message indicating the project has been initialized
echo "C# project '$project_name' initialized in '0-$project_name' folder."

