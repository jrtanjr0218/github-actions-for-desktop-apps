FROM mcr.microsoft.com/dotnet/runtime:6.0

WORKDIR /app

COPY ./publish .

CMD ["ls", "-la"]
