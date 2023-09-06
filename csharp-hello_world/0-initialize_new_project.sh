#!/usr/bin/env bash

wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update

sudo apt-get install -y dotnet-sdk-6.0


PRJ_NAME="0-new_project"
dotnet new console -n "$PRJ_NAME"
