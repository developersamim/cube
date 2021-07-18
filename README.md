# cube
technical test

# Introduction
Webapi: In dotnet 5, implemented autonomous microservice, clean architecture, CQRS pattern, mediatR, webapi running on http://localhost:5000

Angular: Angular 12.0.1, Node: 14.17, app running on http://localhost:4200

Docker: Have dockerize both of the above application with docker-compose

# Start local docker env (or run project)
Make sure you have installed and configured docker in your environment.

Step 1:
Go to folder /webapps/AngularApp/ClientApp, then run 

npm install

Step 2:
From root directory, run below command

docker-compose -f docker-compose.yml -f docker-compose.override.yml up --build

# Screenshots
<img width="1422" alt="app" src="https://user-images.githubusercontent.com/8602973/126070331-fdf7952a-466a-4408-935d-84bc2b11d9fb.png">

<img width="1422" alt="api" src="https://user-images.githubusercontent.com/8602973/126070351-4e17dbf0-bc7b-4175-844f-b42e0dd6b828.png">
