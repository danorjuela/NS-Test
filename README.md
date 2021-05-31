# NS-Test


## Inicializacion 

### DB 

Crear una Base de datos de forma local, para este caso usamos autenticacion de windows (nombre de la db "ns") si desea puede modificar la cadena de conexion 

```console
dotnet ef --startup-project ./src/NS/ database update
```

### Front End 

No es necesario correr ningun comando para usar el front de froma correcta 
pero es necesario en caso de cambios volver a compilar los archivos JS,
puede usar la version 14 de [node.js](https://nodejs.org/dist/v14.17.0/)

```console
cd src/NS/ClientApp
npm install
```
Use para desarrollo
```console
npm run watch
```
o para generar un version mimetizada 
```console
npm run prod
```
